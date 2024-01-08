using System;
using Projects.DbConnection.Business.MSSQL;


namespace Projects.StokTakip
{
    public partial class Urun_Uretim_Detay : DevExpress.XtraEditors.XtraForm
    {
        DemircilerDB db = new DemircilerDB();

        public Urun_Uretim_Detay()
        {
            InitializeComponent();
            gridControl2.DataSource = db.GetUrun();
        }

        public int ConvertSure(string t) 
        {
            //string[] zaman = t.Split(":").ToString();
            //return (Convert.ToInt32(zaman[0]) * 3600) + (Convert.ToInt32(zaman[1]) * 60) + Convert.ToInt32(zaman[2]);
            return 0;
        }
        
    }
}