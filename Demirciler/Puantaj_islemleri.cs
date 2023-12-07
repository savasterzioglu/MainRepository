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
using System.Globalization;
using Projects.DbConnection.Business.MSSQL;


namespace Demirciler
{
    public partial class Puantaj_islemleri : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();
        public Puantaj_islemleri()
        {
            InitializeComponent();


            //gunleridoldur(DateTime.Now);

            gridControl2.DataSource = db.GetPersonel().ToList();
            gridView2.BestFitColumns();
        }

        void gunleridoldur(DateTime dt)
        {
            int is_gunu=0, h_sonu = 0;
            is_gunu =  DateTime.DaysInMonth(dt.Year, dt.Month);
            isgunu.EditValue = is_gunu;

            for (int i = 1; i <= is_gunu; i++)
            {
                if (new DateTime(dt.Year, dt.Month, i).DayOfWeek.ToString() == "Sunday" || new DateTime(dt.Year, dt.Month, i).DayOfWeek.ToString() == "Saturday")
                {
                    h_sonu++;
                }
            }
            calisilangun.Text = h_sonu.ToString();
            //dtpicker1.EditValue = DateTime.Now;

        }

        void GridDoldur(int p_id)
        {
            gridControl1.DataSource = db.GetPuantaj().ToList().Where(a => a.p_id == 1);
            gridView1.BestFitColumns();

        }


        private void dtpicker1_DateTimeChanged(object sender, EventArgs e)
        {
            gunleridoldur(Convert.ToDateTime(dtpicker1.EditValue));
        }


        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(gridView2.GetFocusedRowCellValue("P_ad").ToString());
            textad.Text = gridView2.GetFocusedRowCellValue("P_ad").ToString();
            textsoyad.Text = gridView2.GetFocusedRowCellValue("P_soyad").ToString();
            // MessageBox.Show("asas");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form frm = new Personel_islemleri();
            frm.Show();
        }

        private void dtpicker2_DateTimeChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.GetPuantaj().ToList();
            gridView1.BestFitColumns();
        }
    }
}