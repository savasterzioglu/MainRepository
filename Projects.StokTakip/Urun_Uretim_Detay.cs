using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Projects.DbConnection.Business.MSSQL;


namespace Projects.StokTakip
{
    public partial class Urun_Uretim_Detay : DevExpress.XtraEditors.XtraForm
    {
        DemircilerDB db = new DemircilerDB();

        public Urun_Uretim_Detay()
        {
            InitializeComponent();
        }
    }
}