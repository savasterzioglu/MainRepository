using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Projects.DbConnection.Business.MSSQL;


namespace Projects.StokTakip
{
    public partial class Urun_Girisi : DevExpress.XtraEditors.XtraForm
    {
        public Urun_Girisi()
        {
            InitializeComponent();

            var db = new DemircilerDB();
            gridControl1.DataSource = db.GetUrun();
            //gridView1.OptionsView.ColumnAutoWidth = true;
            //gridView1.Columns["uadi"].OptionsColumn.FixedWidth = true;
            //gridControl1.
            // gridView1.OptionsCustomization.colum
            gridView1.BestFitColumns();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
