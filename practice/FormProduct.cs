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
        public string? _productId;
        public AppDbContext db = new AppDbContext();
        public FormProduct()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }



        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool valid = Validation();
            if (valid == false)
            {
                return;
            }
            Create();
            Clear();
            Read();

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
            _productId = null;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            Read();
        }
        private void Read()
        {
            dgvTable.DataSource = db.Products.Where(item => item.DeleteFlag == false).ToList();
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                btnUpdate.Visible = true;
                _productId = dgvTable.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                ProductDTO? currentProduct = db.Products.Where(item => item.ProductId == _productId).FirstOrDefault();
                if(currentProduct == null)
                {
                    MessageBox.Show("Product doesn't exist");
                }
                textBox_ProductCode.Text = currentProduct.ProductCode;
                textBox_ProductName.Text = currentProduct.ProductName;
                textBox_Price.Text = currentProduct.Price.ToString();
                textBox_Quantity.Text = currentProduct.Quantity.ToString();
            }

            else if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                DataGridViewRow selectedRow = dgvTable.Rows[e.RowIndex];
                _productId = selectedRow.Cells["ProductId"].Value.ToString();
                Delete();
                Read();


            }
        }

        public void Delete()
        {
            ProductDTO? deletedProduct = db.Products.Where(item => item.ProductId == _productId).FirstOrDefault();
            if (deletedProduct == null)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to delete this?", "Confirmation Messge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            deletedProduct.DeleteFlag = true;
            db.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to update?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {

                return;
            }
            Update();
            Read();
            Clear();
        }
        public new void Update()
        {
            ProductDTO? editEmployee = db.Products.Where(item => item.ProductId == _productId).FirstOrDefault();
            if (editEmployee != null)
            {

                editEmployee.ProductName = textBox_ProductName.Text;
                editEmployee.ProductCode = textBox_ProductCode.Text;
                editEmployee.Price = Convert.ToDecimal(textBox_Price.Text);
                editEmployee.Quantity = Convert.ToInt32(textBox_Quantity.Text);
                db.SaveChanges();
                MessageBox.Show("Update Complete", "Success Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate.Visible = false;


            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Read();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
