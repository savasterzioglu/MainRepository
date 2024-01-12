using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<kaynak_sabitleri> GetKaynak_Sabitleri()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<kaynak_sabitleri>($"SELECT * FROM kaynak_sabitleri").ToList();
            }
        }

        public ResultStatus Update_Kaynak_Sabitleri(kaynak_sabitleri item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<kaynak_sabitleri>(item);
            }
        }

        public ResultStatus insert_Kaynak_Sabitleri(kaynak_sabitleri item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<kaynak_sabitleri>(item);
            }
        }

        public ResultStatus delete_Kaynak_Sabitleri(kaynak_sabitleri item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<kaynak_sabitleri>(item);
            }
        }


    }
}