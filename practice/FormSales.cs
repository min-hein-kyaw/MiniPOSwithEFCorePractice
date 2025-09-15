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
    public partial class FormSales : Form
    {
        public AppDbContext db = new AppDbContext();
        public FormSales()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBoxSelect.SelectedValue.ToString();
            ProductDTO? item = db.Products.Where(item => item.ProductId == id).FirstOrDefault();
            if (item == null)
            {
                return;
            }
            textBoxPrice.Text = item.Price.ToString();


        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            Bind();
            dataGridViewProduct.AutoGenerateColumns = false;


        }

        public void Bind()
        {
            List<ProductDTO> list = db.Products.Where(item => item.DeleteFlag == false).ToList();
            list.Insert(0, new ProductDTO
            {

                ProductId = "0",
                ProductName = "Select One"
            });
            comboBoxSelect.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBoxSelect.DataSource = list;
            comboBoxSelect.DisplayMember = "ProductName";
            comboBoxSelect.ValueMember = "ProductId";
            comboBoxSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
 
        private int createSale()
        {

            SaleDTO sale = new()
            {
                
                VoucherNo = "V" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                SaleDate = DateTime.Now,
                TotalAmount = Convert.ToDecimal(textBoxTotal.Text)


            };
            db.Sale.Add(sale);
            db.SaveChanges();
            int id = sale.SaleId;
            return id;
        }

        private List<ProductDTO> Products = new List<ProductDTO>();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string productId = comboBoxSelect.SelectedValue.ToString();
            string productName = comboBoxSelect.Text.ToString();
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            int quantity = Convert.ToInt32(numericUpDown1.Value);
            ProductDTO? item = Products.Where(item => item.ProductId == productId).FirstOrDefault();
            if (item == null)
            {
                ProductDTO product = new ProductDTO()
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price,
                    Quantity = quantity
                };
                Products.Add(product);


            }
            else
            {
                item.Quantity += quantity;
            }
            dataGridViewProduct.DataSource = null;
            dataGridViewProduct.DataSource = Products;
            textBoxTotal.Text = Products.Sum(x => x.Price * x.Quantity).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = createSale();
            CreateSaleDetail(id);
            MessageBox.Show("Check Out Completed!", "Confirmation Message", MessageBoxButtons.OK);
            clear();
            

        }

        public void clear()
        {
            textBoxTotal.Text = null;
            comboBoxSelect.SelectedIndex = 0;
            textBoxPrice.Text = null;
            numericUpDown1.Value = 0;
            dataGridViewProduct.DataSource = null;
        }
        
        public void CreateSaleDetail(int id) {

            foreach (var item in Products) {

                SaleDetailDTO detail = new SaleDetailDTO() {
                SaleId = id,
                ProductId = item.ProductId,
                Quantity = item.Quantity,
                Price=item.Price,
                
                };
                db.SaleDetail.Add(detail);
                
            
            }
            db.SaveChanges();

        }
    }
}
