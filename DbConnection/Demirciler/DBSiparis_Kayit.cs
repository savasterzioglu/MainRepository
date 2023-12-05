using System.Collections.Generic;
using System.Linq;
using DbConnection.Business;
using DbConnection.Data.MSSQL.Business;


namespace DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        

       
        public List<Siparis_Kayit> GetSiparis_Kayit()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<Siparis_Kayit>($"Select * From Siparis_Kayit").ToList();
            }
        }
      
    }
}