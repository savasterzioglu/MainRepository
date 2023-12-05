using Projects.DbConnection.Business.MSSQL;
using System.Collections.Generic;
using System.Reflection;

namespace Projects.DBConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<SIRKET> _GetSirketler()
        {
            var res = new List<SIRKET>();
            res.Add(new SIRKET { Name = "Demirciler", Value = "Demirciler" });
            return res;
        }
        public List<Personel> GetPersonel()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<Personel>($"SELECT * FROM Personel").ToList();
            }
        }
    }
}
