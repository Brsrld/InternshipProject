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
    public partial class frmBirimler : Form
    {
        public frmBirimler()
        {
            InitializeComponent();
        }
        dbIslemleri db = new dbIslemleri();
        ErrorProvider ep = new ErrorProvider();
        private void frmBirimler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }
        void temizle()
        {
            txtbirimid.Text = "";
            txtbirimadi.Text = "";
        }

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_BIRIM ORDER BY BIRIM_AD ASC", db.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void txtyazdir()
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtbirimid.Text = dr["BIRIM_ID"].ToString();
            txtbirimadi.Text = dr["BIRIM_AD"].ToString();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtyazdir();
        }
        public int ID;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            ID = Convert.ToInt32(dr["BIRIM_ID"].ToString());
            this.DialogResult = DialogResult.OK;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            /* DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
             ID = Convert.ToInt32(dr["BIRIM_ID"].ToString());
             this.DialogResult = DialogResult.OK;*/
        }

        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbirimadi.Text.Trim() == "") ep.SetError(txtbirimadi, "*"); else ep.SetError(txtbirimadi, "");
                if (txtbirimadi.Text.Trim() != "")
                {
                    SqlCommand komutekle = new SqlCommand("INSERT INTO TBL_BIRIM(BIRIM_AD) VALUES (@p1)", db.baglanti());
                    komutekle.Parameters.AddWithValue("@p1", txtbirimadi.Text);
                    komutekle.ExecuteNonQuery();
                    db.baglanti().Close();
                    MessageBox.Show("Birim sisteme eklendi.");
                    listele();
                    temizle();
                }
            }
            catch
            {
                MessageBox.Show("Kaydetme işlemi sırasında hata oluştu. Lütfen girdiğiniz bilgileri kontrol ediniz.");
            }

        }

        private void btnBirimSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_BIRIM WHERE BIRIM_ID=@p1", db.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtbirimid.Text);
                komutsil.ExecuteNonQuery();
                db.baglanti().Close();
                MessageBox.Show("Birim sistemden silindi.");
                listele();
                temizle();
            }
            catch
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu.");

            }

        }

        private void btnBirimGuncele_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbirimadi.Text.Trim() == "") ep.SetError(txtbirimadi, "*"); else ep.SetError(txtbirimadi, "");
                if (txtbirimadi.Text.Trim() != "")
                {
                    SqlCommand komutguncelle = new SqlCommand("update TBL_BIRIM set BIRIM_AD=@p1 where BIRIM_ID=@p0", db.baglanti());
                    komutguncelle.Parameters.AddWithValue("@p0", txtbirimid.Text);
                    komutguncelle.Parameters.AddWithValue("@p1", txtbirimadi.Text);
                    komutguncelle.ExecuteNonQuery();
                    db.baglanti().Close();
                    MessageBox.Show("Birim bilgileri güncellendi.");
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
            txtyazdir();
        }
    }
    }
