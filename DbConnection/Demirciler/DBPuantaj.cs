using System.Collections.Generic;
using System.Linq;
using Projects.DbConnection.Business.MSSQL;


namespace Projects.DbConnection.Business.MSSQL
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

        public ResultStatus Update_Puantaj(Puantaj item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdate<Puantaj>(item);
            }
        }

        public ResultStatus insert_Puantaj(Puantaj item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<Puantaj>(item);
            }
        }

        public ResultStatus delete_Puantaj(Puantaj item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<Puantaj>(item);
            }
        }

    }
}