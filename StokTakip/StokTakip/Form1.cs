using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.MdiChildren.OfType<FrmDemirbaslar>().Any())
            {
                FrmDemirbaslar demirbas = new FrmDemirbaslar();
                demirbas.Owner = this;
                demirbas.MdiParent = this;
                demirbas.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.MdiChildren.OfType<frmBirimler>().Any())
            {
                frmBirimler birimler = new frmBirimler();
                birimler.Owner = this;
                birimler.MdiParent = this;
                birimler.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.MdiChildren.OfType<frmTeslimat>().Any())
            {
                frmTeslimat birimler = new frmTeslimat();
                birimler.Owner = this;
                birimler.MdiParent = this;
                birimler.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.MdiChildren.OfType<frmPersonel>().Any())
            {
                frmPersonel personel = new frmPersonel();
                personel.Owner = this;
                personel.MdiParent = this;
                personel.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.MdiChildren.OfType<FrmGruplar>().Any())
            {
                FrmGruplar gruplar = new FrmGruplar();
                gruplar.Owner = this;
                gruplar.MdiParent = this;
                gruplar.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.MdiChildren.OfType<FrmHareketler>().Any())
            {
                FrmHareketler hareketler = new FrmHareketler();
                hareketler.Owner = this;
                hareketler.MdiParent = this;
                hareketler.Show();
            }
        }
    }
}
