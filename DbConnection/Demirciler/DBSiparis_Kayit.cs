using System.Collections.Generic;
using System.Linq;


namespace Projects.DbConnection.Business.MSSQL
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