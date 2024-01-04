namespace Projects.StokTakip
{
    partial class Urun_Agaci
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 115);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(496, 201);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(89, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(80, 20);
            this.textEdit1.TabIndex = 15;
            // 
            // textEdit2
            // 
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(239, 12);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(80, 20);
            this.textEdit2.TabIndex = 16;
            // 
            // textEdit3
            // 
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(390, 12);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(80, 20);
            this.textEdit3.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Ürün Kodu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(175, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Resim No";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(325, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Ürün Adı";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(0, 34);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(502, 23);
            this.separatorControl1.TabIndex = 21;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(476, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(32, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Seç";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(325, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Ürün Adı";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(175, 66);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Resim No";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 66);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Ürün Kodu";
            // 
            // textEdit4
            // 
            this.textEdit4.Enabled = false;
            this.textEdit4.Location = new System.Drawing.Point(89, 63);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(80, 20);
            this.textEdit4.TabIndex = 25;
            // 
            // textEdit5
            // 
            this.textEdit5.Enabled = false;
            this.textEdit5.Location = new System.Drawing.Point(239, 63);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(80, 20);
            this.textEdit5.TabIndex = 24;
            // 
            // textEdit6
            // 
            this.textEdit6.Enabled = false;
            this.textEdit6.Location = new System.Drawing.Point(390, 63);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(80, 20);
            this.textEdit6.TabIndex = 23;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(89, 89);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(80, 20);
            this.textEdit7.TabIndex = 29;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 92);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Miktar";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(175, 92);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 13);
            this.labelControl8.TabIndex = 32;
            this.labelControl8.Text = "Birim";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(476, 61);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(32, 23);
            this.simpleButton2.TabIndex = 33;
            this.simpleButton2.Text = "Seç";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(390, 92);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(59, 23);
            this.simpleButton3.TabIndex = 34;
            this.simpleButton3.Text = "Ekle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(446, 92);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(62, 23);
            this.simpleButton4.TabIndex = 35;
            this.simpleButton4.Text = "Sil";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(239, 89);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEdit1.TabIndex = 36;
            // 
            // Urun_Agaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 328);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Urun_Agaci";
            this.Text = "Urun_Agaci";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}