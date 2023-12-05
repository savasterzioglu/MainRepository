using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.MSSQL.Business;
using Projects.DbConnection.MSSQL;
using System;

namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<Personel> GetPersonel()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<Personel>($"SELECT * FROM Personel").ToList();
            }


        }

        public ResultStatus insert_Personel(Personel item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<Personel>(item);
            }
        }

        public ResultStatus delete_Personel(Personel item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<Personel>(item);
            }
        }


    }
}