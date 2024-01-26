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
    
    public partial class Kaynak_Sabitleri : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();
        public kaynak_sabitleri  _kaynak_param_item = new kaynak_sabitleri();
        public Kaynak_Sabitleri()
        {
            InitializeComponent();
            gridDoldur();
            _kaynak_param_item.id = 0;
        }

        void gridDoldur()
        {
            gridControl1.DataSource = db.GetKaynak_Sabitleri();
        }

        void temizle()
        {
            kaynakagirlik.EditValue = 0;
            kaynaktelcap.EditValue = 0;
            kaynakparametresi.EditValue = 0;
            kaynaktipi.EditValue = "";
            harcanacakteluzunluk.EditValue = 0;
            surulecektelmiktari.EditValue = 0;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kayit = db.GetKaynak_Sabitleri().Where(a=> a.kaynaktipi.Contains(kaynaktipi.Text)).Count();
            var item = new kaynak_sabitleri();
            item.kaynaktipi = kaynaktipi.Text;
            item.kaynakkalinlik = Convert.ToDouble(kalinlik.Text);
            item.kaynakparametresi = Convert.ToInt32(kaynakparametresi.Text);
            item.dktelmiktari = Convert.ToInt32(surulecektelmiktari.Text);
            item.hacim = Convert.ToDouble (hacim.Text);
            item.kaynaktelcapi = Convert.ToDouble(kaynaktelcap.Text);
            item.harcanacakteluzunluk = Convert.ToDouble(harcanacakteluzunluk.Text);
            item.metrekaynakagirlik =Convert.ToDouble(kaynakagirlik.Text);

            if (_kaynak_param_item.id == 0 && kayit == 0)
            {
                var result = db.insert_Kaynak_Sabitleri(item);
            }
            else
            {
                //item.id = db.GetKaynak_Sabitleri().Where(a => a.kaynaktipi == kaynaktipi.Text).Select(b => b.id).FirstOrDefault();
                item.id = _kaynak_param_item.id;
                var result2 = db.Update_Kaynak_Sabitleri(item);
                _kaynak_param_item.id = 0;
            }
            gridDoldur();
            temizle();
            
        }
        private double agirlik_hesap(string _hacim)
        {
            return  Math.Round((Convert.ToDouble(_hacim) * 7.86) / 1000,7);
        }
        private double uzunluk_hesap(double _cap, double _hacim)
        {
            var agirlik = (_hacim * 7.86)/1000;
            var deger = (Math.Pow((_cap/2/1000), 2) * 7.86 * Math.PI);
            var sonuc = (agirlik / deger) / 1000;
            sonuc = Math.Round(sonuc, 7);
            return  sonuc;
        }

        private void hacim_EditValueChanged(object sender, EventArgs e)
        {
          kaynakagirlik.EditValue=  agirlik_hesap(hacim.Text);
            textEdit1.Text = agirlik_hesap(hacim.Text).ToString();
        }

        private void kaynaktelcap_EditValueChanged(object sender, EventArgs e)
        {
            harcanacakteluzunluk.EditValue = Math.Round(uzunluk_hesap(Convert.ToDouble(kaynaktelcap.Text), Convert.ToDouble(hacim.Text)), 7);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            _kaynak_param_item = new kaynak_sabitleri()
            {
                 id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString()),
                 hacim = Convert.ToDouble(gridView1.GetFocusedRowCellValue("hacim").ToString()),
                 dktelmiktari = Convert.ToInt32(gridView1.GetFocusedRowCellValue("dktelmiktari").ToString()),
                 harcanacakteluzunluk = Convert.ToDouble(gridView1.GetFocusedRowCellValue("harcanacakteluzunluk").ToString()),
                 kaynakkalinlik = Convert.ToDouble(gridView1.GetFocusedRowCellValue("kaynakkalinlik").ToString()),
                 kaynakparametresi = Convert.ToInt32(gridView1.GetFocusedRowCellValue("kaynakparametresi").ToString()),
                 kaynaktelcapi = Convert.ToDouble(gridView1.GetFocusedRowCellValue("kaynaktelcapi").ToString()),
                 kaynaktipi = gridView1.GetFocusedRowCellValue("kaynaktipi").ToString(),
                 metrekaynakagirlik = Convert.ToDouble(gridView1.GetFocusedRowCellValue("metrekaynakagirlik").ToString())
            };
            kaynaktipi.Text = _kaynak_param_item.kaynaktipi;
            kalinlik.Text = _kaynak_param_item.kaynakkalinlik.ToString();
            kaynakparametresi.Text = _kaynak_param_item.kaynakparametresi.ToString();
            surulecektelmiktari.Text = _kaynak_param_item.dktelmiktari.ToString();
            hacim.Text = _kaynak_param_item.hacim.ToString();
            kaynakagirlik.Text = _kaynak_param_item.metrekaynakagirlik.ToString();
            harcanacakteluzunluk.Text = _kaynak_param_item.harcanacakteluzunluk.ToString();
            kaynaktelcap.Text = _kaynak_param_item.kaynaktelcapi.ToString();

           
        }

        float Cf(string deger)
        {
            return (float)Convert.ToDecimal(deger);
        }

    }
}