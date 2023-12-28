using System.Collections.Generic;
using System.Linq;


namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<hmadde> GetHmadde()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<hmadde>($"Select * From hmadde").ToList();
            }
        }
        public ResultStatus Update_HmaddeByID(hmadde item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteUpdateByID<hmadde>(item);
            }
        }

        public ResultStatus insert_Hmadde(hmadde item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<hmadde>(item);
            }
        }

        public ResultStatus delete_HmaddeByID(hmadde item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<hmadde>(item);
            }
        }

    }
}