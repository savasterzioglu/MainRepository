using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.Business.MSSQL;


namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
             public List<Urun_islem> GetUrun_Islem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<Urun_islem>($"Select * From Urun_islem").ToList();
            }
        }

        public ResultStatus Update_Urun_Islem(Urun_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<Urun_islem>(item);
            }
        }

        public ResultStatus insert_Urun_Islem(Urun_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<Urun_islem>(item);
            }
        }

        public ResultStatus delete_Urun_Islem(Urun_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<Urun_islem>(item);
            }
        }


    }
}