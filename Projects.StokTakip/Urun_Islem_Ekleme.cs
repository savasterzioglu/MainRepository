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
    public partial class Urun_Islem_Ekleme : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();

        public mamul item = new mamul();

        public Urun_Islem_Ekleme()
        {
            InitializeComponent();
            lookUpEdit1.Properties.DataSource = db.GetUretim_Islem();
            lookUpEdit1.Properties.BestFit();
            lookUpEdit1.Text = "";
            lookUpEdit1.Properties.DisplayMember = "islem";
            lookUpEdit1.Properties.ValueMember = "Kimlik";
            gridControl1.DataSource = db.GetMamul();
            gridView1.BestFitColumns();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(lookUpEdit1.Properties.ValueMember);
            disable();

            if (a == 1) {
                topadet.Enabled = true;
                topsure.Enabled = true;
                agirlik.Enabled = true;
                }
            if (a == 5) {
                kalinlik.Enabled = true;
                uzunluk.Enabled = true;
                hazirlik.Enabled = true;
                }

            if (a == 9) {
                capakalma.Enabled = true;
                }

            if (a == 10) {
                mastar.Enabled = true;
                }

            if (a != 1 && a != 5 && a != 9 && a != 10){
                ucret.Enabled = true;
                }

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit1.EditValue != null)
            {
                
                //gridControl1.DataSource = db.GetMamul().Where(a => a.ukod.Contains(textEdit1.Text));
            }
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //item.parcaadi = gridView1.GetFocusedRowCellValue("parcaadi").ToString();
            //item.ukod = gridView1.GetFocusedRowCellValue("ukod").ToString();
            //textEdit1.Text = item.ukod;
            //textEdit2.Text = item.parcaadi;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Urun_Sec frm = new Urun_Sec();
            frm.ShowDialog(this);
        }

        public void formac(mamul _urun)
        {
                textEdit1.Text = _urun.ukod.ToString();
                textEdit2.Text = _urun.parcaadi;
            //textad.EditValue = _Pers.P_ad;
            //textsoyad.Text = _Pers.P_soyad;
            //persid = _Pers.P_id;
            //maas = _Pers.P_ucret;
            //dtpicker1.Enabled = true;
        }

        public void disable()
        {
            topadet.Enabled = false;
            topsure.Enabled = false;
            hmkod.Enabled = false;
            ucret.Enabled = false;
            agirlik.Enabled = false;
            kalinlik.Enabled = false;
            uzunluk.Enabled = false;
            hazirlik.Enabled = false;
            capakalma.Enabled = false;
            mastar.Enabled = false;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           switch (lookUpEdit1.Properties.ValueMember)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;

            }
               

        }
    }
}