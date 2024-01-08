using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<montaj_islem> GetMontajIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<montaj_islem>($"SELECT * FROM montaj_islem").ToList();
            }
        }

        public ResultStatus Update_Montaj_Islem(montaj_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<montaj_islem>(item);
            }
        }

        public ResultStatus insert_Montaj_Islem(montaj_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<montaj_islem>(item);
            }
        }

        public ResultStatus delete_Montaj_Islem(montaj_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<montaj_islem>(item);
            }
        }


    }
}