using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBConnection.Business.MSSQL
{
    public class SIRKET
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class Personel
    {
        public int Kimlik { get; set; }
        public string P_ad { get; set; }
        public string p_adres { get; set; }
        public DateTime? p_dtarihi { get; set; }
        public int? P_id { get; set; }
        public string P_soyad { get; set; }
        public int? p_telefon { get; set; }
        public decimal P_ucret { get; set; }
    }

}