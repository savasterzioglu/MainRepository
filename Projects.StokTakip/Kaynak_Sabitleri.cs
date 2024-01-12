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
        public Kaynak_Sabitleri()
        {
            InitializeComponent();
            gridDoldur();
        }

        void gridDoldur()
        {
            gridControl1.DataSource = db.GetKaynak_Sabitleri();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kayit = db.GetKaynak_Sabitleri().Where(a=> a.kaynaktipi == kaynaktipi.Text).Count();

            var item = new kaynak_sabitleri();
            item.kaynaktipi = kaynaktipi.Text;
            item.kaynakkalinlik = (float) Convert.ToDouble(kalinlik.Text);
            item.kaynakparametresi = Convert.ToInt32(kaynakparametresi.Text);
            item.dktelmiktari = Convert.ToInt32(surulecektelmiktari.Text);
            item.hacim = (float)Convert.ToDouble(hacim.Text);
            item.kaynaktelcapi = (float)Convert.ToDouble(kaynaktelcap.Text);
            item.harcanacakteluzunluk = uzunluk_hesap(Convert.ToDouble(kaynaktelcap.Text), Convert.ToDouble(hacim.Text) );
            item.metrekaynakagirlik = agirlik_hesap(harcanacakteluzunluk.Text);

            if (kayit == 0)
            {
                var result = db.insert_Kaynak_Sabitleri(item);
            }
            else
            {
                item.id = db.GetKaynak_Sabitleri().Where(a => a.kaynaktipi == kaynaktipi.Text).Select(b => b.id).FirstOrDefault();
                var result2 = db.Update_Kaynak_Sabitleri(item);
            }
            gridDoldur();
        }
        private float agirlik_hesap(string _hacim)
        {
            return (float) Math.Round((Convert.ToDouble(_hacim) * 7.86) / 1000,2);
        }
        private float uzunluk_hesap(double _cap, double _hacim)
        {
            var agirlik = (_hacim * 7.86)/1000;
            var deger = (Math.Pow((_cap/2/1000), 2) * 7.86 * 3.14);
            var sonuc = (agirlik / deger) / 1000;
            sonuc = Math.Round(sonuc, 2);
            return (float)(
            sonuc
            );
        }

        private void hacim_EditValueChanged(object sender, EventArgs e)
        {
          kaynakagirlik.EditValue=  agirlik_hesap(hacim.Text);
        }

        private void Kaynak_Sabitleri_Load(object sender, EventArgs e)
        {

        }

        private void kaynakagirlik_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void kaynaktelcap_EditValueChanged(object sender, EventArgs e)
        {
            harcanacakteluzunluk.EditValue = Math.Round(uzunluk_hesap(Convert.ToDouble(kaynaktelcap.Text), Convert.ToDouble(hacim.Text)), 2);
        }
    }
}