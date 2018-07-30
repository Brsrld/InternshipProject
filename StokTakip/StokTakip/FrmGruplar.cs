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
    public partial class FrmGruplar : Form
    {
        public FrmGruplar()
        {
            InitializeComponent();
        }
        dbIslemleri db = new dbIslemleri();
        ErrorProvider ep = new ErrorProvider();
        private void FrmGruplar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GRUP ORDER BY GRUP_AD ASC", db.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void txtdoldur()
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtgrupid.Text = dr["GRUP_ID"].ToString();
            txtgrupadi.Text = dr["GRUP_AD"].ToString();
        }
        void temizle()
        {
            txtgrupid.Text = "";
            txtgrupadi.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtdoldur();
        }

        private void btnGrupEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtgrupadi.Text.Trim() == "") ep.SetError(txtgrupadi, "*"); else ep.SetError(txtgrupadi, "");
                if (txtgrupadi.Text.Trim() != "")
                {
                    SqlCommand komutekle = new SqlCommand("INSERT INTO TBL_GRUP(GRUP_AD) VALUES (@p1)", db.baglanti());
                    komutekle.Parameters.AddWithValue("@p1", txtgrupadi.Text);
                    komutekle.ExecuteNonQuery();
                    db.baglanti().Close();
                    MessageBox.Show("Grup sisteme eklendi.");
                    listele();
                    temizle();
                }
            }
            catch
            {
                MessageBox.Show("Kaydetme işlemi sırasında hata oluştu. Lütfen girdiğiniz bilgileri kontrol ediniz.");
            }
        }

        private void btnGrupSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_GRUP WHERE GRUP_ID=@p1", db.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtgrupid.Text);
                komutsil.ExecuteNonQuery();
                db.baglanti().Close();
                MessageBox.Show("Grup sistemden silindi.");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu.");

            }

        }

        private void btnGrupGuncele_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtgrupadi.Text.Trim() == "") ep.SetError(txtgrupadi, "*"); else ep.SetError(txtgrupadi, "");
                if (txtgrupadi.Text.Trim() != "")
                {
                    SqlCommand komutguncelle = new SqlCommand("update TBL_GRUP set GRUP_AD=@p1 where GRUP_ID=@p0", db.baglanti());
                    komutguncelle.Parameters.AddWithValue("@p0", txtgrupid.Text);
                    komutguncelle.Parameters.AddWithValue("@p1", txtgrupadi.Text);
                    komutguncelle.ExecuteNonQuery();
                    db.baglanti().Close();
                    MessageBox.Show("Grup bilgileri güncellendi.");
                    listele();
                    temizle();
                }
            }
            catch
            {
                MessageBox.Show("Güncelleme işlemi sırasında hata oluştu. Lütfen girdiğiniz bilgileri kontrol ediniz.");
            }
        }

        private void btnGrupTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtdoldur();
        }
        public int ID;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            ID = Convert.ToInt32(dr["GRUP_ID"].ToString());
            this.DialogResult = DialogResult.OK;
        
    }
    }
}
