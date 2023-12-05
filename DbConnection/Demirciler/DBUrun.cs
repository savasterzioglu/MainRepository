using System.Collections.Generic;
using System.Linq;


namespace Projects.DbConnection.Business.MSSQL
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