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
using System.Globalization;

namespace Demirciler
{
    public partial class Puantaj_islemleri : DevExpress.XtraEditors.XtraForm
    {
        public Puantaj_islemleri()
        {
            InitializeComponent();

            dtpicker.EditValue= DateTime.Now;

            int is_gunu,h_sonu=0;
            //isgunu.Text = Day(DateTime.Now.Year,);
            is_gunu = DateTime.DaysInMonth(2023,12);
            isgunu.EditValue = is_gunu;
            
            for (int i=1; i<= is_gunu; i++)
            {
                if(new DateTime(2023,12,i).DayOfWeek.ToString()=="Sunday" || new DateTime(2023, 12, i).DayOfWeek.ToString() == "Saturday")
                {
                    h_sonu++;
                }
            }
          
            calisilangun.Text = h_sonu.ToString();
        }

        void gunleridoldur()
        {
        }
    }
}