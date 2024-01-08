using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<bukum_islem> GetBukumIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<bukum_islem>($"SELECT * FROM bukum_islem").ToList();
            }
        }

        public ResultStatus Update_Bukum_Islem(bukum_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<bukum_islem>(item);
            }
        }

        public ResultStatus insert_Bukum_Islem(bukum_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<bukum_islem>(item);
            }
        }

        public ResultStatus delete_Bukum_Islem(bukum_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<bukum_islem>(item);
            }
        }


    }
}