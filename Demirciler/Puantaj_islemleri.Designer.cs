namespace Demirciler
{
    partial class Puantaj_islemleri
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
            this.isgunu = new DevExpress.XtraEditors.TextEdit();
            this.calisilangun = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtpicker1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.textad = new DevExpress.XtraEditors.TextEdit();
            this.textsoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dtpicker2 = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.isgunu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisilangun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker2.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // isgunu
            // 
            this.isgunu.Location = new System.Drawing.Point(48, 38);
            this.isgunu.Name = "isgunu";
            this.isgunu.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.isgunu.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.isgunu.Properties.MaskSettings.Set("mask", "d");
            this.isgunu.Size = new System.Drawing.Size(44, 20);
            this.isgunu.TabIndex = 0;
            // 
            // calisilangun
            // 
            this.calisilangun.Location = new System.Drawing.Point(242, 38);
            this.calisilangun.Name = "calisilangun";
            this.calisilangun.Size = new System.Drawing.Size(44, 20);
            this.calisilangun.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(2, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "İş Günü";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(158, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Çalışılan İş Günü";
            // 
            // dtpicker1
            // 
            this.dtpicker1.EditValue = null;
            this.dtpicker1.Location = new System.Drawing.Point(201, 12);
            this.dtpicker1.Name = "dtpicker1";
            this.dtpicker1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpicker1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpicker1.Properties.MaskSettings.Set("mask", "d");
            this.dtpicker1.Size = new System.Drawing.Size(85, 20);
            this.dtpicker1.TabIndex = 6;
            this.dtpicker1.DateTimeChanged += new System.EventHandler(this.dtpicker1_DateTimeChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(158, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Tarih";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(-10, 64);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(296, 23);
            this.separatorControl1.TabIndex = 8;
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(48, 93);
            this.textad.Name = "textad";
            this.textad.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textad.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textad.Properties.MaskSettings.Set("mask", "d");
            this.textad.Size = new System.Drawing.Size(67, 20);
            this.textad.TabIndex = 9;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(185, 93);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textsoyad.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textsoyad.Properties.MaskSettings.Set("mask", "d");
            this.textsoyad.Size = new System.Drawing.Size(71, 20);
            this.textsoyad.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(2, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(15, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Adi";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(142, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Soyadi";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 269);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(690, 270);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(262, 93);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(24, 20);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "+";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(2, 119);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(284, 144);
            this.gridControl2.TabIndex = 15;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(372, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.textEdit1.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textEdit1.Properties.MaskSettings.Set("mask", "t");
            this.textEdit1.Properties.MaskSettings.Set("culture", "tr");
            this.textEdit1.Properties.MaskSettings.Set("spinWithCarry", true);
            this.textEdit1.Properties.MaskSettings.Set("useAdvancingCaret", true);
            this.textEdit1.Properties.UseMaskAsDisplayFormat = true;
            this.textEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit1.Size = new System.Drawing.Size(66, 20);
            this.textEdit1.TabIndex = 16;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(372, 38);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.DisplayFormat.FormatString = "00:00";
            this.textEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.textEdit2.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textEdit2.Properties.MaskSettings.Set("mask", "t");
            this.textEdit2.Properties.MaskSettings.Set("culture", "tr");
            this.textEdit2.Properties.MaskSettings.Set("useAdvancingCaret", true);
            this.textEdit2.Properties.MaskSettings.Set("spinWithCarry", true);
            this.textEdit2.Properties.UseMaskAsDisplayFormat = true;
            this.textEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit2.Size = new System.Drawing.Size(66, 20);
            this.textEdit2.TabIndex = 17;
            this.textEdit2.TextChanged += new System.EventHandler(this.textEdit2_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(292, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Giriş Saati";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(291, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Çıkış Saati";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(292, 67);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Devamsızlık";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(372, 64);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.DropDownRows = 3;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Raporlu",
            "İzinli",
            "Devamsız"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(66, 20);
            this.comboBoxEdit1.TabIndex = 21;
            // 
            // textEdit3
            // 
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(509, 38);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Properties.UseMaskAsDisplayFormat = true;
            this.textEdit3.Size = new System.Drawing.Size(66, 20);
            this.textEdit3.TabIndex = 22;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(444, 41);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Mesai Süresi";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(447, 15);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(24, 13);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Tarih";
            // 
            // dtpicker2
            // 
            this.dtpicker2.EditValue = null;
            this.dtpicker2.Location = new System.Drawing.Point(490, 12);
            this.dtpicker2.Name = "dtpicker2";
            this.dtpicker2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpicker2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpicker2.Properties.MaskSettings.Set("mask", "d");
            this.dtpicker2.Size = new System.Drawing.Size(85, 20);
            this.dtpicker2.TabIndex = 24;
            this.dtpicker2.DateTimeChanged += new System.EventHandler(this.dtpicker2_DateTimeChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(292, 240);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 26;
            this.simpleButton2.Text = "Kaydet";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(373, 240);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 27;
            this.simpleButton3.Text = "Güncelle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(454, 240);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 28;
            this.simpleButton4.Text = "Sil";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Puantaj_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 551);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.dtpicker2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtpicker1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.calisilangun);
            this.Controls.Add(this.isgunu);
            this.Name = "Puantaj_islemleri";
            this.Text = "Puantaj_islemleri";
            ((System.ComponentModel.ISupportInitialize)(this.isgunu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisilangun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit isgunu;
        private DevExpress.XtraEditors.TextEdit calisilangun;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtpicker1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit textsoyad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textad;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit dtpicker2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}