namespace StokTakip
{
    partial class FrmHareketler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHareketler));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnHareketAra = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnHareketTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtdemirbasid = new DevExpress.XtraEditors.ButtonEdit();
            this.txtdemirbasno = new DevExpress.XtraEditors.ButtonEdit();
            this.txtdemirbasad = new DevExpress.XtraEditors.ButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(67, 86);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 22);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "NO :";
            // 
            // btnHareketAra
            // 
            this.btnHareketAra.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHareketAra.Appearance.Options.UseFont = true;
            this.btnHareketAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHareketAra.ImageOptions.Image")));
            this.btnHareketAra.Location = new System.Drawing.Point(151, 208);
            this.btnHareketAra.Name = "btnHareketAra";
            this.btnHareketAra.Size = new System.Drawing.Size(210, 54);
            this.btnHareketAra.TabIndex = 17;
            this.btnHareketAra.Text = "ARA";
            this.btnHareketAra.Click += new System.EventHandler(this.btnHareketAra_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnHareketTemizle);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnHareketAra);
            this.groupControl1.Controls.Add(this.txtdemirbasid);
            this.groupControl1.Controls.Add(this.txtdemirbasno);
            this.groupControl1.Controls.Add(this.txtdemirbasad);
            this.groupControl1.Location = new System.Drawing.Point(1124, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(366, 612);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "DEMİRBAŞ BİLGİLERİ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 169);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 22);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "SON YERİ :";
            // 
            // btnHareketTemizle
            // 
            this.btnHareketTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHareketTemizle.ImageOptions.Image")));
            this.btnHareketTemizle.Location = new System.Drawing.Point(22, 208);
            this.btnHareketTemizle.Name = "btnHareketTemizle";
            this.btnHareketTemizle.Size = new System.Drawing.Size(120, 54);
            this.btnHareketTemizle.TabIndex = 27;
            this.btnHareketTemizle.Text = "TEMİZLE";
            this.btnHareketTemizle.Click += new System.EventHandler(this.btnHareketTemizle_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(73, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 22);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "ID :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(62, 127);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 22);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "ADI :";
            // 
            // txtdemirbasid
            // 
            this.txtdemirbasid.Location = new System.Drawing.Point(110, 43);
            this.txtdemirbasid.Name = "txtdemirbasid";
            this.txtdemirbasid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbasid.Properties.Appearance.Options.UseFont = true;
            this.txtdemirbasid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtdemirbasid.Properties.ReadOnly = true;
            this.txtdemirbasid.Size = new System.Drawing.Size(251, 26);
            this.txtdemirbasid.TabIndex = 26;
            this.txtdemirbasid.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.textEdit1_ButtonClick);
            // 
            // txtdemirbasno
            // 
            this.txtdemirbasno.Location = new System.Drawing.Point(110, 85);
            this.txtdemirbasno.Name = "txtdemirbasno";
            this.txtdemirbasno.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbasno.Properties.Appearance.Options.UseFont = true;
            this.txtdemirbasno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtdemirbasno.Properties.ReadOnly = true;
            this.txtdemirbasno.Size = new System.Drawing.Size(251, 26);
            this.txtdemirbasno.TabIndex = 21;
            this.txtdemirbasno.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtdemirbasno_ButtonClick);
            // 
            // txtdemirbasad
            // 
            this.txtdemirbasad.Location = new System.Drawing.Point(110, 126);
            this.txtdemirbasad.Name = "txtdemirbasad";
            this.txtdemirbasad.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbasad.Properties.Appearance.Options.UseFont = true;
            this.txtdemirbasad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtdemirbasad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdemirbasad.Properties.ReadOnly = true;
            this.txtdemirbasad.Size = new System.Drawing.Size(251, 26);
            this.txtdemirbasad.TabIndex = 24;
            this.txtdemirbasad.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtdemirbasad_ButtonClick);
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
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(110, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 22);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "labelControl4";
            // 
            // FrmHareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 634);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmHareketler";
            this.Text = "DEMİRBAŞ HAREKETLERİ";
            this.Load += new System.EventHandler(this.FrmHareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnHareketAra;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.ButtonEdit txtdemirbasid;
        private DevExpress.XtraEditors.ButtonEdit txtdemirbasno;
        private DevExpress.XtraEditors.ButtonEdit txtdemirbasad;
        private DevExpress.XtraEditors.SimpleButton btnHareketTemizle;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}