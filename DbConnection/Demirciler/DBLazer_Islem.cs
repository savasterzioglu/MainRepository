using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<lazer_islem> GetLazerIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<lazer_islem>($"SELECT * FROM lazer_islem").ToList();
            }
        }

        public ResultStatus Update_Lazer_Islem(lazer_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<lazer_islem>(item);
            }
        }

        public ResultStatus insert_Lazer_Islem(lazer_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<lazer_islem>(item);
            }
        }

        public ResultStatus delete_Lazer_Islem(lazer_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<lazer_islem>(item);
            }
        }


    }
}