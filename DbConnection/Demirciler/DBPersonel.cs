using System.Collections.Generic;
using System.Linq;
using DbConnection.Business;
using Projects.DbConnection.Data.MSSQL.Business;
using Projects.DbConnection.Data.MSSQL;
using System;
using DbConnect.Business.MSSQL;

namespace DbConnection.Business.MSSQL
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

        
    }
}