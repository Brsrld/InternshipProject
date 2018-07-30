namespace StokTakip
{
    partial class frmTeslimat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeslimat));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnTeslimatTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtteslimatid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnTeslimatGuncele = new DevExpress.XtraEditors.SimpleButton();
            this.btnTeslimatSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnTeslimatEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbltarih = new DevExpress.XtraEditors.LabelControl();
            this.bedemirbasadi = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.beYbirim = new DevExpress.XtraEditors.ButtonEdit();
            this.beEbirim = new DevExpress.XtraEditors.ButtonEdit();
            this.beteslimalan = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtteslimatid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedemirbasadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beYbirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beEbirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beteslimalan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnTeslimatTemizle
            // 
            this.btnTeslimatTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeslimatTemizle.ImageOptions.Image")));
            this.btnTeslimatTemizle.Location = new System.Drawing.Point(18, 387);
            this.btnTeslimatTemizle.Name = "btnTeslimatTemizle";
            this.btnTeslimatTemizle.Size = new System.Drawing.Size(120, 54);
            this.btnTeslimatTemizle.TabIndex = 22;
            this.btnTeslimatTemizle.Text = "TEMİZLE";
            this.btnTeslimatTemizle.Click += new System.EventHandler(this.btnTeslimatTemizle_Click);
            // 
            // txtteslimatid
            // 
            this.txtteslimatid.Enabled = false;
            this.txtteslimatid.Location = new System.Drawing.Point(158, 38);
            this.txtteslimatid.Name = "txtteslimatid";
            this.txtteslimatid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtteslimatid.Properties.Appearance.Options.UseFont = true;
            this.txtteslimatid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtteslimatid.Size = new System.Drawing.Size(203, 28);
            this.txtteslimatid.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(121, 36);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 22);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "ID :";
            // 
            // btnTeslimatGuncele
            // 
            this.btnTeslimatGuncele.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimatGuncele.Appearance.Options.UseFont = true;
            this.btnTeslimatGuncele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeslimatGuncele.ImageOptions.Image")));
            this.btnTeslimatGuncele.Location = new System.Drawing.Point(158, 387);
            this.btnTeslimatGuncele.Name = "btnTeslimatGuncele";
            this.btnTeslimatGuncele.Size = new System.Drawing.Size(203, 54);
            this.btnTeslimatGuncele.TabIndex = 19;
            this.btnTeslimatGuncele.Text = "GÜNCELLE";
            this.btnTeslimatGuncele.Click += new System.EventHandler(this.btnTeslimatGuncele_Click);
            // 
            // btnTeslimatSil
            // 
            this.btnTeslimatSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimatSil.Appearance.Options.UseFont = true;
            this.btnTeslimatSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeslimatSil.ImageOptions.Image")));
            this.btnTeslimatSil.Location = new System.Drawing.Point(158, 327);
            this.btnTeslimatSil.Name = "btnTeslimatSil";
            this.btnTeslimatSil.Size = new System.Drawing.Size(203, 54);
            this.btnTeslimatSil.TabIndex = 18;
            this.btnTeslimatSil.Text = "SİL";
            this.btnTeslimatSil.Click += new System.EventHandler(this.btnTeslimatSil_Click);
            // 
            // btnTeslimatEkle
            // 
            this.btnTeslimatEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimatEkle.Appearance.Options.UseFont = true;
            this.btnTeslimatEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeslimatEkle.ImageOptions.Image")));
            this.btnTeslimatEkle.Location = new System.Drawing.Point(158, 267);
            this.btnTeslimatEkle.Name = "btnTeslimatEkle";
            this.btnTeslimatEkle.Size = new System.Drawing.Size(203, 54);
            this.btnTeslimatEkle.TabIndex = 17;
            this.btnTeslimatEkle.Text = "KAYDET";
            this.btnTeslimatEkle.Click += new System.EventHandler(this.btnTeslimatEkle_Click);
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
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 11);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1106, 611);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(88, 233);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 22);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "TARİH :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 197);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(122, 22);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "TESLİM ALAN :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 155);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 22);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "YENİ BİRİM :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 22);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "ESKİ BİRİM :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbltarih);
            this.groupControl1.Controls.Add(this.bedemirbasadi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.beYbirim);
            this.groupControl1.Controls.Add(this.beEbirim);
            this.groupControl1.Controls.Add(this.btnTeslimatTemizle);
            this.groupControl1.Controls.Add(this.txtteslimatid);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnTeslimatGuncele);
            this.groupControl1.Controls.Add(this.btnTeslimatSil);
            this.groupControl1.Controls.Add(this.btnTeslimatEkle);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.beteslimalan);
            this.groupControl1.Location = new System.Drawing.Point(1124, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(383, 612);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "TESLİMAT BİLGİLERİ";
            // 
            // lbltarih
            // 
            this.lbltarih.Appearance.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltarih.Appearance.Options.UseFont = true;
            this.lbltarih.Location = new System.Drawing.Point(158, 233);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(83, 22);
            this.lbltarih.TabIndex = 27;
            this.lbltarih.Text = "labelControl6";
            this.lbltarih.UseMnemonic = false;
            // 
            // bedemirbasadi
            // 
            this.bedemirbasadi.Location = new System.Drawing.Point(158, 75);
            this.bedemirbasadi.Name = "bedemirbasadi";
            this.bedemirbasadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bedemirbasadi.Properties.Appearance.Options.UseFont = true;
            this.bedemirbasadi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bedemirbasadi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bedemirbasadi.Size = new System.Drawing.Size(203, 28);
            this.bedemirbasadi.TabIndex = 26;
            this.bedemirbasadi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bedemirbasadi_ButtonClick);
            this.bedemirbasadi.EditValueChanged += new System.EventHandler(this.bedemirbasadi_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 22);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "DEMİRBAŞ ADI :";
            // 
            // beYbirim
            // 
            this.beYbirim.Location = new System.Drawing.Point(158, 155);
            this.beYbirim.Name = "beYbirim";
            this.beYbirim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beYbirim.Properties.Appearance.Options.UseFont = true;
            this.beYbirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beYbirim.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.beYbirim.Size = new System.Drawing.Size(203, 28);
            this.beYbirim.TabIndex = 24;
            this.beYbirim.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beYbirim_ButtonClick);
            this.beYbirim.EditValueChanged += new System.EventHandler(this.beYbirim_EditValueChanged);
            // 
            // beEbirim
            // 
            this.beEbirim.Location = new System.Drawing.Point(158, 113);
            this.beEbirim.Name = "beEbirim";
            this.beEbirim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beEbirim.Properties.Appearance.Options.UseFont = true;
            this.beEbirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beEbirim.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.beEbirim.Size = new System.Drawing.Size(203, 28);
            this.beEbirim.TabIndex = 23;
            this.beEbirim.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beEbirim_ButtonClick);
            this.beEbirim.EditValueChanged += new System.EventHandler(this.beEbirim_EditValueChanged);
            // 
            // beteslimalan
            // 
            this.beteslimalan.Location = new System.Drawing.Point(158, 195);
            this.beteslimalan.Name = "beteslimalan";
            this.beteslimalan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beteslimalan.Properties.Appearance.Options.UseFont = true;
            this.beteslimalan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beteslimalan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.beteslimalan.Size = new System.Drawing.Size(203, 28);
            this.beteslimalan.TabIndex = 14;
            this.beteslimalan.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beteslimalan_ButtonClick);
            this.beteslimalan.EditValueChanged += new System.EventHandler(this.beteslimalan_EditValueChanged);
            // 
            // frmTeslimat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 634);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmTeslimat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESLİMAT";
            this.Load += new System.EventHandler(this.frmTeslimat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtteslimatid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedemirbasadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beYbirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beEbirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beteslimalan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.SimpleButton btnTeslimatTemizle;
        private DevExpress.XtraEditors.TextEdit txtteslimatid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnTeslimatGuncele;
        private DevExpress.XtraEditors.SimpleButton btnTeslimatSil;
        private DevExpress.XtraEditors.SimpleButton btnTeslimatEkle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit beteslimalan;
        private DevExpress.XtraEditors.ButtonEdit beYbirim;
        private DevExpress.XtraEditors.ButtonEdit beEbirim;
        private DevExpress.XtraEditors.ButtonEdit bedemirbasadi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbltarih;
    }
}