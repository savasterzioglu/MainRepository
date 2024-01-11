using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Projects.DbConnection.Business.MSSQL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

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
                P_id = Convert.ToInt32(textEdit6.Text),
                P_ad = textEdit1.Text,
                P_soyad = textEdit2.Text,
                P_ucret = Convert.ToInt32(textEdit3.Text),
                p_adres = textEdit4.Text,
                p_telefon = textEdit5.Text,
                p_dtarihi = dateEdit1.Text,           
            };
            if (db.GetPersonel().Where(a => a.P_id == item.P_id).Count() == 0)
            {
                var result = db.insert_Personel(item);
                GridDoldur();
            }
            else { MessageBox.Show( item.P_id.ToString() + " TC Kimlik Numarası Kullanılıyor. "); }
            
        }

        void GridDoldur()
        {
            gridControl1.DataSource = db.GetPersonel().ToList();
            gridView1.Columns["id"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridView1.BestFitColumns();
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            var item = new Personel
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")),
            };

            MessageBox.Show(gridView1.GetFocusedRowCellValue("id").ToString());
           var result = db.delete_Personel(item);
            GridDoldur();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gridView1.GetFocusedRowCellValue("id").ToString());

            var item = new Personel
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString()),
                P_ad = textEdit1.Text,
                P_soyad = textEdit2.Text,
                p_adres = textEdit4.Text,
                p_telefon = textEdit5.Text,
                P_ucret = Convert.ToDecimal(textEdit3.Text),
                P_id = Convert.ToInt32(textEdit6.Text),
                p_dtarihi = dateEdit1.Text,
            };
            var results = db.Update_Personel(item);
            if (results.result ==true)
            {
                MessageBox.Show("kaydedildi");

            }
            else
            {
                MessageBox.Show(results.message);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("P_ad").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("P_soyad").ToString();
            textEdit3.Text = gridView1.GetFocusedRowCellValue("P_ucret").ToString(); 
            textEdit4.Text = gridView1.GetFocusedRowCellValue("p_adres").ToString();
            textEdit5.Text = gridView1.GetFocusedRowCellValue("p_telefon").ToString();
            textEdit6.Text = gridView1.GetFocusedRowCellValue("P_id").ToString(); ;
            dateEdit1.Text = gridView1.GetFocusedRowCellValue("p_dtarihi").ToString();

            GridFormatRule GFR = new GridFormatRule();
            GFR.Column = gridView1.Columns["P_id"];
            gridView1.FormatRules["Format0"].Column = GFR.Column;
            // FormatConditionRuleValue FCR = new FormatConditionRuleValue();
            // FCR.PredefinedName = "Red Bold Text";
            // FCR.Condition = FormatCondition.Greater;
            // FCR.Value1 = 1;
            // GFR.Rule = FCR;
            //  GFR.ApplyToRow = false;
            // gridView1.FormatRules.Add(GFR);
        }
        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            int quantity = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "P_id"));

            if (quantity > 1)
            {
                e.Appearance.BackColor = Color.Red;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }

            //Override any other formatting  
            e.HighPriority = true;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateEdit1.EditValue.ToString());
            //textEdit7.Text = dateEdit1.DateTime.GetDateTimeFormats("dd/mm/yyyy").ToString();
        }
    }
}