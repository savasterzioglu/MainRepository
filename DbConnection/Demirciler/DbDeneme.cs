using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConnection.Business;
using DbConnection.Data.MSSQL.Business;



namespace DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public ResultStatus insertDeneme(Deneme item)
        {
            using (var db = GetDB())
            {
                return db.ExecuteInsert<Deneme>(item);
            }

        }
    }
}
