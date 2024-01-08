using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<mamul> GetMamul()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<mamul>($"SELECT * FROM mamul").ToList();
            }
        }

        public ResultStatus Update_Mamul(mamul item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<mamul>(item);
            }
        }

        public ResultStatus insert_Mamul(mamul item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<mamul>(item);
            }
        }

        public ResultStatus delete_Mamul(mamul item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<mamul>(item);
            }
        }


    }
}