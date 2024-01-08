using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<torna_islem> GetTornaIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<torna_islem>($"SELECT * FROM torna_islem").ToList();
            }
        }

        public ResultStatus Update_Torna_Islem(torna_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<torna_islem>(item);
            }
        }

        public ResultStatus insert_Torna_Islem(torna_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<torna_islem>(item);
            }
        }

        public ResultStatus delete_Torna_Islem(torna_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<torna_islem>(item);
            }
        }


    }
}