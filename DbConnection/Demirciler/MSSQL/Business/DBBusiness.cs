namespace DbConnection.Business.MSSQL
{
    public partial class DemircilerDB
    {
        public DemircilerDB(string sirket = "Demirciler")
        {
            //ConnectionString = "Data Source=192.168.4.200;Initial Catalog=" + sirket + ";user=sa;pwd=Etasql1";
            ///ConnectionString = "Data Source=.;Initial Catalog=BLOG;user=sa;pwd=1475";

              ConnectionString = @"Data Source=DESKTOP-R4UC6PQ;Initial Catalog=Demirciler;User ID=sa;Password=2611";
            //  ConnectionString = "Data Source=.;Initial Catalog=" + sirket + ";user=sa;pwd=1475";
        }

        public Database GetDB()
        {
            return new Database(ConnectionString);
        }

        public string ConnectionString { get; private set; }
    }
}