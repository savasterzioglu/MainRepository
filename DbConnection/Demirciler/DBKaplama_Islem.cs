using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<kaplama_islem> GetKaplamaIslem()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<kaplama_islem>($"SELECT * FROM kaplama_islem").ToList();
            }
        }

        public ResultStatus Update_Kaplama_Islem(kaplama_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<kaplama_islem>(item);
            }
        }

        public ResultStatus insert_Kaplama_Islem(kaplama_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<kaplama_islem>(item);
            }
        }

        public ResultStatus delete_Kaplama_Islem(kaplama_islem item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<kaplama_islem>(item);
            }
        }


    }
}