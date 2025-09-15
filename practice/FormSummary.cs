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
    public partial class FormSummary : Form
    {
        public AppDbContext db = new AppDbContext();
        public FormSummary()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            List<SaleDTO> list = db.Sale.ToList();
            dataGridViewSale.DataSource = list;
            textBoxTotalSold.Text = db.Sale.Sum(item => item.TotalAmount).ToString();
        }

        private void dataGridViewSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTotalSold_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
