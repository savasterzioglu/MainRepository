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
        public ResultStatus Update_Siparis_Kayit(Siparis_Kayit item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdate<Siparis_Kayit>(item);
            }
        }

        public ResultStatus insert_Siparis_Kayit(Siparis_Kayit item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<Siparis_Kayit>(item);
            }
        }

        public ResultStatus delete_Siparis_Kayit(Siparis_Kayit item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<Siparis_Kayit>(item);
            }
        }

    }
}