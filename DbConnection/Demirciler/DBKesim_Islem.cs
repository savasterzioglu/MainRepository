using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.Business.MSSQL;


namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
             public List<kesim_islem> GetKesim_Islem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<kesim_islem>($"Select * From kesim_islem").ToList();
            }
        }

        public ResultStatus Update_Kesim_Islem(kesim_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<kesim_islem>(item);
            }
        }

        public ResultStatus insert_Kesim_Islem(kesim_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<kesim_islem>(item);
            }
        }

        public ResultStatus delete_Kesim_Islem(kesim_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<kesim_islem>(item);
            }
        }


    }
}