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
    public partial class Urun_Sec : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();

        public urun _urun = new urun();
        public Urun_Sec()
        {
            InitializeComponent();
            grid_doldur();
        }

        void grid_doldur()
        {
            gridControl1.DataSource = db.GetUrun();
            gridView1.BestFitColumns();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            
            //var _urun = new urun();
            _urun.id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")); 
            _urun.ukodu = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ukodu")); 
            _urun.uresimno = gridView1.GetFocusedRowCellValue("uresimno").ToString(); 
            _urun.uadi = gridView1.GetFocusedRowCellValue("uadi").ToString(); ;
            /*
            _Pers.P_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("P_id"));
            _Pers.P_ad = gridView2.GetFocusedRowCellValue("P_ad").ToString();
            _Pers.P_soyad = gridView2.GetFocusedRowCellValue("P_soyad").ToString();
            _Pers.P_ucret = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("P_ucret").ToString());
            */
            Urun_Agaci frm = this.Owner as Urun_Agaci;
            frm.formac(_urun);
            this.Close();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Urun_Girisi frm = new Urun_Girisi();
            frm.ShowDialog(this);
        }
    }
}