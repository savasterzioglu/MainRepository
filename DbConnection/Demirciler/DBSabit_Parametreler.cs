using System.Collections.Generic;
using System.Linq;


namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
  
        public List<Sabit_Parametreler> GetSabit_Parametreler()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<Sabit_Parametreler>($"Select * From Sabit_Parametreler").ToList();
            }
        }
    }
}