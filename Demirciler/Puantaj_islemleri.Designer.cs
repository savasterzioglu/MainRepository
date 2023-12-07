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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dtpicker = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.isgunu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisilangun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker.Properties)).BeginInit();
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
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(94, 140);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // dtpicker
            // 
            this.dtpicker.EditValue = null;
            this.dtpicker.Location = new System.Drawing.Point(186, 12);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpicker.Properties.MaskSettings.Set("mask", "d");
            this.dtpicker.Properties.UseMaskAsDisplayFormat = true;
            this.dtpicker.Size = new System.Drawing.Size(100, 20);
            this.dtpicker.TabIndex = 3;
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
            // Puantaj_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.calisilangun);
            this.Controls.Add(this.isgunu);
            this.Name = "Puantaj_islemleri";
            this.Text = "Puantaj_islemleri";
            ((System.ComponentModel.ISupportInitialize)(this.isgunu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisilangun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit isgunu;
        private DevExpress.XtraEditors.TextEdit calisilangun;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtpicker;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}