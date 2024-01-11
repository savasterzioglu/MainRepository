using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<islemler> GetIslemler()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<islemler>($"SELECT * FROM islemler").ToList();
            }
        }

        public ResultStatus Update_Islemler(islemler item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<islemler>(item);
            }
        }

        public ResultStatus insert_Islemler(islemler item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<islemler>(item);
            }
        }

        public ResultStatus delete_Islemler(islemler item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<islemler>(item);
            }
        }


    }
}