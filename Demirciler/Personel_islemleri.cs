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
using DBConnection.Business.MSSQL;
using DBConnection.Business;

namespace Demirciler
{
    public partial class Personel_islemleri : DevExpress.XtraEditors.XtraForm
    {
        public Personel_islemleri()
        {
            InitializeComponent();

            var db = new DemircilerDB();
            gridControl1.DataSource = db.GetPersonel().ToList();

        }
    }
}