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


namespace Demirciler
{
    public partial class Personel_Sec : DevExpress.XtraEditors.XtraForm
    {
        public Personel_Sec()
        {
            InitializeComponent();

            var db = new DemircilerDB();
            gridControl2.DataSource = db.GetPersonel();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            var _Pers = new Personel();
            _Pers.id =Convert.ToInt32(gridView2.GetFocusedRowCellValue("id"));
            _Pers.P_ad = gridView2.GetFocusedRowCellValue("P_ad").ToString();
            _Pers.P_soyad = gridView2.GetFocusedRowCellValue("P_soyad").ToString();

            Puantaj_islemleri frm = new Puantaj_islemleri(_Pers);
            frm.Show();
            //this.Hide();

        }
    }
}