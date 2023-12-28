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
        DemircilerDB db = new DemircilerDB();
        urun item = new urun();
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            item_doldur();    
           // var db = new DemircilerDB();
            var result = db.insert_urun(item);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            item_doldur();
            var result = db.delete_urun(item);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            item_doldur();
            var result = db.Update_urunByID(item);
        }

        void item_doldur()
        {
            item.id = 0;
            item.ukodu = Convert.ToInt32(textEdit1.Text);
            item.uresimno = textEdit4.Text;
            item.uadi = textEdit5.Text;
            item.tekfiyat = Convert.ToDecimal(textEdit3.Text);
            item.tektarih = new DateTime(2023, 01, 01);
            item.mkodu = Convert.ToInt32(textEdit2.Text);
            item.uaciklama = "";
        }
    }
}
