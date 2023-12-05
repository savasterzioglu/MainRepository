 
 

using System;
namespace Projects.DbConnection.Business.MSSQL
{
	    public class dik_islem
    {
        public int Kimlik { get; set;}
        public decimal? ucret { get; set;}
        public int? ukod { get; set;}
    }
    public class Firma
    {
        public string firmaadi { get; set;}
        public string firmaadres { get; set;}
        public int? firmakodu { get; set;}
        public string firmatelefon { get; set;}
        public int Kimlik { get; set;}
    }
    public class FirmaUst
    {
        public int? Firmaid { get; set;}
        public string FirmaUStadi { get; set;}
        public int? FirmaUstkod { get; set;}
        public int Kimlik { get; set;}
    }
    public class hmadde
    {
        public string Birim { get; set;}
        public string hmaciklama1 { get; set;}
        public string hmaciklama2 { get; set;}
        public double? hmkaliteid { get; set;}
        public double? hmkod { get; set;}
        public int? hmolcuid { get; set;}
        public string hmresimno { get; set;}
        public string hmtedarik { get; set;}
        public double? hmturid { get; set;}
        public int Kimlik { get; set;}
        public decimal? satisfiyat1 { get; set;}
        public decimal? satisfiyat2 { get; set;}
    }
    public class hmadde_duz
    {
        public decimal? agirlik { get; set;}
        public string Cins { get; set;}
        public double? Ebat1 { get; set;}
        public double? Ebat2 { get; set;}
        public double? Ebat3 { get; set;}
        public decimal? Ebat4 { get; set;}
        public decimal? Ebat5 { get; set;}
        public double? Hammadde_Kodu { get; set;}
        public int Kimlik { get; set;}
        public string Malzeme_Adi { get; set;}
        public decimal? Ozgul { get; set;}
        public decimal? q2fiyat { get; set;}
        public decimal? q3fiyat { get; set;}
    }
    public class hmkalite
    {
        public string hmkadi { get; set;}
        public decimal? hmozgul { get; set;}
        public int Kimlik { get; set;}
    }
    public class hmolculer
    {
        public int? boy { get; set;}
        public decimal? discap { get; set;}
        public int? en { get; set;}
        public decimal? iccap { get; set;}
        public int? kalinlik { get; set;}
        public int Kimlik { get; set;}
        public int? turid { get; set;}
        public int? uzunluk { get; set;}
    }
    public class hmolculer1
    {
        public int? boy { get; set;}
        public decimal? discap { get; set;}
        public int? en { get; set;}
        public decimal? iccap { get; set;}
        public int? kalinlik { get; set;}
        public int Kimlik { get; set;}
        public int? turid { get; set;}
        public int? uzunluk { get; set;}
    }
    public class hmolculer2
    {
        public int Kimlik { get; set;}
        public decimal? olcu1 { get; set;}
        public decimal? olcu2 { get; set;}
        public decimal? olcu3 { get; set;}
        public decimal? olcu4 { get; set;}
        public int? turid { get; set;}
    }
    public class hmsiparis
    {
        public int? hmkaliteid { get; set;}
        public int? hmolcuid { get; set;}
        public int? hmsipmiktar { get; set;}
        public int? hmturid { get; set;}
        public int? Sipmiktar { get; set;}
        public string Sipno { get; set;}
        public DateTime? Siptarih { get; set;}
        public int SNO { get; set;}
    }
    public class hmstok
    {
        public int? hmadetstk { get; set;}
        public string hmbirim { get; set;}
        public string hmkod { get; set;}
        public int? hmmiktar { get; set;}
        public int Kimlik { get; set;}
    }
    public class hmtur
    {
        public string hmturad { get; set;}
        public int Kimlik { get; set;}
    }
    public class isil_islem
    {
        public int Kimlik { get; set;}
        public decimal? ucret { get; set;}
        public int? ukod { get; set;}
    }
    public class islem_Fiyatlar
    {
        public string birim_fiyat { get; set;}
        public string islem_adi { get; set;}
        public string islem_kod { get; set;}
        public int Kimlik { get; set;}
    }
    public class kaplama_islem
    {
        public int Kimlik { get; set;}
        public decimal? ucret { get; set;}
        public int? ukod { get; set;}
    }
    public class kaynak_islem
    {
        public DateTime? hazirlik { get; set;}
        public int? kalinlik { get; set;}
        public int Kimlik { get; set;}
        public decimal? ucret { get; set;}
        public int? ukod { get; set;}
        public int? uzunluk { get; set;}
    }
    public class kesim_islem
    {
        public DateTime? kesimsure { get; set;}
        public int Kimlik { get; set;}
        public int? parca_boy { get; set;}
        public int? ukod { get; set;}
    }
    public class Kullanıcılar
    {
        public string Eposta { get; set;}
        public int Kimlik { get; set;}
        public string OturumAç { get; set;}
        public string TamAd { get; set;}
    }
    public class lazer_islem
    {
        public decimal? agirlik { get; set;}
        public int Kimlik { get; set;}
        public int? plakaboyut { get; set;}
        public int? toplamadet { get; set;}
        public DateTime? toplamsure { get; set;}
        public decimal? ucret { get; set;}
        public int? ukod { get; set;}
    }
    public class mamul_hmadde
    {
        public int? hmkod { get; set;}
        public int Kimlik { get; set;}
        public int? miktar { get; set;}
        public int? ukod { get; set;}
    }
    public class miktarbirimler
    {
        public int Kimlik { get; set;}
        public string miktarcinsi { get; set;}
    }
    public class montaj_islem
    {
        public int Kimlik { get; set;}
        public decimal? ucret { get; set;}
        public int? ukod { get; set;}
    }
    public class Parca_Hesap
    {
        public int? hmturid { get; set;}
        public int Kimlik { get; set;}
        public int? plkmiktar { get; set;}
        public int? sure { get; set;}
        public string udosya { get; set;}
        public string ukod { get; set;}
    }
    public class Parcalar
    {
        public int Kimlik { get; set;}
        public int? parca_d1 { get; set;}
        public int? parca_d2 { get; set;}
        public int? parca_d3 { get; set;}
        public string parcaadi { get; set;}
        public int? parcahacim { get; set;}
        public int? parcais1 { get; set;}
        public int? parcais2 { get; set;}
        public int? parcais3 { get; set;}
        public int? parcakaliteid { get; set;}
        public int? parcakod { get; set;}
        public DateTime? parcalazersure { get; set;}
        public string parcaresimno { get; set;}
        public int? parcaustmontajkod { get; set;}
        public int? ustfirmaid { get; set;}
    }
    public class Pres_islem
    {
        public int Kimlik { get; set;}
        public int? sure { get; set;}
        public decimal? ucret { get; set;}
        public int? ukod { get; set;}
    }
    public class Puantaj
    {
        public int? c_sure { get; set;}
        public DateTime? cikis_zaman { get; set;}
        public string devamsizlik { get; set;}
        public DateTime? giris_zaman { get; set;}
        public int? mesai_sure { get; set;}
        public int? p_id { get; set;}
        public DateTime tarih { get; set;}
        public decimal? ucret { get; set;}
    }
    public class Sabit_Parametreler
    {
        public int Kimlik { get; set;}
        public string Parametre_adi { get; set;}
        public int? Parametre_fiyat { get; set;}
    }
    public class Sayfa2
    {
        public double? Alan1 { get; set;}
        public string Alan10 { get; set;}
        public string Alan11 { get; set;}
        public string Alan12 { get; set;}
        public string Alan13 { get; set;}
        public string Alan14 { get; set;}
        public string Alan15 { get; set;}
        public string Alan16 { get; set;}
        public string Alan17 { get; set;}
        public string Alan18 { get; set;}
        public string Alan19 { get; set;}
        public double? Alan2 { get; set;}
        public string Alan20 { get; set;}
        public string Alan21 { get; set;}
        public string Alan22 { get; set;}
        public string Alan23 { get; set;}
        public string Alan24 { get; set;}
        public string Alan25 { get; set;}
        public string Alan26 { get; set;}
        public double? Alan3 { get; set;}
        public string Alan4 { get; set;}
        public string Alan5 { get; set;}
        public string Alan6 { get; set;}
        public string Alan7 { get; set;}
        public string Alan8 { get; set;}
        public string Alan9 { get; set;}
        public int Kimlik { get; set;}
    }
    public class Siparis_Kayit
    {
        public int Kimlik { get; set;}
        public int? miktar { get; set;}
        public string mkod { get; set;}
        public int? skod { get; set;}
        public DateTime? starih { get; set;}
        public DateTime? ttarih { get; set;}
        public string uadi { get; set;}
        public int? ukod { get; set;}
    }
    public class taslama_islem
    {
        public int Kimlik { get; set;}
        public int? sure { get; set;}
        public decimal? ucret { get; set;}
        public int? ukod { get; set;}
    }
    public class Teklifler
    {
        public int Kimlik { get; set;}
        public int? teklifdurum { get; set;}
        public decimal? tkffiyat { get; set;}
        public int? tkfmiktar { get; set;}
        public int? tkfmiktarcinsid { get; set;}
        public string tkfmontajkod { get; set;}
        public string tkfno { get; set;}
        public DateTime? tkftarih { get; set;}
        public DateTime? tkfuretimsure { get; set;}
        public string tkfurunkod { get; set;}
    }
    public class torna_islem
    {
        public int Kimlik { get; set;}
        public int? ucret { get; set;}
        public int? ukod { get; set;}
    }
    public class uretim_islem
    {
        public string islem { get; set;}
        public int Kimlik { get; set;}
    }
    public class uretim_montajurun
    {
        public string islem1 { get; set;}
        public string islem10 { get; set;}
        public string islem2 { get; set;}
        public string islem3 { get; set;}
        public string islem4 { get; set;}
        public string islem5 { get; set;}
        public string islem6 { get; set;}
        public string islem7 { get; set;}
        public string islem8 { get; set;}
        public string islem9 { get; set;}
        public int Kimlik { get; set;}
        public string mkodu { get; set;}
    }
    public class uretim_parcaurun
    {
        public string hmkaliteid { get; set;}
        public string hmturid { get; set;}
        public DateTime? imalatsure { get; set;}
        public int? islem1 { get; set;}
        public int? islem10 { get; set;}
        public int? islem2 { get; set;}
        public int? islem3 { get; set;}
        public int? islem4 { get; set;}
        public int? islem5 { get; set;}
        public int? islem6 { get; set;}
        public int? islem7 { get; set;}
        public int? islem8 { get; set;}
        public int? islem9 { get; set;}
        public int Kimlik { get; set;}
        public string mkodu { get; set;}
        public string ukodu { get; set;}
        public string uresimno { get; set;}
    }
    public class uretim_plan
    {
        public int Kimlik { get; set;}
        public decimal? p_fiyat { get; set;}
        public int? p_fmid { get; set;}
        public string p_tkfno { get; set;}
        public string p_udurum { get; set;}
        public DateTime? p_ugitistarih { get; set;}
    }
    public class urun
    {
        public string firma { get; set;}
        public int Kimlik { get; set;}
        public int? mkodu { get; set;}
        public decimal? tekfiyat { get; set;}
        public DateTime? tektarih { get; set;}
        public string uaciklama { get; set;}
        public string uadi { get; set;}
        public int? uagirlik { get; set;}
        public int ukodu { get; set;}
        public int? uolcu { get; set;}
        public string uresimno { get; set;}
    }
    public class Urun_islem
    {
        public int? islem { get; set;}
        public int Kimlik { get; set;}
        public int? stokkod { get; set;}
        public int? ukod { get; set;}
        public string uresimno { get; set;}
    }
    public class urun_mamul
    {
        public int Kimlik { get; set;}
        public string miktar { get; set;}
        public int? mkod { get; set;}
        public int? ukod { get; set;}
    }
    public class Urunler3
    {
        public string birim { get; set;}
        public string hmaciklama1 { get; set;}
        public double? hmkaliteid { get; set;}
        public double? hmkod { get; set;}
        public double? hmsatisfiyat1 { get; set;}
        public double? hmsatisfiyat2 { get; set;}
        public string hmtedarik { get; set;}
        public double? hmturid { get; set;}
        public int Kimlik { get; set;}
    }
    public class URUNLER4
    {
        public int Kimlik { get; set;}
        public double? mkodu { get; set;}
        public double? tekfiyat { get; set;}
        public string uadi { get; set;}
        public double? ukodu { get; set;}
        public string uresimno { get; set;}
    }
    public class test
    {
        public string DESCRIPTION { get; set;}
        public int ID { get; set;}
    }
    public class test2
    {
        public string DESCRIPTION { get; set;}
        public int ID { get; set;}
    }
    public class Personel
    {
        public int Kimlik { get; set;}
        public string P_ad { get; set;}
        public string p_adres { get; set;}
        public string p_dtarihi { get; set;}
        public int? P_id { get; set;}
        public string P_soyad { get; set;}
        public int? p_telefon { get; set;}
        public decimal P_ucret { get; set;}
    }
    public class Deneme
    {
        public string vc { get; set;}
        public string vf { get; set;}
        public string vs { get; set;}
    }
    public class mamul
    {
        public string hmkod { get; set;}
        public string hmmiktar { get; set;}
        public string Kimlik { get; set;}
        public string parcaadi { get; set;}
        public string parcafirmakod { get; set;}
        public string parcafiyat { get; set;}
        public string parcaturu { get; set;}
        public string ukod { get; set;}
        public string uretimdurum { get; set;}
    }
    public class Durum
    {
        public string durum { get; set;}
        public int Kimlik { get; set;}
    }
    public class bukum_islem
    {
        public int Kimlik { get; set;}
        public decimal? ucret { get; set;}
        public string ukod { get; set;}
    }

}