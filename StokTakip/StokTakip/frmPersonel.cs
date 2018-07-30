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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        public int ID;
        dbIslemleri db = new dbIslemleri();
        ErrorProvider ep = new ErrorProvider();
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            ID = Convert.ToInt32(dr["PERSONEL_ID"].ToString());
            this.DialogResult = DialogResult.OK;
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_PERSONEL ORDER BY PERSONEL_AD ASC", db.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtpersonelid.Text = "";
            txtpersoneladi.Text = "";
            txtpersonelsoyadi.Text = "";
            txtpersonelsicilno.Text = "";
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtpersoneladi.Text.Trim() == "") ep.SetError(txtpersoneladi, "*"); else ep.SetError(txtpersoneladi, "");
                if (txtpersonelsoyadi.Text.Trim() == "") ep.SetError(txtpersonelsoyadi, "*"); else ep.SetError(txtpersonelsoyadi, "");
                if (txtpersonelsicilno.Text.Trim() == "") ep.SetError(txtpersonelsicilno, "*"); else ep.SetError(txtpersonelsicilno, "");
                if (txtpersoneladi.Text.Trim() != "" && txtpersonelsoyadi.Text.Trim() != "" && txtpersonelsicilno.Text.Trim() != "")
                {
                    
                        SqlCommand komut = new SqlCommand("insert into TBL_PERSONEL(PERSONEL_AD,PERSONEL_SOYAD,PERSONEL_SICILNO) values (@p1,@p2,@p3)", db.baglanti());
                        komut.Parameters.AddWithValue("@p1", txtpersoneladi.Text);
                        komut.Parameters.AddWithValue("@p2", txtpersonelsoyadi.Text);
                        komut.Parameters.AddWithValue("@p3", txtpersonelsicilno.Text);
                        komut.ExecuteNonQuery();
                        db.baglanti().Close();
                        MessageBox.Show("Personel sisteme eklendi.");
                        listele();
                        temizle();
                    }

                }
            catch
            {
                MessageBox.Show("Kaydetme işlemi sırasında hata oluştu. Lütfen girdiğiniz bilgileri kontrol ediniz.");
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_PERSONEL where PERSONEL_ID=@p1", db.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtpersonelid.Text);
                komutsil.ExecuteNonQuery();
                db.baglanti().Close();
                MessageBox.Show("Personel sistemden silindi.");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu.");
            }
        }

        private void btnPersonelGuncele_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpersoneladi.Text.Trim() == "") ep.SetError(txtpersoneladi, "*"); else ep.SetError(txtpersoneladi, "");
                if (txtpersonelsoyadi.Text.Trim() == "") ep.SetError(txtpersonelsoyadi, "*"); else ep.SetError(txtpersonelsoyadi, "");
                if (txtpersonelsicilno.Text.Trim() == "") ep.SetError(txtpersonelsicilno, "*"); else ep.SetError(txtpersonelsicilno, "");
                if (txtpersoneladi.Text.Trim() != "" && txtpersonelsoyadi.Text.Trim() != "" && txtpersonelsicilno.Text.Trim() != "")
                
                    {
                    SqlCommand komutupdate = new SqlCommand("update TBL_PERSONEL set PERSONEL_AD=@p1, PERSONEL_SOYAD=@p2, PERSONEL_SICILNO=@p3 where PERSONEL_ID=@p0", db.baglanti());
                    komutupdate.Parameters.AddWithValue("@p0", txtpersonelid.Text);
                    komutupdate.Parameters.AddWithValue("@p1", txtpersoneladi.Text);
                    komutupdate.Parameters.AddWithValue("@p2", txtpersonelsoyadi.Text);
                    komutupdate.Parameters.AddWithValue("@p3", txtpersonelsicilno.Text);
                    komutupdate.ExecuteNonQuery();
                    db.baglanti().Close();
                    MessageBox.Show("Personel bilgileri güncellendi.");
                    listele();
                    temizle();
                }
            }
            catch
            {
                MessageBox.Show("Güncelleme işlemi sırasında hata oluştu. Lütfen girdiğiniz bilgileri kontrol ediniz.");


            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            doldur();
            
        }
        void doldur()
        {
            DataRow DR = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtpersonelid.Text = DR["PERSONEL_ID"].ToString();
            txtpersoneladi.Text = DR["PERSONEL_AD"].ToString();
            txtpersonelsoyadi.Text = DR["PERSONEL_SOYAD"].ToString();
            txtpersonelsicilno.Text = DR["PERSONEL_SICILNO"].ToString();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            doldur();
        }
    }
}
