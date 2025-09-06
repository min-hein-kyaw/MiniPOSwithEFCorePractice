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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool valid = Validation();
            if(valid == false)
            {
                return;
            }
            Create();
            Clear();

        }
        private bool Validation()
        {
            if (string.IsNullOrEmpty(textBox_ProductCode.Text.Trim()))
            {
                MessageBox.Show("Product Code is Empty", "value Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBox_ProductName.Text.Trim()))
            {
                MessageBox.Show("Product Name is Empty", "value Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBox_Quantity.Text.Trim()))
            {
                MessageBox.Show("Product Code is Empty", "value Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBox_Price.Text.Trim()))
            {
                MessageBox.Show("Product Code is Empty", "value Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void Create()
        {
            AppDbContext db = new AppDbContext();
            ProductDTO productDTO = new ProductDTO()
            {


                ProductId = Guid.NewGuid().ToString(),
                ProductCode = textBox_ProductCode.Text,
                ProductName = textBox_ProductName.Text,
                Quantity = Convert.ToInt32(textBox_Quantity.Text),
                Price = Convert.ToDecimal(textBox_Price.Text),

            };
            db.Add(productDTO);
            int result = db.SaveChanges();
            string message = result > 0 ? "Save Complete" : "Save Error";
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Clear()
        {
            textBox_Price.Clear();
            textBox_ProductCode.Clear();
            textBox_Quantity.Clear();
            textBox_ProductName.Clear();
        }
    }
}
