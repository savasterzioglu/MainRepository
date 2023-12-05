using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.Business.MSSQL;


namespace DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
             public List<Puantaj> GetPuantaj()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<Puantaj>($"Select * From Puantaj").ToList();
            }
        }
        
       
    }
}