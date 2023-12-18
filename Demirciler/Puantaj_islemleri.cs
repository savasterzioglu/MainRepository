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
        //public Personel Pers = new Personel();

       /* public string textadValue
        {
            get { return textad.Text; }
            set { textad.Text = value; }
        }*/

        public Puantaj_islemleri(Personel pers)
        {
            InitializeComponent();

            ControlActive(0);
            textad.Text = pers.P_ad;
            textsoyad.Text = pers.P_soyad;
            persid = pers.P_id;
            //gunleridoldur(DateTime.Now);

           // gridControl2.DataSource = db.GetPersonel().ToList();
          //  gridView2.BestFitColumns();
        }

        void gunleridoldur(DateTime dt)
        {
            int is_gunu=0, h_sonu = 0;
            is_gunu =  DateTime.DaysInMonth(dt.Year, dt.Month);
            isgunu.EditValue = is_gunu;

            for (int i = 1; i <= is_gunu; i++)
            {
                //int j = 0;
                holidays[i] = new DateTime(dt.Year, dt.Month, i).DayOfWeek.ToString();
                //MessageBox.Show(holidays[i]);
                if (holidays[i] == "Sunday" || holidays[i] == "Saturday")
                {
                    //j++;
                    //holidays[j] = i;
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
    */        gridView1.Columns["tarih"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Form frm = new Personel_islemleri();
           Personel_Sec frm = new Personel_Sec();
            frm.ShowDialog();
            
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
                    giris_zaman = textEdit1.Text,
                    cikis_zaman = textEdit2.Text,
                    devamsizlik = comboBoxEdit1.Text,
                    c_sure = ts1.Add(ts2).ToString(),
                    mesai_sure = ts2.TotalHours,
                    ucret = UcretHesapla(Convert.ToDecimal(ts1.TotalHours),Convert.ToDecimal(ts2.TotalHours)) ,
                    tarih = dtpicker2.Text,
              //      p_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("P_id")),
                };
                var result = db.insert_Puantaj(item);
               // MessageBox.Show(UcretHesapla(Convert.ToDecimal(ts1.TotalHours), Convert.ToDecimal(ts2.TotalHours)).ToString());
                //MessageBox.Show(maas.ToString());
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
            }


        }
        decimal UcretHesapla(decimal m1,decimal t)
        {
            //m1 günlük çalışılan normal süre
            //t günlük çalışılan mesai süresi
            
            decimal r1;
            r1 = (maas/300)*(m1 + (t*(3/2)));
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
                    giris_zaman = textEdit1.Text,
                    cikis_zaman = textEdit2.Text,
                    devamsizlik = comboBoxEdit1.Text,
                    c_sure = ts1.Add(ts2).ToString(),
                    mesai_sure = ts2.TotalHours,
                    ucret = UcretHesapla(Convert.ToDecimal(ts1.TotalHours), Convert.ToDecimal(ts2.TotalHours)),
                    p_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("p_id")),
                };
                //if (item.id != 0)
                //{
                    var result = db.Update_Puantaj(item);
                //}
                //else { MessageBox.Show("Listeden bir kayıt seçin"); }
                //MessageBox.Show("Personel id :", gridView1.GetFocusedRowCellValue("P_id").ToString());
                MessageBox.Show("Kayıt Güncellendi: " + gridView1.GetFocusedRowCellValue("id"));
                // MessageBox.Show(UcretHesapla(Convert.ToDecimal(ts1.TotalHours), Convert.ToDecimal(ts2.TotalHours)).ToString());
                //MessageBox.Show(maas.ToString());
            }
            catch { MessageBox.Show("Lütfen verileri eksiksiz ve doğru girin, Personel tablosundan seçim yaptığınıza emin olun."); }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("giris_zaman").ToString();
            textEdit2.Text = gridView1.GetFocusedRowCellValue("cikis_zaman").ToString();
            comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("devamsizlik").ToString();
            textEdit3.Text = mesai_Hesapla(textEdit2.Text, textEdit1.Text);
            dtpicker2.Text = gridView1.GetFocusedRowCellValue("tarih").ToString();
            //MessageBox.Show(mesai_Hesapla(textEdit2.Text, textEdit1.Text));
        }
        private string mesai_Hesapla(string dt1,string dt2)
        {
            //return (Convert.ToDateTime(dt2)-Convert.ToDateTime(dt1)- (new TimeSpan(10,0,0))).ToString();
            return (Convert.ToDateTime(textEdit2.Text) - Convert.ToDateTime(textEdit1.Text) - new TimeSpan(10, 0, 0)).TotalHours.ToString();
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
      //---//      if (isgunu.Text != "" && gridView2.GetFocusedRowCellValue("P_id").ToString() != "")
            {
                for (int i=1; i<= Convert.ToInt32(isgunu.Text); i++)
                {
                    DateTime dt = new DateTime(2023,dtpicker1.DateTime.Month,i);
                    dt.GetDateTimeFormats();
                    if (db.GetPuantaj().Where(a => a.tarih == dt.ToShortDateString()).Count() == 0)
                    {
                        var item = new Puantaj
                    {
        //-----///                p_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("P_id")),
                        giris_zaman = "07:30:00",
                        cikis_zaman = "17:30:00",
                        tarih = dt.Date.ToShortDateString(),
                        devamsizlik = "-",
                        mesai_sure =0,
                        c_sure= "10:00:00",
                        ucret= maas/Convert.ToInt32(isgunu.Text),  
                    };
                    if (holidays[i] == "Sunday" || holidays[i] == "Saturday")
                    {
                        item.devamsizlik = "h.sonu";
                    }

                   // var item2 = new Puantaj
                    
                    var result = db.insert_Puantaj(item);
                    }
                    else { MessageBox.Show("Seçili personelin" + dt.ToShortDateString() + "tarihinde kaydı mevcuttur."); }
                }
                gridControl2_DoubleClick(sender,e);
            };
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2023, dtpicker1.DateTime.Month,01);

            MessageBox.Show(dt.Date.ToShortDateString());
            //using var holidayClient = new HolidayClient();
        }

    }
}