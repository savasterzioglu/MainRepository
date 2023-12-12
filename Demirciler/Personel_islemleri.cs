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
using Projects.DbConnection.Business;

namespace Demirciler
{
    public partial class Personel_islemleri : DevExpress.XtraEditors.XtraForm
    {
        public Personel_islemleri()
        {
            InitializeComponent();
            GridDoldur();
        }
        public DemircilerDB db = new DemircilerDB();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var item = new Personel
            {
                P_ad = textEdit1.Text,
                P_soyad = textEdit2.Text,
                P_ucret = Convert.ToInt32(textEdit3.Text),
                p_adres = textEdit4.Text,
                p_telefon = textEdit5.Text,           
            };

            var result = db.insert_Personel(item);
            GridDoldur();
        }

        void GridDoldur()
        {
            gridControl1.DataSource = db.GetPersonel().ToList();
            gridView1.Columns["id"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridView1.BestFitColumns();
            gridControl2.DataSource = db.Gettest3().ToList();
            gridView2.BestFitColumns();
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //DataRow row = gridView1.GetRow(gridView1.GetRowHandle());

            var item = new Personel
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")),
            };

            MessageBox.Show(gridView1.GetFocusedRowCellValue("id").ToString());
            //var item2 = new test3
            //{
             //  id=2,
                
            //};
           // MessageBox.Show(gridView1.GetFocusedRowCellValue("P_ad").ToString());
           var result = db.delete_Personel(item);
            GridDoldur();
            //var result2 = db.delete_test3(item2);
            //if (result.result == true)
                //{
              //  MessageBox.Show("silindi");
            //}
          //  else { MessageBox.Show("silinmedi"); }
            
            //if (result2.result == true)
            //{
             // MessageBox.Show("silindi");

//           }
  //         else { MessageBox.Show("silinmedi"); }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gridView2.GetFocusedRowCellValue("id").ToString());
            var item3 = new test3
            {
                id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("id")),
                ad = "osman",
                soyad = "zamazingo",
            };

          var result5 =   db.Update_test3(item3);


        }
    }
}