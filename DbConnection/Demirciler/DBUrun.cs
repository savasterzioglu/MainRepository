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
                return db.ExecuteReader<urun>($"Select * From urun").ToList();
            }
        }
        public ResultStatus Update_urunByID(urun item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<urun>(item);
            }
        }

        public ResultStatus insert_urun(urun item)
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