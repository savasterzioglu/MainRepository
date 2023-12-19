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
        Puantaj_islemleri P_islemleri;
        public Personel_Sec()
        {
            InitializeComponent();

            var db = new DemircilerDB();
            gridControl2.DataSource = db.GetPersonel();
        }


        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            var _Pers = new Personel();
            _Pers.P_id =Convert.ToInt32(gridView2.GetFocusedRowCellValue("P_id"));
            _Pers.P_ad = gridView2.GetFocusedRowCellValue("P_ad").ToString();
            _Pers.P_soyad = gridView2.GetFocusedRowCellValue("P_soyad").ToString();
            _Pers.P_ucret = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("P_ucret").ToString());
            Puantaj_islemleri frm = this.Owner as Puantaj_islemleri;
            // Çalışan
            //frm.textad.Text = "sezer";
            frm.formac(_Pers);
            //this.Dispose();
            this.Close();
        }

        private void Ekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Personel_islemleri frm = new Personel_islemleri();
            frm.ShowDialog();

        }

        private void yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var db = new DemircilerDB();
            gridControl2.DataSource = db.GetPersonel();
        }
    }
}