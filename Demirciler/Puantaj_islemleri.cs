﻿using System;
using System.Runtime;
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
using Nager.Holiday;
using DevExpress.XtraGrid;


namespace Demirciler
{
    public partial class Puantaj_islemleri : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();
        public decimal maas = 0;
        public int persid = 0; 
        public static string[] holidays =new string[32];

        public DialogResult dialogResult { get; private set; }

        //gridView1.Columns["tarih"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

        public Puantaj_islemleri()
        {
            InitializeComponent();

            ControlActive(0);
        }

        void gunleridoldur(DateTime dt)
        {
            int is_gunu=0, h_sonu = 0;
            is_gunu =  DateTime.DaysInMonth(dt.Year, dt.Month);
            isgunu.EditValue = is_gunu;

            for (int i = 1; i <= is_gunu; i++)
            {
                holidays[i] = new DateTime(dt.Year, dt.Month, i).DayOfWeek.ToString();
                if (holidays[i] == "Sunday" || holidays[i] == "Saturday")
                {
                    h_sonu++;
                }
            }
            calisilangun.Text = (is_gunu - h_sonu).ToString();

        }

        void GridDoldur(int p_id, DateTime dt1)
        {
            gridControl1.DataSource = db.GetPuantaj().Where(a => a.p_id == persid && Convert.ToDateTime(a.tarih) >= Convert.ToDateTime(dt1.ToShortDateString())         
             && Convert.ToDateTime(a.tarih) < Convert.ToDateTime(dt1.AddMonths(1).ToShortDateString()));
            GridFormatRule GFR = new GridFormatRule();
            GFR.Column = gridView1.Columns["devamsizlik"];
            gridView1.FormatRules["Format0"].Column = GFR.Column;
            gridView1.Columns["tarih"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridView1.BestFitColumns();

        }


        private void dtpicker1_DateTimeChanged(object sender, EventArgs e)
        {
            if (persid != 0)
            {
                gunleridoldur(Convert.ToDateTime(dtpicker1.EditValue));
                GridDoldur(persid, Convert.ToDateTime(dtpicker1.EditValue));
            }
            else
            {
                MessageBox.Show("Lütfen Personel Seçiniz.");
            }
            var firstdaymonth = new DateTime(dtpicker1.DateTime.Year, dtpicker1.DateTime.Month, 1);
            var lastdaymonth = firstdaymonth.AddDays(29);
            

            aylik.Text = db.GetPuantaj().ToList().Where(a => Convert.ToDateTime(a.tarih) >= firstdaymonth && Convert.ToDateTime(a.tarih) <= lastdaymonth).Sum(a=> a.ucret).ToString();
            decimal yuvarla = Math.Ceiling(Convert.ToDecimal(aylik.Text));
            //textEdit4.Text = Math.Round(decimal.Parse("99,9",0)).ToString();
        }


        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(gridView2.GetFocusedRowCellValue("P_ad").ToString());
    /*        textad.Text = gridView2.GetFocusedRowCellValue("P_ad").ToString();
            textsoyad.Text = gridView2.GetFocusedRowCellValue("P_soyad").ToString();
            maas = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("P_ucret"));
            int id=0;
            id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("P_id"));
            var dt1 = new DateTime(dtpicker1.DateTime.Year, dtpicker1.DateTime.Month, 1);
            gridControl1.DataSource = db.GetPuantaj().Where(a=> a.p_id == id &&  Convert.ToDateTime(a.tarih) >= Convert.ToDateTime(dt1.ToShortDateString())
                                                                  && Convert.ToDateTime(a.tarih) < Convert.ToDateTime(dt1.AddMonths(1).ToShortDateString()));
            ControlActive(1);
            GridFormatRule GFR = new GridFormatRule();
            GFR.Column = gridView1.Columns["devamsizlik"];
            gridView1.FormatRules["Format0"].Column = GFR.Column;
    */        

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Puantaj
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")),
                };
                if (item.id != 0)
                {
                    var result = db.delete_Puantaj(item);
                } else { MessageBox.Show("Listeden bir kayıt seçin"); }
                item.id = 0;
                //gridControl2.Refresh();
            }
            catch { MessageBox.Show("Listeden var olan bir kayıt seçin."); }
        }


        // Personel Seçimi
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Form frm = new Personel_islemleri();
           Personel_Sec frm = new Personel_Sec();
            frm.ShowDialog(this);
        }

        private void dtpicker2_DateTimeChanged(object sender, EventArgs e)
        {
            //gridControl1.DataSource = db.GetPuantaj().ToList();
           // gridView1.BestFitColumns();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try {
                TimeSpan ts2 = (Convert.ToDateTime(textEdit2.Text) - Convert.ToDateTime(textEdit1.Text)- (new TimeSpan(10,0,0)));
                TimeSpan ts1 = new TimeSpan(10,0,0);

                if (ts2.TotalHours >= 0)
                {
                    ts1 = new TimeSpan(10, 0, 0);
                
                }
                else
                {
                   ts1 = ts2.Add(new TimeSpan(10,0,0));
                   ts2 = new TimeSpan(0,0,0);
                }

                var item = new Puantaj
                {
                    p_id = persid,
                    giris_zaman = textEdit1.Text,
                    cikis_zaman = textEdit2.Text,
                    devamsizlik = comboBoxEdit1.Text,
                    c_sure = ts1.Add(ts2).ToString(),
                    mesai_sure = ts2.TotalHours,
                    ucret = UcretHesapla(Convert.ToDecimal(ts1.TotalHours),Convert.ToDecimal(ts2.TotalHours)) ,
                    tarih = dtpicker2.Text,
                };
                if (db.GetPuantaj().ToList().Where(a => a.tarih == item.tarih).Count() == 0)
                {
                    var result = db.insert_Puantaj(item);
                }
                else { MessageBox.Show("Aynı güne kayıt ekleyemezsiniz."); }
            }
            catch { MessageBox.Show("Lütfen verileri eksiksiz ve doğru girin, Personel tablosundan seçim yaptığınıza emin olun."); }

            
        }

        private void textEdit2_TextChanged(object sender, EventArgs e)
        {
            textEdit3.Text = mesai_Hesapla(textEdit2.Text,textEdit1.Text);
        }

        void ControlActive(int a)
        {
            if (a == 1)
                {
                simpleButton2.Enabled = true;
                simpleButton3.Enabled = true;
                simpleButton4.Enabled = true;
                dtpicker2.Enabled = true;
                comboBoxEdit1.Enabled = true;
                textEdit1.Enabled = true;
                textEdit2.Enabled = true;
                textEdit3.Enabled = true;

            } else
            {
                simpleButton2.Enabled = false;
                simpleButton3.Enabled = false;
                simpleButton4.Enabled = false;
                dtpicker2.Enabled = false;
                comboBoxEdit1.Enabled = false;
                textEdit1.Enabled = false;
                textEdit2.Enabled = false;
                textEdit3.Enabled = false;
                dtpicker1.Enabled = false;
            }


        }
        decimal UcretHesapla(decimal m1,decimal t)
        {
            //m1 günlük çalışılan normal süre
            //t günlük çalışılan mesai süresi
            decimal r1;
            r1 = (m1 + ((t*3)/2));
            r1 = r1 * (maas / 300);
            return r1;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            try
            {
                TimeSpan ts2 = (Convert.ToDateTime(textEdit2.Text) - Convert.ToDateTime(textEdit1.Text) - (new TimeSpan(10, 0, 0)));
                TimeSpan ts1 = new TimeSpan(10, 0, 0);

                if (ts2.TotalHours >= 0)
                {
                    ts1 = new TimeSpan(10, 0, 0);

                }
                else
                {
                    ts1 = ts2.Add(new TimeSpan(10, 0, 0));
                    ts2 = new TimeSpan(0, 0, 0);
                }

                var item = new Puantaj
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")),
                    giris_zaman = textEdit1.Text+":00",
                    cikis_zaman = textEdit2.Text+":00",
                    devamsizlik = comboBoxEdit1.Text,
                    c_sure = ts1.Add(ts2).ToString(),
                    mesai_sure = ts2.TotalHours,
                    ucret = UcretHesapla(Convert.ToDecimal(ts1.TotalHours), Convert.ToDecimal(ts2.TotalHours)),
                    p_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("p_id")),
                };
                if (item.id != 0)
                {
                    var result = db.Update_Puantaj(item);
                }
                { MessageBox.Show("Listeden bir kayıt seçin"); }
                MessageBox.Show("Kayıt Güncellendi: " + gridView1.GetFocusedRowCellValue("id"));
            }
            catch { MessageBox.Show("Lütfen verileri eksiksiz ve doğru girin, Personel tablosundan seçim yaptığınıza emin olun."); }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("giris_zaman").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cikis_zaman").ToString();
            comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("devamsizlik").ToString();
            textEdit3.Text = mesai_Hesapla(textEdit2.Text, textEdit1.Text);
            dtpicker2.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("tarih"));
            ControlActive(1);
        }
        private string mesai_Hesapla(string dt1,string dt2)
        {
            return (Convert.ToDateTime(textEdit2.Text) - Convert.ToDateTime(textEdit1.Text) - new TimeSpan(10, 0, 0)).TotalHours.ToString();
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            
                for (int i=1; i<= Convert.ToInt32(isgunu.Text); i++)
                {

                    DateTime dt = new DateTime(2023,dtpicker1.DateTime.Month,i);

                    if (db.GetPuantaj().Where(a => a.tarih == dt.ToShortDateString()).Count() == 0)
                    {
                        var item = new Puantaj
                    {
                        p_id= persid,
                        giris_zaman = "07:30:00",
                        cikis_zaman = "17:30:00",
                        tarih = dt.ToString("dd.MM.yyyy"),
                        devamsizlik = "-",
                        mesai_sure =0,
                        c_sure= "10:00:00",
                        ucret= maas/30,  
                    };
                    if (holidays[i] == "Sunday" || holidays[i] == "Saturday")
                    {
                        item.devamsizlik = "h.sonu";
                    }
                    var result = db.insert_Puantaj(item);
                    }
                    else { MessageBox.Show("Seçili personelin" + dt.ToShortDateString() + "tarihinde kaydı mevcuttur."); }
                }
            dtpicker1_DateTimeChanged(sender, e);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2023, dtpicker1.DateTime.Month,01);

            MessageBox.Show(dt.Date.ToShortDateString());
        }

        public void formac(Personel _Pers)
        {
            textad.EditValue= _Pers.P_ad;
            textsoyad.Text = _Pers.P_soyad;
            persid = _Pers.P_id;
            maas = _Pers.P_ucret;
            dtpicker1.Enabled = true;
        }
    }
}