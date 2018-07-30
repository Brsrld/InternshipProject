namespace StokTakip
{
    partial class FrmGruplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGruplar));
            this.btnGrupTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtgrupid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnGrupGuncele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGrupSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGrupEkle = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtgrupadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrupid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrupadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrupTemizle
            // 
            this.btnGrupTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupTemizle.ImageOptions.Image")));
            this.btnGrupTemizle.Location = new System.Drawing.Point(0, 222);
            this.btnGrupTemizle.Name = "btnGrupTemizle";
            this.btnGrupTemizle.Size = new System.Drawing.Size(120, 54);
            this.btnGrupTemizle.TabIndex = 22;
            this.btnGrupTemizle.Text = "TEMİZLE";
            this.btnGrupTemizle.Click += new System.EventHandler(this.btnGrupTemizle_Click);
            // 
            // txtgrupid
            // 
            this.txtgrupid.Enabled = false;
            this.txtgrupid.Location = new System.Drawing.Point(126, 41);
            this.txtgrupid.Name = "txtgrupid";
            this.txtgrupid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgrupid.Properties.Appearance.Options.UseFont = true;
            this.txtgrupid.Size = new System.Drawing.Size(210, 26);
            this.txtgrupid.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(83, 39);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 22);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "ID :";
            // 
            // btnGrupGuncele
            // 
            this.btnGrupGuncele.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrupGuncele.Appearance.Options.UseFont = true;
            this.btnGrupGuncele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupGuncele.ImageOptions.Image")));
            this.btnGrupGuncele.Location = new System.Drawing.Point(126, 222);
            this.btnGrupGuncele.Name = "btnGrupGuncele";
            this.btnGrupGuncele.Size = new System.Drawing.Size(210, 54);
            this.btnGrupGuncele.TabIndex = 19;
            this.btnGrupGuncele.Text = "GÜNCELLE";
            this.btnGrupGuncele.Click += new System.EventHandler(this.btnGrupGuncele_Click);
            // 
            // btnGrupSil
            // 
            this.btnGrupSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrupSil.Appearance.Options.UseFont = true;
            this.btnGrupSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupSil.ImageOptions.Image")));
            this.btnGrupSil.Location = new System.Drawing.Point(126, 162);
            this.btnGrupSil.Name = "btnGrupSil";
            this.btnGrupSil.Size = new System.Drawing.Size(210, 54);
            this.btnGrupSil.TabIndex = 18;
            this.btnGrupSil.Text = "SİL";
            this.btnGrupSil.Click += new System.EventHandler(this.btnGrupSil_Click);
            // 
            // btnGrupEkle
            // 
            this.btnGrupEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrupEkle.Appearance.Options.UseFont = true;
            this.btnGrupEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupEkle.ImageOptions.Image")));
            this.btnGrupEkle.Location = new System.Drawing.Point(126, 102);
            this.btnGrupEkle.Name = "btnGrupEkle";
            this.btnGrupEkle.Size = new System.Drawing.Size(210, 54);
            this.btnGrupEkle.TabIndex = 17;
            this.btnGrupEkle.Text = "KAYDET";
            this.btnGrupEkle.Click += new System.EventHandler(this.btnGrupEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtgrupadi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnGrupTemizle);
            this.groupControl1.Controls.Add(this.txtgrupid);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnGrupGuncele);
            this.groupControl1.Controls.Add(this.btnGrupSil);
            this.groupControl1.Controls.Add(this.btnGrupEkle);
            this.groupControl1.Location = new System.Drawing.Point(1124, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(366, 612);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "GRUP BİLGİLERİ";
            // 
            // txtgrupadi
            // 
            this.txtgrupadi.Location = new System.Drawing.Point(126, 69);
            this.txtgrupadi.Name = "txtgrupadi";
            this.txtgrupadi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgrupadi.Properties.Appearance.Options.UseFont = true;
            this.txtgrupadi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrupadi.Size = new System.Drawing.Size(210, 26);
            this.txtgrupadi.TabIndex = 24;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 22);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "BİRİM ADI :";
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
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmGruplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 634);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmGruplar";
            this.Text = "GRUPLAR";
            this.Load += new System.EventHandler(this.FrmGruplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtgrupid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrupadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnGrupTemizle;
        private DevExpress.XtraEditors.TextEdit txtgrupid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnGrupGuncele;
        private DevExpress.XtraEditors.SimpleButton btnGrupSil;
        private DevExpress.XtraEditors.SimpleButton btnGrupEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtgrupadi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}