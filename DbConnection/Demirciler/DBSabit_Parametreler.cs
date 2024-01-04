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
        public ResultStatus Update_Sabit_ParametrelerByID(Sabit_Parametreler item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<Sabit_Parametreler>(item);
            }
        }

        public ResultStatus insert_Sabit_Parametreler(Sabit_Parametreler item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<Sabit_Parametreler>(item);
            }
        }

        public ResultStatus delete_Sabit_Parametreler(Sabit_Parametreler item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<Sabit_Parametreler>(item);
            }
        }
    }
}