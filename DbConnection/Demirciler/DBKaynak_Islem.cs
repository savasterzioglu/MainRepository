using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<kaynak_islem> GetKaynakIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<kaynak_islem>($"SELECT * FROM kaynak_islem").ToList();
            }
        }

        public ResultStatus Update_Kaynak_Islem(kaynak_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<kaynak_islem>(item);
            }
        }

        public ResultStatus insert_Kaynak_Islem(kaynak_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<kaynak_islem>(item);
            }
        }

        public ResultStatus delete_Kaynak_Islem(kaynak_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<kaynak_islem>(item);
            }
        }


    }
}