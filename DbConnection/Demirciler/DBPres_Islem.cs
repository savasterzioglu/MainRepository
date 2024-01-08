using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<Pres_islem> GetPresIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<Pres_islem>($"SELECT * FROM Pres_islem").ToList();
            }
        }

        public ResultStatus Update_Pres_Islem(Pres_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<Pres_islem>(item);
            }
        }

        public ResultStatus insert_Pres_Islem(Pres_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<Pres_islem>(item);
            }
        }

        public ResultStatus delete_Pres_Islem(Pres_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<Pres_islem>(item);
            }
        }


    }
}