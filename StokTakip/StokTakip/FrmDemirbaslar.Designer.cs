namespace StokTakip
{
    partial class FrmDemirbaslar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemirbaslar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtdemirbasno = new DevExpress.XtraEditors.TextEdit();
            this.btnDemirbasTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtdemirbasid = new DevExpress.XtraEditors.TextEdit();
            this.btnDemirbasGuncele = new DevExpress.XtraEditors.SimpleButton();
            this.btnDemirbasSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDemirbasEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtdemirbasaciklama = new System.Windows.Forms.RichTextBox();
            this.txtdemirbasmarka = new DevExpress.XtraEditors.TextEdit();
            this.txtdemirbasozellik = new DevExpress.XtraEditors.TextEdit();
            this.txtdemirbascinsi = new DevExpress.XtraEditors.TextEdit();
            this.txtdemirbasad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.te_grup = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasmarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasozellik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbascinsi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_grup.Properties)).BeginInit();
            this.SuspendLayout();
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
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.FindNullPrompt = "Arama yapınız...";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // txtdemirbasno
            // 
            this.txtdemirbasno.Location = new System.Drawing.Point(149, 73);
            this.txtdemirbasno.Name = "txtdemirbasno";
            this.txtdemirbasno.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbasno.Properties.Appearance.Options.UseFont = true;
            this.txtdemirbasno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdemirbasno.Size = new System.Drawing.Size(203, 26);
            this.txtdemirbasno.TabIndex = 24;
            // 
            // btnDemirbasTemizle
            // 
            this.btnDemirbasTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDemirbasTemizle.ImageOptions.Image")));
            this.btnDemirbasTemizle.Location = new System.Drawing.Point(23, 553);
            this.btnDemirbasTemizle.Name = "btnDemirbasTemizle";
            this.btnDemirbasTemizle.Size = new System.Drawing.Size(120, 54);
            this.btnDemirbasTemizle.TabIndex = 22;
            this.btnDemirbasTemizle.Text = "TEMİZLE";
            this.btnDemirbasTemizle.Click += new System.EventHandler(this.btnDemirbasTemizle_Click);
            // 
            // txtdemirbasid
            // 
            this.txtdemirbasid.Enabled = false;
            this.txtdemirbasid.Location = new System.Drawing.Point(149, 28);
            this.txtdemirbasid.Name = "txtdemirbasid";
            this.txtdemirbasid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbasid.Properties.Appearance.Options.UseFont = true;
            this.txtdemirbasid.Size = new System.Drawing.Size(203, 26);
            this.txtdemirbasid.TabIndex = 21;
            // 
            // btnDemirbasGuncele
            // 
            this.btnDemirbasGuncele.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbasGuncele.Appearance.Options.UseFont = true;
            this.btnDemirbasGuncele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDemirbasGuncele.ImageOptions.Image")));
            this.btnDemirbasGuncele.Location = new System.Drawing.Point(149, 553);
            this.btnDemirbasGuncele.Name = "btnDemirbasGuncele";
            this.btnDemirbasGuncele.Size = new System.Drawing.Size(203, 54);
            this.btnDemirbasGuncele.TabIndex = 19;
            this.btnDemirbasGuncele.Text = "GÜNCELLE";
            this.btnDemirbasGuncele.Click += new System.EventHandler(this.btnDemirbasGuncele_Click);
            // 
            // btnDemirbasSil
            // 
            this.btnDemirbasSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbasSil.Appearance.Options.UseFont = true;
            this.btnDemirbasSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDemirbasSil.ImageOptions.Image")));
            this.btnDemirbasSil.Location = new System.Drawing.Point(149, 493);
            this.btnDemirbasSil.Name = "btnDemirbasSil";
            this.btnDemirbasSil.Size = new System.Drawing.Size(203, 54);
            this.btnDemirbasSil.TabIndex = 18;
            this.btnDemirbasSil.Text = "SİL";
            this.btnDemirbasSil.Click += new System.EventHandler(this.btnDemirbasSil_Click);
            // 
            // btnDemirbasEkle
            // 
            this.btnDemirbasEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbasEkle.Appearance.Options.UseFont = true;
            this.btnDemirbasEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDemirbasEkle.ImageOptions.Image")));
            this.btnDemirbasEkle.Location = new System.Drawing.Point(149, 433);
            this.btnDemirbasEkle.Name = "btnDemirbasEkle";
            this.btnDemirbasEkle.Size = new System.Drawing.Size(203, 54);
            this.btnDemirbasEkle.TabIndex = 17;
            this.btnDemirbasEkle.Text = "KAYDET";
            this.btnDemirbasEkle.Click += new System.EventHandler(this.btnDemirbasEkle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtdemirbasaciklama);
            this.groupControl1.Controls.Add(this.txtdemirbasmarka);
            this.groupControl1.Controls.Add(this.txtdemirbasozellik);
            this.groupControl1.Controls.Add(this.txtdemirbascinsi);
            this.groupControl1.Controls.Add(this.txtdemirbasad);
            this.groupControl1.Controls.Add(this.txtdemirbasno);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnDemirbasTemizle);
            this.groupControl1.Controls.Add(this.txtdemirbasid);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnDemirbasGuncele);
            this.groupControl1.Controls.Add(this.btnDemirbasSil);
            this.groupControl1.Controls.Add(this.btnDemirbasEkle);
            this.groupControl1.Controls.Add(this.te_grup);
            this.groupControl1.Location = new System.Drawing.Point(1124, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(366, 612);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "TESLİMAT BİLGİLERİ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(86, 293);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(57, 22);
            this.labelControl8.TabIndex = 36;
            this.labelControl8.Text = "GRUP :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(45, 336);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(97, 22);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "AÇIKLAMA :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(56, 252);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 22);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "MARKASI :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(54, 206);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 22);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "ÖZELLİĞİ :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(84, 165);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 22);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "CİNSİ :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(101, 124);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 22);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "ADI :";
            // 
            // txtdemirbasaciklama
            // 
            this.txtdemirbasaciklama.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbasaciklama.Location = new System.Drawing.Point(149, 336);
            this.txtdemirbasaciklama.Name = "txtdemirbasaciklama";
            this.txtdemirbasaciklama.Size = new System.Drawing.Size(203, 91);
            this.txtdemirbasaciklama.TabIndex = 29;
            this.txtdemirbasaciklama.Text = "";
            // 
            // txtdemirbasmarka
            // 
            this.txtdemirbasmarka.Location = new System.Drawing.Point(149, 251);
            this.txtdemirbasmarka.Name = "txtdemirbasmarka";
            this.txtdemirbasmarka.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbasmarka.Properties.Appearance.Options.UseFont = true;
            this.txtdemirbasmarka.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdemirbasmarka.Size = new System.Drawing.Size(203, 26);
            this.txtdemirbasmarka.TabIndex = 28;
            // 
            // txtdemirbasozellik
            // 
            this.txtdemirbasozellik.Location = new System.Drawing.Point(149, 205);
            this.txtdemirbasozellik.Name = "txtdemirbasozellik";
            this.txtdemirbasozellik.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbasozellik.Properties.Appearance.Options.UseFont = true;
            this.txtdemirbasozellik.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdemirbasozellik.Size = new System.Drawing.Size(203, 26);
            this.txtdemirbasozellik.TabIndex = 27;
            // 
            // txtdemirbascinsi
            // 
            this.txtdemirbascinsi.Location = new System.Drawing.Point(149, 164);
            this.txtdemirbascinsi.Name = "txtdemirbascinsi";
            this.txtdemirbascinsi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbascinsi.Properties.Appearance.Options.UseFont = true;
            this.txtdemirbascinsi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdemirbascinsi.Size = new System.Drawing.Size(203, 26);
            this.txtdemirbascinsi.TabIndex = 26;
            // 
            // txtdemirbasad
            // 
            this.txtdemirbasad.Location = new System.Drawing.Point(149, 121);
            this.txtdemirbasad.Name = "txtdemirbasad";
            this.txtdemirbasad.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdemirbasad.Properties.Appearance.Options.UseFont = true;
            this.txtdemirbasad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdemirbasad.Size = new System.Drawing.Size(203, 26);
            this.txtdemirbasad.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(106, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 22);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "NO :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(112, 29);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 22);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "ID :";
            // 
            // te_grup
            // 
            this.te_grup.Location = new System.Drawing.Point(149, 292);
            this.te_grup.Name = "te_grup";
            this.te_grup.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.te_grup.Properties.Appearance.Options.UseFont = true;
            this.te_grup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.te_grup.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.te_grup.Size = new System.Drawing.Size(203, 26);
            this.te_grup.TabIndex = 35;
            this.te_grup.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.te_grup_ButtonClick);
            this.te_grup.EditValueChanged += new System.EventHandler(this.te_grup_EditValueChanged);
            // 
            // FrmDemirbaslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 634);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDemirbaslar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMİRBAŞLAR";
            this.Load += new System.EventHandler(this.FrmDemirbaslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasmarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasozellik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbascinsi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdemirbasad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_grup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtdemirbasno;
        private DevExpress.XtraEditors.SimpleButton btnDemirbasTemizle;
        private DevExpress.XtraEditors.TextEdit txtdemirbasid;
        private DevExpress.XtraEditors.SimpleButton btnDemirbasGuncele;
        private DevExpress.XtraEditors.SimpleButton btnDemirbasSil;
        private DevExpress.XtraEditors.SimpleButton btnDemirbasEkle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txtdemirbasaciklama;
        private DevExpress.XtraEditors.TextEdit txtdemirbasmarka;
        private DevExpress.XtraEditors.TextEdit txtdemirbasozellik;
        private DevExpress.XtraEditors.TextEdit txtdemirbascinsi;
        private DevExpress.XtraEditors.TextEdit txtdemirbasad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ButtonEdit te_grup;
    }
}