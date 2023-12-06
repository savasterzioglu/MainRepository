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
                p_telefon = Convert.ToInt32(textEdit5.Text),           
            };

            var result = db.insert_Personel(item);
            GridDoldur();
        }

        void GridDoldur()
        {
            gridControl1.DataSource = db.GetPersonel().ToList();
            gridView1.BestFitColumns();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //DataRow row = gridView1.GetRow(gridView1.GetRowHandle());

            var item = new Personel
            {
                P_ad = "vstd1",
                P_soyad = "vstd3",
                P_ucret = 20000,                
                p_adres = "vstd2",
                p_telefon = 555555,
                Kimlik = 2,
                p_dtarihi = "" ,
                P_id = 11,
            };
           // MessageBox.Show(gridView1.GetFocusedRowCellValue("P_ad").ToString());
           var result = db.delete_Personel(item);

            if (result.result == true)
                {
                MessageBox.Show("silindi");
            }
            else { MessageBox.Show("silinmedi"); }
        }
    }
}