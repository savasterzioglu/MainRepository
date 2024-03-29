﻿using System;
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
    public partial class Kaynak_Maliyeti : DevExpress.XtraEditors.XtraForm
    {
        public DemircilerDB db = new DemircilerDB();
        public Kaynak_Maliyeti()
        {
            InitializeComponent();
        }

        void gridDoldur()
        {
            gridControl1.DataSource = "";
            gridControl1.DataSource = db.GetKaynak_Maliyet();
            gridView1.BestFitColumns();

            _kaynak_tipi.Properties.DataSource = "";
            _kaynak_tipi.Properties.DataSource = db.GetKaynak_Sabitleri().Select(a=> new { a.id,a.kaynaktipi });
            _kaynak_tipi.Properties.DisplayMember = "kaynaktipi";
            _kaynak_tipi.Properties.ValueMember = "id";
            _kaynak_tipi.Properties.PopulateColumns();
            _kaynak_tipi.Properties.Columns[0].Visible = false;
            _kaynak_tipi.Properties.Columns[1].MaxWidth = 5;

           
         }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var _item = new kaynak_maliyet
            {
                
                ust_kurulus_adi = _ust_kurulus_adi.Text,
                firma_adi = _firma_adi.Text,
                pkod = Convert.ToInt32(_pkod.Text),
                padi = _padi.Text,
                kaynak_tipi = _kaynak_tipi.Text,
                kaynak_uzunluk = Cf(_kaynak_uzunluk.Text),
                kayip_zaman_kat_sayi = Cf(_kayip_zaman_ks.Text),
                capak_alma_kat_sayi  = Cf(_capak_mastar_ks.Text),
                uretim_suresi = Cf(_p_uretim_sure.Text),
                gunde_uretilecek_adet = Cf(_gunde_uretilecek_adet.Text),
                kaynak_tel_maliyet = Cf(_kaynak_tel_maliyet.Text),
                karisim_gaz_maliyet= Cf(_karisim_gaz_maliyet.Text),
                iscilik_maliyeti = Cf(_iscilik_maliyet.Text),
                sabit_maliyeti  = Cf(_sabit_maliyet.Text),
                diger_sarf_maliyet = Cf(_diger_sarf_maliyet.Text),
                matrah = Cf(_matrah.Text),
                kar_orani = Cf(_kar_orani.Text),
                kar = Cf(_kar.Text),
                basabas_noktasi = Cf(_basabas_noktasi.Text),
                fiyat = Cf(_fiyat.Text),
                parca_maliyeti = Cf(_parca_maliyet.Text),
                toplam_maliyet = Cf(_toplam_maliyet.Text)
            };

            if (db.GetKaynak_Maliyet().Where(a => a.pkod == Convert.ToInt32(_pkod)) == null)
            {
                var _result = db.insert_Kaynak_Maliyet(_item);
            } else
            {
                _item.id = db.GetKaynak_Maliyet().Where(a => a.pkod == Convert.ToInt32(_pkod)).Select(b => b.pkod).First();
                var _result2 = db.Update_Kaynak_Maliyet(_item);
            }


            gridDoldur();
        }

        float Cf(string deger)
        {
            return (float)Convert.ToDecimal(deger);
        }

        double Cd (string deger)
        {
            return (double)Convert.ToDecimal(deger);
        }

        void SabitDegerler()
        {
            _kaynak_tel_kg_fiyat.Text =  db.GetSabit_Parametreler().Where(a=> a.id == 19).Select(x=> x.Parametre_fiyat).First().ToString();
            _kaynak_gaz_lt_fiyat.Text = db.GetSabit_Parametreler().Where(a => a.id == 18).Select(x => x.Parametre_fiyat).First().ToString();
            _iscilik_dk_fiyat.Text = db.GetSabit_Parametreler().Where(a => a.id == 2).Select(x => x.Parametre_fiyat).First().ToString();
            _sabit_maliyet_dk_fiyat.Text = db.GetSabit_Parametreler().Where(a => a.id == 3).Select(x => x.Parametre_fiyat).First().ToString();
        }

        private void Kaynak_Maliyeti_Load(object sender, EventArgs e)
        {
            gridDoldur();
            SabitDegerler();
            _kaynak_tipi.Properties.PopulateColumns();
            _kaynak_tipi.Properties.Columns[0].Visible = false;

        }

        private void _kaynak_tipi_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit edit = sender as LookUpEdit;
            edit.Properties.Columns[1].Width = 50;
            edit.Properties.PopupFormMinSize = new Size(50, 50);
        }

        void kaynak_tip_change()
        {
            var _Liste1 = new kaynak_sabitleri();
            _Liste1 = db.GetKaynak_Sabitleri().Where(a => a.id == Convert.ToInt32(_kaynak_tipi.EditValue.ToString())).First();
            var _Liste2 = new Sabit_Parametreler();
            //_Liste2= db.GetSabit_Parametreler().Where(b=> b.)

            _kaynak_param.Text = _Liste1.kaynakparametresi.ToString();
            _kaynak_tel_cap.Text = _Liste1.kaynaktelcapi.ToString();
            _kaynak_agirlik.Text = _Liste1.metrekaynakagirlik.ToString();
            _dk_tel_miktar.Text = _Liste1.dktelmiktari.ToString();
            //_dk_gaz_miktar.Text = _Liste.
            _sacinti.Text = db.GetSabit_Parametreler().Where(y => y.id == 20).Select(x => x.Parametre_fiyat).First().ToString();
            _kaynak_agirlik_kg.Text = ((Cf(_kaynak_uzunluk.Text) / 1000) * Cf(_kaynak_agirlik.Text)).ToString();
            _sicranti_dahil_harcanacak_tel.Text = ((Cf(_sacinti.Text) / 100) * Cf(_kaynak_agirlik_kg.Text)+Cf(_kaynak_agirlik_kg.Text)).ToString();
            _surulecek_tel_uzunluk.Text =
                ((Cf(_sicranti_dahil_harcanacak_tel.Text) * 1000000) /                
                (7.86 * 3.14 * Math.Pow(Cf(_kaynak_tel_cap.Text) / 2, 2)) / 1000).ToString();
            _dk_kullanilacak_gaz_lt.Text = (Cf(_kaynak_tel_cap.Text) * 11.5).ToString();

            _teorik_kaynak_suresi.Text = (Cf(_surulecek_tel_uzunluk.Text)/Cf(_dk_tel_miktar.Text)).ToString();
            _fiil_kaynak_sure.Text = (Cf(_kaynak_param.Text)*Cf(_teorik_kaynak_suresi.Text)).ToString();
            _kullanilacak_gaz_lt.Text = (Cf(_dk_kullanilacak_gaz_lt.Text) * Cf(_fiil_kaynak_sure.Text)).ToString();
            _p_uretim_sure.Text = (Cf(_fiil_kaynak_sure.Text) * (1+ Cf(_kayip_zaman_ks.Text) + Cf(_capak_mastar_ks.Text))).ToString();
            _gunde_uretilecek_adet.Text = (480 / Cf(_p_uretim_sure.Text)).ToString();

    //        _kaynak_tel_maliyet.Text = (Cf(_sicranti_dahil_harcanacak_tel.Text)*Cf(_kaynak_tel_kg_fiyat.Text)).ToString();
    //        _karisim_gaz_maliyet.Text = (Cf(_kullanilacak_gaz_lt.Text)*Cf(_kaynak_gaz_lt_fiyat.Text)).ToString();
    //        _iscilik_maliyet.Text = (Cf(_p_uretim_sure.Text)*Cf(_iscilik_dk_fiyat.Text)).ToString();
    //        _sabit_maliyet.Text = (Cf(_p_uretim_sure.Text)*Cf(_sabit_maliyet_dk_fiyat.Text)).ToString();
    //        _diger_sarf_maliyet.Text = (Cf(_iscilik_maliyet.Text)*0.12).ToString();

      //      _matrah.Text = (Cf(_kaynak_tel_maliyet.Text)+Cf(_karisim_gaz_maliyet.Text)+Cf(_iscilik_maliyet.Text)+Cf(_sabit_maliyet.Text)+Cf(_diger_sarf_maliyet.Text)).ToString();
      //      _kar.Text = (Cf(_iscilik_maliyet.Text)*Cf(_kar_orani.Text)).ToString();
      //      _basabas_noktasi.Text = _matrah.Text + 0/*Toplam var ama Gelecek Değer Boş adlı sütun*/;
      //      _fiyat.Text = (Cf(_matrah.Text)+0/**/+Cf(_kar.Text)).ToString();

            // Gerekli olmayan veriler.
            //_parca_maliyet.Text = "";
            //_toplam_maliyet.Text = (Cf(_fiyat.Text)+Cf(_parca_maliyet.Text)).ToString();

        }
        
        private void _kaynak_tipi_EditValueChanged(object sender, EventArgs e)
        {
            kaynak_tip_change();
        }

        private void _kaynak_uzunluk_EditValueChanged(object sender, EventArgs e)
        {
            kaynak_tip_change();
        }
    }
}