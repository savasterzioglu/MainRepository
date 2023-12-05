using System.Collections.Generic;
using System.Linq;
using DbConnection.Business;
using DbConnection.Data.MSSQL.Business;


namespace DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<urun> GetUrun()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<urun>($"Select * From Siparis_Kayit").ToList();
            }
        }
    
    }
}