using System.Collections.Generic;
using System.Linq;


namespace Projects.DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public List<test3> Gettest3()
        {
            using (var db = GetDB())
            {
                return db.ExecuteReader<test3>($"Select * From test3").ToList();
            }
        }
        
        public ResultStatus Update_test3(test3 item)
        {
            using (var db = GetDB())
            {
                //identitiy sütunu olan tablolar için bu şekilde kullan
                return db.ExecuteUpdateByID<test3>(item);
            }
        }

        public ResultStatus insert_test3(test3 item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<test3>(item);
            }
        }

        public ResultStatus delete_test3(test3 item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteDelete<test3>(item);
            }
        }

    }
}