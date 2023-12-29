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
    public partial class Urun_Agaci : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();

        public urun_agaci_liste agacitem = new urun_agaci_liste();

        public urun_mamul item = new urun_mamul();
        public Urun_Agaci()
        {
            InitializeComponent();
        }

        void grid_doldur()
        {
            gridControl1.DataSource = agacitem;
            gridView1.BestFitColumns();
        }

        public void formac(urun _urun)
        {
            if (_urun.mkodu == 1)
            {
                textEdit1.Text = _urun.ukodu.ToString();
                textEdit2.Text = _urun.uresimno;
                textEdit3.Text = _urun.uadi;
            }else
            {
                textEdit4.Text = _urun.ukodu.ToString();
                textEdit5.Text = _urun.uresimno;
                textEdit6.Text = _urun.uadi;
            }

            //textad.EditValue = _Pers.P_ad;
            //textsoyad.Text = _Pers.P_soyad;
            //persid = _Pers.P_id;
            //maas = _Pers.P_ucret;
            //dtpicker1.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Urun_Sec frm = new Urun_Sec();
            frm._urun.mkodu = 1;
            frm.ShowDialog(this);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Urun_Sec frm = new Urun_Sec();
            frm._urun.mkodu = 0;
            frm.ShowDialog(this);
        }
    }
    public class urun_agaci_liste
    {
        public int mkod { get; set; }
        public string madi { get; set; }
        public int ukod { get; set; }
        public string uadi { get; set; }
        public int miktar { get; set; }
        public string birim { get; set; }
    }
}