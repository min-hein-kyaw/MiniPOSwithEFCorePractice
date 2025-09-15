namespace practice
{
    partial class FormSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelProduct = new Label();
            comboBoxSelect = new ComboBox();
            productDTOBindingSource = new BindingSource(components);
            textBoxPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridViewProduct = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            numericUpDown1 = new NumericUpDown();
            buttonAdd = new Button();
            textBoxTotal = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)productDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(57, 20);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(49, 15);
            labelProduct.TabIndex = 0;
            labelProduct.Text = "Product";
            labelProduct.Click += label1_Click;
            // 
            // comboBoxSelect
            // 
            comboBoxSelect.DataSource = productDTOBindingSource;
            comboBoxSelect.DisplayMember = "ProductName";
            comboBoxSelect.FormattingEnabled = true;
            comboBoxSelect.Location = new Point(57, 38);
            comboBoxSelect.Name = "comboBoxSelect";
            comboBoxSelect.Size = new Size(121, 23);
            comboBoxSelect.TabIndex = 1;
            comboBoxSelect.ValueMember = "ProductId";
            comboBoxSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // productDTOBindingSource
            // 
            productDTOBindingSource.DataSource = typeof(ProductDTO);
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(57, 96);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(121, 23);
            textBoxPrice.TabIndex = 2;
            textBoxPrice.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 78);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 3;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 143);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.AllowUserToDeleteRows = false;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, Quantity, Price });
            dataGridViewProduct.Location = new Point(269, 20);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.Size = new Size(519, 176);
            dataGridViewProduct.TabIndex = 6;
            dataGridViewProduct.CellContentClick += dataGridViewProduct_CellContentClick;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ProductId";
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Visible = false;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Product Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(57, 161);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.RightToLeft = RightToLeft.Yes;
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(57, 201);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(608, 272);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.RightToLeft = RightToLeft.Yes;
            textBoxTotal.Size = new Size(180, 23);
            textBoxTotal.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 240);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "Total";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(660, 349);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Check Out";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(textBoxTotal);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridViewProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPrice);
            Controls.Add(comboBoxSelect);
            Controls.Add(labelProduct);
            Name = "FormSales";
            Text = "FormSales";
            Load += FormSales_Load;
            ((System.ComponentModel.ISupportInitialize)productDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProduct;
        private ComboBox comboBoxSelect;
        private TextBox textBoxPrice;
        private Label label1;
        private BindingSource productDTOBindingSource;
        private Label label2;
        private DataGridView dataGridViewProduct;
        private NumericUpDown numericUpDown1;
        private Button buttonAdd;
        private TextBox textBoxTotal;
        private Label label3;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private Button btnSave;
    }
}