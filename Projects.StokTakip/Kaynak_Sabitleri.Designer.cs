namespace Projects.StokTakip
{
    partial class Kaynak_Sabitleri
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.kaynaktipi = new DevExpress.XtraEditors.TextEdit();
            this.kalinlik = new DevExpress.XtraEditors.TextEdit();
            this.kaynakparametresi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.surulecektelmiktari = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hacim = new DevExpress.XtraEditors.TextEdit();
            this.kaynakagirlik = new DevExpress.XtraEditors.TextEdit();
            this.kaynaktelcap = new DevExpress.XtraEditors.TextEdit();
            this.harcanacakteluzunluk = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kaynaktipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalinlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakparametresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surulecektelmiktari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakagirlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynaktelcap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcanacakteluzunluk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // kaynaktipi
            // 
            this.kaynaktipi.Location = new System.Drawing.Point(145, 26);
            this.kaynaktipi.Name = "kaynaktipi";
            this.kaynaktipi.Size = new System.Drawing.Size(64, 20);
            this.kaynaktipi.TabIndex = 0;
            // 
            // kalinlik
            // 
            this.kalinlik.EditValue = 0D;
            this.kalinlik.Location = new System.Drawing.Point(145, 52);
            this.kalinlik.Name = "kalinlik";
            this.kalinlik.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.kalinlik.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.kalinlik.Properties.MaskSettings.Set("mask", "f");
            this.kalinlik.Properties.MaskSettings.Set("valueType", typeof(double));
            this.kalinlik.Properties.UseMaskAsDisplayFormat = true;
            this.kalinlik.Size = new System.Drawing.Size(64, 20);
            this.kalinlik.TabIndex = 1;
            // 
            // kaynakparametresi
            // 
            this.kaynakparametresi.EditValue = 0;
            this.kaynakparametresi.Location = new System.Drawing.Point(145, 78);
            this.kaynakparametresi.Name = "kaynakparametresi";
            this.kaynakparametresi.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.kaynakparametresi.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.kaynakparametresi.Properties.MaskSettings.Set("mask", "d");
            this.kaynakparametresi.Size = new System.Drawing.Size(64, 20);
            this.kaynakparametresi.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Kaynak Tipi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Kalınlık";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Kaynak Parametre";
            // 
            // surulecektelmiktari
            // 
            this.surulecektelmiktari.EditValue = 0;
            this.surulecektelmiktari.Location = new System.Drawing.Point(145, 104);
            this.surulecektelmiktari.Name = "surulecektelmiktari";
            this.surulecektelmiktari.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.surulecektelmiktari.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.surulecektelmiktari.Properties.MaskSettings.Set("mask", "d");
            this.surulecektelmiktari.Size = new System.Drawing.Size(64, 20);
            this.surulecektelmiktari.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Sürülecek Tel Miktarı m/dk";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 130);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(425, 194);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.PredefinedName = "Green Fill";
            formatConditionRuleValue1.Value1 = "h.sonu";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // hacim
            // 
            this.hacim.EditValue = 0D;
            this.hacim.Location = new System.Drawing.Point(374, 26);
            this.hacim.Name = "hacim";
            this.hacim.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.hacim.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.hacim.Properties.MaskSettings.Set("mask", "f");
            this.hacim.Properties.MaskSettings.Set("valueType", typeof(double));
            this.hacim.Properties.UseMaskAsDisplayFormat = true;
            this.hacim.Size = new System.Drawing.Size(64, 20);
            this.hacim.TabIndex = 17;
            this.hacim.EditValueChanged += new System.EventHandler(this.hacim_EditValueChanged);
            // 
            // kaynakagirlik
            // 
            this.kaynakagirlik.EditValue = 0D;
            this.kaynakagirlik.Location = new System.Drawing.Point(374, 52);
            this.kaynakagirlik.Name = "kaynakagirlik";
            this.kaynakagirlik.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.kaynakagirlik.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.kaynakagirlik.Properties.MaskSettings.Set("mask", "f6");
            this.kaynakagirlik.Properties.MaskSettings.Set("culture", "tr");
            this.kaynakagirlik.Properties.UseMaskAsDisplayFormat = true;
            this.kaynakagirlik.Size = new System.Drawing.Size(64, 20);
            this.kaynakagirlik.TabIndex = 18;
            // 
            // kaynaktelcap
            // 
            this.kaynaktelcap.EditValue = 0D;
            this.kaynaktelcap.Location = new System.Drawing.Point(374, 78);
            this.kaynaktelcap.Name = "kaynaktelcap";
            this.kaynaktelcap.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.kaynaktelcap.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.kaynaktelcap.Properties.MaskSettings.Set("mask", "f");
            this.kaynaktelcap.Properties.MaskSettings.Set("valueType", typeof(double));
            this.kaynaktelcap.Properties.UseMaskAsDisplayFormat = true;
            this.kaynaktelcap.Size = new System.Drawing.Size(64, 20);
            this.kaynaktelcap.TabIndex = 19;
            this.kaynaktelcap.EditValueChanged += new System.EventHandler(this.kaynaktelcap_EditValueChanged);
            // 
            // harcanacakteluzunluk
            // 
            this.harcanacakteluzunluk.EditValue = 0D;
            this.harcanacakteluzunluk.Location = new System.Drawing.Point(374, 104);
            this.harcanacakteluzunluk.Name = "harcanacakteluzunluk";
            this.harcanacakteluzunluk.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.harcanacakteluzunluk.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.harcanacakteluzunluk.Properties.MaskSettings.Set("mask", "f7");
            this.harcanacakteluzunluk.Properties.UseMaskAsDisplayFormat = true;
            this.harcanacakteluzunluk.Size = new System.Drawing.Size(64, 20);
            this.harcanacakteluzunluk.TabIndex = 20;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(215, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Hacim cm3";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(215, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 13);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Kaynak Ağırlığı";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(215, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 13);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "Kaynak Tel Çapı";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(215, 107);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(139, 13);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Harcanacak Tel Uzunluğu (m)";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Kaydet";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(449, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 336);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(449, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 316);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(449, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 316);
            // 
            // Kaynak_Sabitleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 336);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.harcanacakteluzunluk);
            this.Controls.Add(this.kaynaktelcap);
            this.Controls.Add(this.kaynakagirlik);
            this.Controls.Add(this.hacim);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.surulecektelmiktari);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.kaynakparametresi);
            this.Controls.Add(this.kalinlik);
            this.Controls.Add(this.kaynaktipi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Kaynak_Sabitleri";
            this.Text = "Kaynak Sabitleri";
            ((System.ComponentModel.ISupportInitialize)(this.kaynaktipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalinlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakparametresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surulecektelmiktari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakagirlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynaktelcap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harcanacakteluzunluk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit kaynaktipi;
        private DevExpress.XtraEditors.TextEdit kalinlik;
        private DevExpress.XtraEditors.TextEdit kaynakparametresi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit surulecektelmiktari;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit hacim;
        private DevExpress.XtraEditors.TextEdit kaynakagirlik;
        private DevExpress.XtraEditors.TextEdit kaynaktelcap;
        private DevExpress.XtraEditors.TextEdit harcanacakteluzunluk;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}