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
            disable();
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
            int a=0;
            if (lookUpEdit1.EditValue.ToString() != "")
            {
                //MessageBox.Show(lookUpEdit1.EditValue.ToString());
                a = Convert.ToInt32(lookUpEdit1.EditValue);
                disable();

                if (a == 1)
                {
                    topadet.Enabled = true;
                    topsure.Enabled = true;
                    agirlik.Enabled = true;
                }
                if (a == 5)
                {
                    kalinlik.Enabled = true;
                    uzunluk.Enabled = true;
                    hazirlik.Enabled = true;
                }

                if (a == 9)
                {
                    capakalma.Enabled = true;
                }

                if (a == 10)
                {
                    mastar.Enabled = true;
                }

                if (a != 1 && a != 5 && a != 9 && a != 10)
                {
                    ucret.Enabled = true;
                }
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
            Mamul_Sec frm = new Mamul_Sec();
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
            int a = 0;
            a = Convert.ToInt32(lookUpEdit1.EditValue);

            switch (a)
            {
                case 1:
                    var _islem1 = new lazer_islem();
                    _islem1.ukod =Convert.ToInt32(textEdit1.Text);
                    _islem1.toplamsure = topsure.Text;
                    _islem1.agirlik =Convert.ToInt32(agirlik.Text);
                    _islem1.toplamadet = Convert.ToInt32(topadet.Text);
                    _islem1.ucret =Convert.ToDecimal (ucret.Text);
                    var result1 = db.insert_Lazer_Islem(_islem1);
                    break;
                case 2:
                    var _islem2 = new bukum_islem();
                    _islem2.ukod = Convert.ToInt32(textEdit1.Text);
                    _islem2.ucret = Convert.ToDecimal(ucret.Text);
                    var result2 = db.insert_Bukum_Islem(_islem2);
                    break;
                case 3:
                    var _islem3 = new torna_islem();
                    _islem3.ukod = Convert.ToInt32(textEdit1.Text);
                    _islem3.ucret = Convert.ToDecimal(ucret.Text);
                    var result3 = db.insert_Torna_Islem(_islem3);
                    break;
                case 4:
                    var _islem4 = new dik_islem();
                    _islem4.ukod = Convert.ToInt32(textEdit1.Text);
                    _islem4.ucret = Convert.ToDecimal(ucret.Text);
                    var result4 = db.insert_Dik_Islem(_islem4);
                    break;
                case 5:
                    var _islem5 = new kaynak_islem();
                    _islem5.ukod = Convert.ToInt32(textEdit1.Text);
                    _islem5.kalinlik = Convert.ToInt32(kalinlik.Text);
                    _islem5.uzunluk = Convert.ToInt32(uzunluk.Text);
                    _islem5.hazirlik = hazirlik.Text;
                    _islem5.ucret = Convert.ToDecimal(ucret.Text);
                    var result5 = db.insert_Kaynak_Islem(_islem5);
                    break;
                case 6:
                    var _islem6 = new kaplama_islem();
                    _islem6.ukod = Convert.ToInt32(textEdit1.Text);
                    _islem6.ucret = Convert.ToDecimal(ucret.Text);
                    var result6 = db.insert_Kaplama_Islem(_islem6);
                    break;
                case 7:
                    var _islem7 = new isil_islem();
                    _islem7.ukod = Convert.ToInt32(textEdit1.Text);
                    _islem7.ucret = Convert.ToDecimal(ucret.Text);
                    var result7 = db.insert_Isil_Islem(_islem7);
                    break;
                case 8:
                    var _islem8 = new montaj_islem();
                    _islem8.ukod = Convert.ToInt32(textEdit1.Text);
                    _islem8.ucret = Convert.ToDecimal(ucret.Text);
                    var result8 = db.insert_Montaj_Islem(_islem8);
                    break;
                case 9:
                    var _islem9 = new taslama_islem();
                    _islem9.ukod = Convert.ToInt32(textEdit1.Text);
                    _islem9.ucret = Convert.ToDecimal(ucret.Text);
                    var result9 = db.insert_Taslama_Islem(_islem9);
                    break;
                case 10:
                    var _islem10 = new Pres_islem();
                    _islem10.ukod = Convert.ToInt32(textEdit1.Text);
                    _islem10.ucret = Convert.ToDecimal(ucret.Text);
                    var result10 = db.insert_Pres_Islem(_islem10);

                    break;
            }

            var _urunislem = new Urun_islem();
            _urunislem.ukod = Convert.ToInt32(textEdit1.Text);
            _urunislem.uresimno = "";
            _urunislem.islem = Convert.ToInt32(lookUpEdit1.EditValue.ToString();
            var result10 = db.insert_Pres_Islem(_urunislem);


        }

        void islem_degistirme()
        {
            int a = 0;
            a = Convert.ToInt32(lookUpEdit1.EditValue);
            switch (a)
            {
                case 1:
                    topadet.Enabled = true;
                    topsure.Enabled = true;
                    agirlik.Enabled = true;
                    break;
                case 5:
                    kalinlik.Enabled = true;
                    uzunluk.Enabled = true;
                    hazirlik.Enabled = true;
                    break;
                case 9:
                    capakalma.Enabled = true;
                    break;
            }


            if (a != 1 && a != 5 && a != 9 && a != 10)
            {
                ucret.Enabled = true;
            }
        }


    }
}