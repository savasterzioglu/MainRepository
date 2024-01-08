using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.Business.MSSQL;


namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
             public List<uretim_islem> GetUretim_Islem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<uretim_islem>($"Select * From uretim_islem").ToList();
            }
        }

        public ResultStatus Update_Uretim_Islem(uretim_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<uretim_islem>(item);
            }
        }

        public ResultStatus insert_Uretim_Islem(uretim_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<uretim_islem>(item);
            }
        }

        public ResultStatus delete_Uretim_Islem(uretim_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<uretim_islem>(item);
            }
        }


    }
}