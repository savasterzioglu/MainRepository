using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<taslama_islem> GetTaslamaIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<taslama_islem>($"SELECT * FROM taslama_islem").ToList();
            }
        }

        public ResultStatus Update_Taslama_Islem(taslama_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<taslama_islem>(item);
            }
        }

        public ResultStatus insert_Taslama_Islem(taslama_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<taslama_islem>(item);
            }
        }

        public ResultStatus delete_Taslama_Islem(taslama_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<taslama_islem>(item);
            }
        }


    }
}