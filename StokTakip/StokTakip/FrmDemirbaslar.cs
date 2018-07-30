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
    public partial class FrmDemirbaslar : Form
    {
        public FrmDemirbaslar()
        {
            InitializeComponent();
        }

        dbIslemleri db = new dbIslemleri();
        ErrorProvider ep = new ErrorProvider();
        public int GRUP_ID;
        private void FrmDemirbaslar_Load(object sender, EventArgs e)
        {
           
            listele();
            temizle();
        }

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select DEMIRBAS_ID,DEMIRBAS_NO,DEMIRBAS_ADI,DEMIRBAS_CINSI,DEMIRBAS_OZELLIK,DEMIRBAS_MARKA,DEMIRBAS_ACIKLAMA,TBL_GRUP.GRUP_AD  from TBL_DEMIRBAS INNER JOIN TBL_GRUP ON TBL_DEMIRBAS.GRUP_ID=TBL_GRUP.GRUP_ID ORDER BY DEMIRBAS_ADI ASC", db.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void doldur()
        {
            
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtdemirbasid.Text = dr["DEMIRBAS_ID"].ToString();
            txtdemirbasno.Text = dr["DEMIRBAS_NO"].ToString();
            txtdemirbasad.Text = dr["DEMIRBAS_ADI"].ToString();
            txtdemirbascinsi.Text = dr["DEMIRBAS_CINSI"].ToString();
            txtdemirbasmarka.Text = dr["DEMIRBAS_MARKA"].ToString();
            txtdemirbasozellik.Text = dr["DEMIRBAS_OZELLIK"].ToString();
            txtdemirbasaciklama.Text = dr["DEMIRBAS_ACIKLAMA"].ToString();
            te_grup.Text = dr["GRUP_AD"].ToString();
        }
        void temizle()
        {
            txtdemirbasid.Text = "";
            txtdemirbasno.Text = "";
            txtdemirbasad.Text = "";
            txtdemirbascinsi.Text = "";
            txtdemirbasmarka.Text = "";
            txtdemirbasozellik.Text = "";
            txtdemirbasaciklama.Text = "";
            te_grup.Text = "";
        }
        public int ID;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
             DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            ID = Convert.ToInt32(dr["DEMIRBAS_ID"].ToString());
            this.DialogResult = DialogResult.OK;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            doldur();
        }

        private void btnDemirbasEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdemirbasno.Text.Trim() == "") ep.SetError(txtdemirbasno, "*"); else ep.SetError(txtdemirbasno, "");
                if (txtdemirbasad.Text.Trim() == "") ep.SetError(txtdemirbasad, "*"); else ep.SetError(txtdemirbasad, "");
                if (txtdemirbascinsi.Text.Trim() == "") ep.SetError(txtdemirbascinsi, "*"); else ep.SetError(txtdemirbascinsi, "");
                if (txtdemirbasmarka.Text.Trim() == "") ep.SetError(txtdemirbasmarka, "*"); else ep.SetError(txtdemirbasmarka, "");
                if (txtdemirbasozellik.Text.Trim() == "") ep.SetError(txtdemirbasozellik, "*"); else ep.SetError(txtdemirbasozellik, "");
                
                if (txtdemirbasno.Text.Trim() != "" && txtdemirbasad.Text.Trim() != "" && txtdemirbascinsi.Text.Trim() != "" && txtdemirbasmarka.Text.Trim() != "" && txtdemirbasozellik.Text.Trim() != "" )
                {
                    SqlCommand komutekle = new SqlCommand("INSERT INTO TBL_DEMIRBAS(DEMIRBAS_NO,DEMIRBAS_ADI,DEMIRBAS_CINSI,DEMIRBAS_MARKA,DEMIRBAS_OZELLIK,DEMIRBAS_ACIKLAMA,GRUP_ID) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", db.baglanti());
                    komutekle.Parameters.AddWithValue("@p1", txtdemirbasno.Text);
                    komutekle.Parameters.AddWithValue("@p2", txtdemirbasad.Text);
                    komutekle.Parameters.AddWithValue("@p3", txtdemirbascinsi.Text);
                    komutekle.Parameters.AddWithValue("@p4", txtdemirbasmarka.Text);
                    komutekle.Parameters.AddWithValue("@p5", txtdemirbasozellik.Text);
                    komutekle.Parameters.AddWithValue("@p6", txtdemirbasaciklama.Text);
                    komutekle.Parameters.AddWithValue("@p7", GRUP_ID);
                    komutekle.ExecuteNonQuery();
                    db.baglanti().Close();
                    MessageBox.Show("Demirbaş sisteme eklendi.");
                    listele();
                    temizle();
                }
            }
            catch
            {
                MessageBox.Show("Kaydetme işlemi sırasında hata oluştu. Lütfen girdiğiniz bilgileri kontrol ediniz.");
            }

        }

        private void btnDemirbasTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnDemirbasSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_DEMIRBAS WHERE DEMIRBAS_ID=@p1", db.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtdemirbasid.Text);
                komutsil.ExecuteNonQuery();
                db.baglanti().Close();
                MessageBox.Show("Demirbaş sistemden silindi.");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu.");

            }
        }

        private void btnDemirbasGuncele_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdemirbasno.Text.Trim() == "") ep.SetError(txtdemirbasno, "*"); else ep.SetError(txtdemirbasno, "");
                if (txtdemirbasad.Text.Trim() == "") ep.SetError(txtdemirbasad, "*"); else ep.SetError(txtdemirbasad, "");
                if (txtdemirbascinsi.Text.Trim() == "") ep.SetError(txtdemirbascinsi, "*"); else ep.SetError(txtdemirbascinsi, "");
                if (txtdemirbasmarka.Text.Trim() == "") ep.SetError(txtdemirbasmarka, "*"); else ep.SetError(txtdemirbasmarka, "");
                if (txtdemirbasozellik.Text.Trim() == "") ep.SetError(txtdemirbasozellik, "*"); else ep.SetError(txtdemirbasozellik, "");

                if (txtdemirbasno.Text.Trim() != "" && txtdemirbasad.Text.Trim() != "" && txtdemirbascinsi.Text.Trim() != "" && txtdemirbasmarka.Text.Trim() != "" && txtdemirbasozellik.Text.Trim() != "")
                {
                    SqlCommand komutguncelle = new SqlCommand("update TBL_DEMIRBAS set DEMIRBAS_NO=@p1,DEMIRBAS_ADI=@p2,DEMIRBAS_CINSI=@p3,DEMIRBAS_MARKA=@p4,DEMIRBAS_OZELLIK=@p5,DEMIRBAS_ACIKLAMA=@p6, GRUP_ID=@p7 where DEMIRBAS_ID=@p0", db.baglanti());
                    komutguncelle.Parameters.AddWithValue("@p0", txtdemirbasid.Text);
                    komutguncelle.Parameters.AddWithValue("@p1", txtdemirbasno.Text);
                    komutguncelle.Parameters.AddWithValue("@p2", txtdemirbasad.Text);
                    komutguncelle.Parameters.AddWithValue("@p3", txtdemirbascinsi.Text);
                    komutguncelle.Parameters.AddWithValue("@p4", txtdemirbasmarka.Text);
                    komutguncelle.Parameters.AddWithValue("@p5", txtdemirbasozellik.Text);
                    komutguncelle.Parameters.AddWithValue("@p6", txtdemirbasaciklama.Text);
                    komutguncelle.Parameters.AddWithValue("@p7", GRUP_ID);
                    komutguncelle.ExecuteNonQuery();
                    db.baglanti().Close();
                    MessageBox.Show("Demirbaş bilgileri güncellendi.");
                    listele();
                    temizle();
                }
            }
            catch
            {
                MessageBox.Show("Güncelleme işlemi sırasında hata oluştu. Lütfen girdiğiniz bilgileri kontrol ediniz.");
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            doldur();
        }

        private void te_grup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string grupad;
            FrmGruplar grup = new FrmGruplar();

            if (grup.ShowDialog() == DialogResult.OK)
            {
                GRUP_ID = grup.ID;
                SqlCommand komutid = new SqlCommand("SELECT GRUP_AD FROM TBL_GRUP WHERE GRUP_ID='" + GRUP_ID.ToString() + "'", db.baglanti());
                SqlDataReader dr = komutid.ExecuteReader();
                while (dr.Read())
                {

                    grupad = dr["GRUP_AD"].ToString();
                    te_grup.Text = grupad;
                }
            }
        }

        private void te_grup_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
