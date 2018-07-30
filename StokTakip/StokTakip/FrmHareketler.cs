using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StokTakip
{
    public partial class FrmHareketler : Form
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }
        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            labelControl4.Text = "";
        }
        public int DEMIRBAS_ID;
        dbIslemleri db = new dbIslemleri();
        private void textEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            vericek();
        }

        private void txtdemirbasno_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            vericek();
        }

        private void txtdemirbasad_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            vericek();
        }
        void vericek()
        {
            string demirbasad;
            string demirbasno;
            string demirbasid;
            dbIslemleri db = new dbIslemleri();
            FrmDemirbaslar demirbas = new FrmDemirbaslar();

            if (demirbas.ShowDialog() == DialogResult.OK)
            {
                DEMIRBAS_ID = demirbas.ID;
                SqlCommand komutid = new SqlCommand("SELECT DEMIRBAS_NO,DEMIRBAS_ADI FROM TBL_DEMIRBAS WHERE DEMIRBAS_ID='" + DEMIRBAS_ID.ToString() + "'", db.baglanti());
                SqlDataReader dr = komutid.ExecuteReader();
                while (dr.Read())
                {

                    demirbasid = DEMIRBAS_ID.ToString();
                    demirbasno = dr["DEMIRBAS_NO"].ToString();
                    demirbasad = dr["DEMIRBAS_ADI"].ToString();
                    txtdemirbasid.Text = demirbasid;
                    txtdemirbasno.Text = demirbasno;
                    txtdemirbasad.Text = demirbasad;
                }
            }
        }
        void temizle()
        {
            txtdemirbasid.Text = "";
            txtdemirbasno.Text = "";
            txtdemirbasad.Text = "";
        }

        private void btnHareketAra_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_DEMIRBAS.DEMIRBAS_NO,TBL_DEMIRBAS.DEMIRBAS_ADI AS DEMİRBAŞ_ADI, b1.BIRIM_AD AS ESKİ_BİRİM,b2.BIRIM_AD AS YENİ_BİRİM,TARIH FROM TBL_TESLIMAT INNER JOIN TBL_BIRIM b1 ON TBL_TESLIMAT.E_BIRIMID=b1.BIRIM_ID INNER JOIN TBL_BIRIM b2 ON TBL_TESLIMAT.Y_BIRIMID=b2.BIRIM_ID INNER JOIN TBL_PERSONEL ON TBL_TESLIMAT.TESLIM_ALAN=TBL_PERSONEL.PERSONEL_ID INNER JOIN TBL_DEMIRBAS ON TBL_TESLIMAT.DEMIRBAS_ID=TBL_DEMIRBAS.DEMIRBAS_ID WHERE TBL_DEMIRBAS.DEMIRBAS_ID='" + txtdemirbasid.Text+"' ORDER BY TARIH DESC", db.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlCommand komut = new SqlCommand("SELECT TOP 1 b.BIRIM_AD FROM TBL_TESLIMAT INNER JOIN TBL_BIRIM b ON TBL_TESLIMAT.Y_BIRIMID=b.BIRIM_ID WHERE DEMIRBAS_ID='"+txtdemirbasid.Text+"' ORDER BY TARIH DESC",db.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelControl4.Text = dr["BIRIM_AD"].ToString();
                
            }

        }

        private void btnHareketTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        
    }
}
