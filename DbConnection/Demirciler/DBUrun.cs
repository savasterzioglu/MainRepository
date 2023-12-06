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
        public ResultStatus Update_urun(urun item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdate<urun>(item);
            }
        }

        public ResultStatus insert_urunl(urun item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<urun>(item);
            }
        }

        public ResultStatus delete_urun(urun item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<urun>(item);
            }
        }

    }
}