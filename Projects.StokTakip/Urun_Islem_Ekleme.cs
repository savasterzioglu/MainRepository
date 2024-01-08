using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Projects.DbConnection.Business.MSSQL;


namespace Projects.StokTakip
{
    public partial class Urun_Islem_Ekleme : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();

        public mamul item = new mamul();

        public Urun_Islem_Ekleme()
        {
            InitializeComponent();
            lookUpEdit1.Properties.DataSource = db.GetUretim_Islem();
            lookUpEdit1.Properties.BestFit();
            lookUpEdit1.Text = "";
            lookUpEdit1.Properties.DisplayMember = "islem";
            lookUpEdit1.Properties.ValueMember = "Kimlik";
            gridControl1.DataSource = db.GetMamul();
            gridView1.BestFitColumns();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
           

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.EditValue != null)
            {
                
                //gridControl1.DataSource = db.GetMamul().Where(a => a.ukod.Contains(textEdit1.Text));
            }
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            item.parcaadi = gridView1.GetFocusedRowCellValue("parcaadi").ToString();
            item.ukod = gridView1.GetFocusedRowCellValue("ukod").ToString();
            textEdit1.Text = item.ukod;
            textEdit2.Text = item.parcaadi;
        }
    }
}