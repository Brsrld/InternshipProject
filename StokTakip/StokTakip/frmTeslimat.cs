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
    public partial class frmTeslimat : Form
    {
        public frmTeslimat()
        {
            InitializeComponent();
        }

        dbIslemleri db = new dbIslemleri();
        ErrorProvider ep = new ErrorProvider();

        public int demirbasid;
        public int personelid;
        public int ybirimid;
        public int ebirimid;

        public int demirbas_id;
        public int personel_id;
        public int y_birimid;
        public int e_birimid;

        private void frmTeslimat_Load(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToLongDateString();
            listele();
            temizle();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TESLIMAT_ID AS ID,TBL_DEMIRBAS.DEMIRBAS_NO,TBL_DEMIRBAS.DEMIRBAS_ADI AS DEMİRBAŞ_ADI, b1.BIRIM_AD AS ESKİ_BİRİM,b2.BIRIM_AD AS YENİ_BİRİM,TBL_PERSONEL.PERSONEL_AD,TBL_PERSONEL.PERSONEL_SOYAD, TARIH FROM TBL_TESLIMAT INNER JOIN TBL_BIRIM b1 ON TBL_TESLIMAT.E_BIRIMID=b1.BIRIM_ID INNER JOIN TBL_BIRIM b2 ON TBL_TESLIMAT.Y_BIRIMID=b2.BIRIM_ID INNER JOIN TBL_PERSONEL ON TBL_TESLIMAT.TESLIM_ALAN=TBL_PERSONEL.PERSONEL_ID INNER JOIN TBL_DEMIRBAS ON TBL_TESLIMAT.DEMIRBAS_ID=TBL_DEMIRBAS.DEMIRBAS_ID ORDER BY DEMIRBAS_ADI ASC ", db.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtteslimatid.Text = "";
            bedemirbasadi.Text = "";
            beEbirim.Text = "";
            beYbirim.Text = "";
            beteslimalan.Text = "";
            lbltarih.Text = DateTime.Now.ToLongDateString();
        }
        void txtdoldur()
        {
            
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
           // txtteslimatid.Text = dr["ID"].ToString();
           // bedemirbasadi.Text = dr["DEMİRBAŞ_ADI"].ToString();
           // beEbirim.Text = dr["ESKİ_BİRİM"].ToString();
           // beYbirim.Text = dr["YENİ_BİRİM"].ToString();
           // beteslimalan.Text = dr["PERSONEL_AD"].ToString() + " " + dr["PERSONEL_SOYAD"].ToString();

            /////////////////////////////////////////////////////////////////////////////////////////////

            int id= Convert.ToInt32(dr["ID"].ToString());

            SqlCommand komut = new SqlCommand("SELECT TESLIMAT_ID AS ID,TBL_DEMIRBAS.DEMIRBAS_ADI AS DEMİRBAŞ_ADI,TBL_DEMIRBAS.DEMIRBAS_ID, b1.BIRIM_AD AS ESKİ_BİRİM,b1.BIRIM_ID AS E_BIRIMID,b2.BIRIM_AD AS YENİ_BİRİM,b2.BIRIM_ID AS Y_BIRIMID,TBL_PERSONEL.PERSONEL_ID,TBL_PERSONEL.PERSONEL_AD,TBL_PERSONEL.PERSONEL_SOYAD, TARIH FROM TBL_TESLIMAT INNER JOIN TBL_BIRIM b1 ON TBL_TESLIMAT.E_BIRIMID=b1.BIRIM_ID INNER JOIN TBL_BIRIM b2 ON TBL_TESLIMAT.Y_BIRIMID=b2.BIRIM_ID INNER JOIN TBL_PERSONEL ON TBL_TESLIMAT.TESLIM_ALAN=TBL_PERSONEL.PERSONEL_ID INNER JOIN TBL_DEMIRBAS ON TBL_TESLIMAT.DEMIRBAS_ID=TBL_DEMIRBAS.DEMIRBAS_ID where TESLIMAT_ID='"+ dr["ID"].ToString() +"'",db.baglanti());
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                txtteslimatid.Text = dr1["ID"].ToString();
                bedemirbasadi.Text = dr1["DEMİRBAŞ_ADI"].ToString();
                beEbirim.Text = dr1["ESKİ_BİRİM"].ToString();
                beYbirim.Text = dr1["YENİ_BİRİM"].ToString();
                beteslimalan.Text = dr1["PERSONEL_AD"].ToString() + " " + dr["PERSONEL_SOYAD"].ToString();
                lbltarih.Text = dr1["TARIH"].ToString();

                demirbas_id = Convert.ToInt32(dr1["DEMIRBAS_ID"].ToString());
                personel_id = Convert.ToInt32(dr1["PERSONEL_ID"].ToString());
                e_birimid = Convert.ToInt32(dr1["E_BIRIMID"].ToString());
                y_birimid = Convert.ToInt32(dr1["Y_BIRIMID"].ToString());

                
            }

        }
        
        private void beteslimalan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string teslimalanad;
            string teslimalansoyad;
            frmPersonel personel = new frmPersonel();

            if (personel.ShowDialog() == DialogResult.OK)
            {
                personelid = personel.ID;
                SqlCommand komutid = new SqlCommand("SELECT PERSONEL_AD, PERSONEL_SOYAD FROM TBL_PERSONEL WHERE PERSONEL_ID='" + personel.ID.ToString() + "'", db.baglanti());
                SqlDataReader dr = komutid.ExecuteReader();
                while (dr.Read())
                {
                    teslimalanad = dr["PERSONEL_AD"].ToString();
                    teslimalansoyad = dr["PERSONEL_SOYAD"].ToString();
                    beteslimalan.Text = teslimalanad + " " + teslimalansoyad;
                }

            }
        }
        
        private void beEbirim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string birimad;
            frmBirimler birimler = new frmBirimler();

            if (birimler.ShowDialog() == DialogResult.OK)
            {
                ebirimid = birimler.ID;
                SqlCommand komutid = new SqlCommand("SELECT BIRIM_AD FROM TBL_BIRIM WHERE BIRIM_ID='" + ebirimid.ToString() + "'", db.baglanti());
                SqlDataReader dr = komutid.ExecuteReader();
                while (dr.Read())
                {

                    birimad = dr["BIRIM_AD"].ToString();
                    beEbirim.Text = birimad;
                }
            }
        }
        
        private void beYbirim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            string birimad;
            frmBirimler birimler = new frmBirimler();

            if (birimler.ShowDialog() == DialogResult.OK)
            {
                ybirimid = birimler.ID;
                SqlCommand komutid = new SqlCommand("SELECT BIRIM_AD FROM TBL_BIRIM WHERE BIRIM_ID='" + ybirimid.ToString() + "'", db.baglanti());
                SqlDataReader dr = komutid.ExecuteReader();
                while (dr.Read())
                {

                    birimad = dr["BIRIM_AD"].ToString();
                    beYbirim.Text = birimad;
                }
            }
        }
        
        private void bedemirbasadi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string demirbasad;
            FrmDemirbaslar demirbas = new FrmDemirbaslar();

            if (demirbas.ShowDialog() == DialogResult.OK)
            {
                demirbasid = demirbas.ID;
                SqlCommand komutid = new SqlCommand("SELECT DEMIRBAS_ADI FROM TBL_DEMIRBAS WHERE DEMIRBAS_ID='" + demirbas.ID.ToString() + "'", db.baglanti());
                SqlDataReader dr = komutid.ExecuteReader();
                while (dr.Read())
                {

                    demirbasad = dr["DEMIRBAS_ADI"].ToString();
                    bedemirbasadi.Text = demirbasad;
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtdoldur();
        }

        private void btnTeslimatEkle_Click(object sender, EventArgs e)
        {
            FrmDemirbaslar demirbas = new FrmDemirbaslar();
            frmPersonel personel = new frmPersonel();

            try
            {


                if (bedemirbasadi.Text.Trim() == "") ep.SetError(bedemirbasadi, "*"); else ep.SetError(bedemirbasadi, "");
                if (beEbirim.Text.Trim() == "") ep.SetError(beEbirim, "*"); else ep.SetError(beEbirim, "");
                if (beYbirim.Text.Trim() == "") ep.SetError(beYbirim, "*"); else ep.SetError(beYbirim, "");
                if (beteslimalan.Text.Trim() == "") ep.SetError(beteslimalan, "*"); else ep.SetError(beteslimalan, "");

                if (bedemirbasadi.Text.Trim() != "" && beEbirim.Text.Trim() != "" && beYbirim.Text.Trim() != "" && beteslimalan.Text.Trim() != "")
                {
                    SqlCommand teslimatekle = new SqlCommand("INSERT INTO TBL_TESLIMAT(DEMIRBAS_ID,E_BIRIMID,Y_BIRIMID,TESLIM_ALAN,TARIH) VALUES (@p1,@p2,@p3,@p4,getdate())", db.baglanti());
                    teslimatekle.Parameters.AddWithValue("@p1", demirbasid);
                    teslimatekle.Parameters.AddWithValue("@p2", ebirimid);
                    teslimatekle.Parameters.AddWithValue("@p3", ybirimid);
                    teslimatekle.Parameters.AddWithValue("@p4", personelid);
                    teslimatekle.ExecuteNonQuery();
                    db.baglanti().Close();
                    MessageBox.Show("Teslimat sisteme eklendi.");
                    listele();
                    temizle();
                }
            }
            catch
            {
                MessageBox.Show("Eklenmedi. Lütfen girdiğiniz bilgileri kontrol ediniz");
            }



        }

        private void btnTeslimatTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnTeslimatSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_TESLIMAT where TESLIMAT_ID=@p1", db.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtteslimatid.Text);
                komutsil.ExecuteNonQuery();
                db.baglanti().Close();
                MessageBox.Show("Teslimat sistemden silindi.");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu.");
            }
        }

        private void btnTeslimatGuncele_Click(object sender, EventArgs e)
        {
            FrmDemirbaslar demirbas = new FrmDemirbaslar();
            frmPersonel personel = new frmPersonel();

            try
            {



                if (bedemirbasadi.Text.Trim() == "") ep.SetError(bedemirbasadi, "*"); else ep.SetError(bedemirbasadi, "");
                if (beEbirim.Text.Trim() == "") ep.SetError(beEbirim, "*"); else ep.SetError(beEbirim, "");
                if (beYbirim.Text.Trim() == "") ep.SetError(beYbirim, "*"); else ep.SetError(beYbirim, "");
                if (beteslimalan.Text.Trim() == "") ep.SetError(beteslimalan, "*"); else ep.SetError(beteslimalan, "");

                if (bedemirbasadi.Text.Trim() != "" && beEbirim.Text.Trim() != "" && beYbirim.Text.Trim() != "" && beteslimalan.Text.Trim() != "")
                {
                    //guncellesaglama();
                    SqlCommand komutupdate = new SqlCommand("update TBL_TESLIMAT set DEMIRBAS_ID=@p2, E_BIRIMID=@p3, Y_BIRIMID=@p4, TESLIM_ALAN=@p5 where TESLIMAT_ID=@p1", db.baglanti());
                    komutupdate.Parameters.AddWithValue("@p1", txtteslimatid.Text);
                    komutupdate.Parameters.AddWithValue("@p2", demirbas_id);
                    komutupdate.Parameters.AddWithValue("@p3", e_birimid);
                    komutupdate.Parameters.AddWithValue("@p4", y_birimid);
                    komutupdate.Parameters.AddWithValue("@p5", personel_id);
                    komutupdate.ExecuteNonQuery();
                }
                
                db.baglanti().Close();
                MessageBox.Show("Teslimat bilgileri güncellendi.");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu.");
            }
        }

     

        private void beEbirim_EditValueChanged(object sender, EventArgs e)
        {
            e_birimid = ebirimid;
        }

        private void bedemirbasadi_EditValueChanged(object sender, EventArgs e)
        {
            demirbas_id = demirbasid;
        }

        private void beYbirim_EditValueChanged(object sender, EventArgs e)
        {
            y_birimid = ybirimid;
        }

        private void beteslimalan_EditValueChanged(object sender, EventArgs e)
        {
            personel_id = personelid;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtdoldur();
        }
    }
}

