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
    public partial class Sabit_Param : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();
        public Sabit_Parametreler item = new Sabit_Parametreler();


        public Sabit_Param()
        {
            InitializeComponent();
        }

        private void Sabit_Param_Load(object sender, EventArgs e)
        {
            griddoldur();
            temizle(); 
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            item.Parametre_adi = textEdit1.Text;
            item.Parametre_fiyat = Convert.ToDecimal(textEdit2.Text);

            if (item.Parametre_adi != "" && item.Parametre_fiyat > 0)
            {
                if (item.id != 0)
                {
                    var result = db.insert_Sabit_Parametreler(item);
                }
                else
                {
                    var result = db.Update_Sabit_ParametrelerByID(item);
                }
                temizle();
                griddoldur();
            }
            else { MessageBox.Show("Lütfen verileri eksiksiz girin."); }       
        }

        void temizle()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            item.id = 0;
            item.Parametre_adi = "";
            item.Parametre_fiyat = 0;
        }

        void griddoldur()
        {
            gridControl1.DataSource = "";
            gridControl1.DataSource = db.GetSabit_Parametreler();
            gridView1.BestFitColumns();

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            item.id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            item.Parametre_adi = gridView1.GetFocusedRowCellValue("Parametre_adi").ToString();
            item.Parametre_fiyat = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Parametre_fiyat"));
            textEdit1.Text = item.Parametre_adi;
            textEdit2.Text = item.Parametre_fiyat.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var result = db.delete_Sabit_Parametreler(item);
            temizle();
            griddoldur();
        }
    }
}