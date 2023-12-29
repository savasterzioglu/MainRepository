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
    public partial class ham_madde : DevExpress.XtraEditors.XtraForm
    {
        DemircilerDB db = new DemircilerDB();
        hmadde item = new hmadde();
        int id=0;
        public ham_madde()
        {
            InitializeComponent();
            grid_doldur();
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            List<hmadde> item2 = (gridControl1.DataSource as IEnumerable<hmadde>).ToList();

            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString());

            //textEdit1.Text = item2.Select(a => a.hmkod).Where(a=> a.id).ToString();
            textEdit1.Text = item2.Where(a => a.id == id).Select(b=> b.hmkod ).First().ToString();
            textEdit2.Text = item2.Where(a => a.id == id).Select(b => b.hmaciklama1).First().ToString();
            textEdit3.Text = item2.Where(a => a.id == id).Select(b => b.Birim == null? "N/A":b.Birim).First().ToString();
            textEdit4.Text = item2.Where(a => a.id == id).Select(b => b.satisfiyat1).First().ToString();
            textEdit5.Text = item2.Where(a => a.id == id).Select(b => b.satisfiyat2).First().ToString();
            textEdit6.Text = item2.Where(a => a.id == id).Select(b => b.hmaciklama2 == null? "N/A":b.hmaciklama2 ).First().ToString();

            comboBoxEdit1.Text  = item2.Where(a => a.id == id).Select(b => b.hmturid == null ? 0 : b.hmturid).First().ToString();
            comboBoxEdit2.Text  = item2.Where(a => a.id == id).Select(b => b.hmkaliteid == null ? 0 : b.hmkaliteid).First().ToString();
            comboBoxEdit3.Text  = item2.Where(a => a.id == id).Select(b => b.hmkaliteid == null ? 0 : b.hmkaliteid).First().ToString();
            comboBoxEdit4.Text  = item2.Where(a => a.id == id).Select(b => b.hmtedarik == null ? "N/A" : b.hmtedarik).First().ToString();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            item_Doldur();
            var result = db.insert_Hmadde(item);
            grid_doldur();
            MessageBox.Show("Kaydedildi.");
        }

        void item_Doldur()
        {
            item.hmkod = Convert.ToDouble(textEdit1.Text);
            item.hmaciklama1= textEdit2.Text;
            item.Birim = textEdit3.Text;
            item.satisfiyat1 = Convert.ToDecimal(textEdit4.Text);
            item.satisfiyat2 = Convert.ToDecimal(textEdit5.Text);
            item.hmaciklama2 = textEdit6.Text;

            item.hmturid = Convert.ToDouble(comboBoxEdit1.Text == "" ? "0":comboBoxEdit1.Text);
            item.hmkaliteid = Convert.ToDouble(comboBoxEdit2.Text == "" ? "0":comboBoxEdit2.Text);
            item.hmolcuid = Convert.ToInt32(comboBoxEdit3.Text == "" ? "0":comboBoxEdit3.Text);
            item.hmtedarik = comboBoxEdit4.Text;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                item_Doldur();
                item.id = id;
                var result = db.Update_HmaddeByID(item);
                grid_doldur();
                MessageBox.Show("Kayıt Günellendi.");
            }
            else { MessageBox.Show("Kayıt Seçilmedi."); }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                item.id = id;
                var result = db.delete_HmaddeByID(item);
                grid_doldur();
                MessageBox.Show("Kayıt Silindi.");
            }
            else { MessageBox.Show("Kayıt Seçilmedi."); }
        }

        void grid_doldur()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = db.GetHmadde();
            gridView1.BestFitColumns();
        }
    }
}