using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class FormSearch : Form
    {
        public AppDbContext db = new AppDbContext();
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSearch.DataSource = null;
            string voucherNo = textBoxSearch.Text;
            SaleDTO? item = db.Sale.Where(x => x.VoucherNo == voucherNo).FirstOrDefault();
            if (item is null) {

                MessageBox.Show("Cannot find the voucher number", "not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            
            }


            dataGridViewSearch.DataSource = db.SaleDetail.Where(x => x.SaleId == item.SaleId).ToList();
        }
    }
}
