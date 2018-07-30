namespace StokTakip
{
    partial class frmBirimler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBirimler));
            this.btnBirimTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtbirimid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnBirimGuncele = new DevExpress.XtraEditors.SimpleButton();
            this.btnBirimSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnBirimEkle = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtbirimadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtbirimid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbirimadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBirimTemizle
            // 
            this.btnBirimTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBirimTemizle.ImageOptions.Image")));
            this.btnBirimTemizle.Location = new System.Drawing.Point(0, 222);
            this.btnBirimTemizle.Name = "btnBirimTemizle";
            this.btnBirimTemizle.Size = new System.Drawing.Size(120, 54);
            this.btnBirimTemizle.TabIndex = 22;
            this.btnBirimTemizle.Text = "TEMİZLE";
            // 
            // txtbirimid
            // 
            this.txtbirimid.Enabled = false;
            this.txtbirimid.Location = new System.Drawing.Point(126, 41);
            this.txtbirimid.Name = "txtbirimid";
            this.txtbirimid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbirimid.Properties.Appearance.Options.UseFont = true;
            this.txtbirimid.Size = new System.Drawing.Size(210, 26);
            this.txtbirimid.TabIndex = 21;
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
            // btnBirimGuncele
            // 
            this.btnBirimGuncele.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimGuncele.Appearance.Options.UseFont = true;
            this.btnBirimGuncele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBirimGuncele.ImageOptions.Image")));
            this.btnBirimGuncele.Location = new System.Drawing.Point(126, 222);
            this.btnBirimGuncele.Name = "btnBirimGuncele";
            this.btnBirimGuncele.Size = new System.Drawing.Size(210, 54);
            this.btnBirimGuncele.TabIndex = 19;
            this.btnBirimGuncele.Text = "GÜNCELLE";
            this.btnBirimGuncele.Click += new System.EventHandler(this.btnBirimGuncele_Click);
            // 
            // btnBirimSil
            // 
            this.btnBirimSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimSil.Appearance.Options.UseFont = true;
            this.btnBirimSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBirimSil.ImageOptions.Image")));
            this.btnBirimSil.Location = new System.Drawing.Point(126, 162);
            this.btnBirimSil.Name = "btnBirimSil";
            this.btnBirimSil.Size = new System.Drawing.Size(210, 54);
            this.btnBirimSil.TabIndex = 18;
            this.btnBirimSil.Text = "SİL";
            this.btnBirimSil.Click += new System.EventHandler(this.btnBirimSil_Click);
            // 
            // btnBirimEkle
            // 
            this.btnBirimEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimEkle.Appearance.Options.UseFont = true;
            this.btnBirimEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBirimEkle.ImageOptions.Image")));
            this.btnBirimEkle.Location = new System.Drawing.Point(126, 102);
            this.btnBirimEkle.Name = "btnBirimEkle";
            this.btnBirimEkle.Size = new System.Drawing.Size(210, 54);
            this.btnBirimEkle.TabIndex = 17;
            this.btnBirimEkle.Text = "KAYDET";
            this.btnBirimEkle.Click += new System.EventHandler(this.btnBirimEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtbirimadi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnBirimTemizle);
            this.groupControl1.Controls.Add(this.txtbirimid);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnBirimGuncele);
            this.groupControl1.Controls.Add(this.btnBirimSil);
            this.groupControl1.Controls.Add(this.btnBirimEkle);
            this.groupControl1.Location = new System.Drawing.Point(1124, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(366, 612);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "BİRİM BİLGİLERİ";
            // 
            // txtbirimadi
            // 
            this.txtbirimadi.Location = new System.Drawing.Point(126, 69);
            this.txtbirimadi.Name = "txtbirimadi";
            this.txtbirimadi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbirimadi.Properties.Appearance.Options.UseFont = true;
            this.txtbirimadi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbirimadi.Size = new System.Drawing.Size(210, 26);
            this.txtbirimadi.TabIndex = 24;
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
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmBirimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 634);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmBirimler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BİRİMLER";
            this.Load += new System.EventHandler(this.frmBirimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtbirimid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbirimadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnBirimTemizle;
        private DevExpress.XtraEditors.TextEdit txtbirimid;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnBirimGuncele;
        private DevExpress.XtraEditors.SimpleButton btnBirimSil;
        private DevExpress.XtraEditors.SimpleButton btnBirimEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtbirimadi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}