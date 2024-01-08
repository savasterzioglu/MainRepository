using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<isil_islem> GetIsilIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<isil_islem>($"SELECT * FROM isil_islem").ToList();
            }
        }

        public ResultStatus Update_Isil_Islem(isil_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<isil_islem>(item);
            }
        }

        public ResultStatus insert_Isil_Islem(isil_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<isil_islem>(item);
            }
        }

        public ResultStatus delete_Isil_Islem(isil_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<isil_islem>(item);
            }
        }


    }
}