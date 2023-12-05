using System.Collections.Generic;
using System.Linq;
using DbConnection.Business;
using DbConnection.Data.MSSQL.Business;
using System;

	
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