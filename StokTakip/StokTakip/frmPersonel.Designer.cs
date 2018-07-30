namespace StokTakip
{
    partial class frmPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.btnPersonelTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtpersonelid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnPersonelGuncele = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtpersonelsicilno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtpersonelsoyadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtpersoneladi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelsicilno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelsoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersoneladi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonelTemizle
            // 
            this.btnPersonelTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelTemizle.ImageOptions.Image")));
            this.btnPersonelTemizle.Location = new System.Drawing.Point(30, 310);
            this.btnPersonelTemizle.Name = "btnPersonelTemizle";
            this.btnPersonelTemizle.Size = new System.Drawing.Size(120, 54);
            this.btnPersonelTemizle.TabIndex = 22;
            this.btnPersonelTemizle.Text = "TEMİZLE";
            // 
            // txtpersonelid
            // 
            this.txtpersonelid.Enabled = false;
            this.txtpersonelid.Location = new System.Drawing.Point(173, 37);
            this.txtpersonelid.Name = "txtpersonelid";
            this.txtpersonelid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonelid.Properties.Appearance.Options.UseFont = true;
            this.txtpersonelid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpersonelid.Size = new System.Drawing.Size(203, 28);
            this.txtpersonelid.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(133, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 22);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "ID :";
            // 
            // btnPersonelGuncele
            // 
            this.btnPersonelGuncele.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncele.Appearance.Options.UseFont = true;
            this.btnPersonelGuncele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelGuncele.ImageOptions.Image")));
            this.btnPersonelGuncele.Location = new System.Drawing.Point(173, 310);
            this.btnPersonelGuncele.Name = "btnPersonelGuncele";
            this.btnPersonelGuncele.Size = new System.Drawing.Size(203, 54);
            this.btnPersonelGuncele.TabIndex = 19;
            this.btnPersonelGuncele.Text = "GÜNCELLE";
            this.btnPersonelGuncele.Click += new System.EventHandler(this.btnPersonelGuncele_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.Appearance.Options.UseFont = true;
            this.btnPersonelSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelSil.ImageOptions.Image")));
            this.btnPersonelSil.Location = new System.Drawing.Point(173, 250);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(203, 54);
            this.btnPersonelSil.TabIndex = 18;
            this.btnPersonelSil.Text = "SİL";
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.Appearance.Options.UseFont = true;
            this.btnPersonelEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelEkle.ImageOptions.Image")));
            this.btnPersonelEkle.Location = new System.Drawing.Point(173, 190);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(203, 54);
            this.btnPersonelEkle.TabIndex = 17;
            this.btnPersonelEkle.Text = "KAYDET";
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtpersonelsicilno);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtpersonelsoyadi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtpersoneladi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnPersonelTemizle);
            this.groupControl1.Controls.Add(this.txtpersonelid);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnPersonelGuncele);
            this.groupControl1.Controls.Add(this.btnPersonelSil);
            this.groupControl1.Controls.Add(this.btnPersonelEkle);
            this.groupControl1.Location = new System.Drawing.Point(1124, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(420, 612);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "PERSONEL BİLGİLERİ";
            // 
            // txtpersonelsicilno
            // 
            this.txtpersonelsicilno.Location = new System.Drawing.Point(173, 150);
            this.txtpersonelsicilno.Name = "txtpersonelsicilno";
            this.txtpersonelsicilno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonelsicilno.Properties.Appearance.Options.UseFont = true;
            this.txtpersonelsicilno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpersonelsicilno.Size = new System.Drawing.Size(203, 28);
            this.txtpersonelsicilno.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(80, 150);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 22);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "SİCİL NO :";
            // 
            // txtpersonelsoyadi
            // 
            this.txtpersonelsoyadi.Location = new System.Drawing.Point(173, 111);
            this.txtpersonelsoyadi.Name = "txtpersonelsoyadi";
            this.txtpersonelsoyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersonelsoyadi.Properties.Appearance.Options.UseFont = true;
            this.txtpersonelsoyadi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpersonelsoyadi.Size = new System.Drawing.Size(203, 28);
            this.txtpersonelsoyadi.TabIndex = 26;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(159, 22);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "PERSONEL SOYAD :";
            // 
            // txtpersoneladi
            // 
            this.txtpersoneladi.Location = new System.Drawing.Point(173, 74);
            this.txtpersoneladi.Name = "txtpersoneladi";
            this.txtpersoneladi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpersoneladi.Properties.Appearance.Options.UseFont = true;
            this.txtpersoneladi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpersoneladi.Size = new System.Drawing.Size(203, 28);
            this.txtpersoneladi.TabIndex = 24;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 22);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "PERSONEL AD :";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Arama yapınız...";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 11);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1106, 611);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 634);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelsicilno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersonelsoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpersoneladi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPersonelTemizle;
        private DevExpress.XtraEditors.TextEdit txtpersonelid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGuncele;
        private DevExpress.XtraEditors.SimpleButton btnPersonelSil;
        private DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtpersonelsicilno;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtpersonelsoyadi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtpersoneladi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}