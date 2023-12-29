using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.Business.MSSQL;


namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
             public List<urun_mamul> GetUrun_mamul()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<urun_mamul>($"Select * From urun_mamul").ToList();
            }
        }

        public ResultStatus Update_Urun_Mamul_ByID(urun_mamul item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<urun_mamul>(item);
            }
        }

        public ResultStatus insert_Urun_mamul(urun_mamul item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<urun_mamul>(item);
            }
        }

        public ResultStatus delete_Urun_Mamul(urun_mamul item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<urun_mamul>(item);
            }
        }

    }
}