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

    public partial class Mamul_Sec : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();

        public mamul _urun = new mamul();

        public Mamul_Sec()
        {
            InitializeComponent();
            grid_doldur();
        }
        void grid_doldur()
        {
            gridControl1.DataSource = db.GetMamul();
            gridView1.BestFitColumns();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //var _urun = new urun();
            _urun.id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            _urun.ukod = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ukod"));
            _urun.parcaadi = gridView1.GetFocusedRowCellValue("uresimno").ToString();

            var _urunislem = new Urun_islem();
            _urunislem.id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
            _urunislem.ukod = 0;
            _urunislem.uresimno = "";
         

            //_urun.parcaadi = gridView1.GetFocusedRowCellValue("parcaadi").ToString(); ;
            /*
            _Pers.P_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("P_id"));
            _Pers.P_ad = gridView2.GetFocusedRowCellValue("P_ad").ToString();
            _Pers.P_soyad = gridView2.GetFocusedRowCellValue("P_soyad").ToString();
            _Pers.P_ucret = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("P_ucret").ToString());
            */
            Urun_Islem_Ekleme frm = this.Owner as Urun_Islem_Ekleme;
            frm.formac(_urun);
            this.Close();
        }
    }
}