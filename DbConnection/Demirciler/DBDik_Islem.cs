using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<dik_islem> GetDikIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<dik_islem>($"SELECT * FROM dik_islem").ToList();
            }
        }

        public ResultStatus Update_Dik_Islem(dik_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<dik_islem>(item);
            }
        }

        public ResultStatus insert_Dik_Islem(dik_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<dik_islem>(item);
            }
        }

        public ResultStatus delete_Dik_Islem(dik_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<dik_islem>(item);
            }
        }


    }
}