namespace practice
{
    partial class FormSearch
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
            textBoxSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            dataGridViewSearch = new DataGridView();
            SaleId = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(266, 96);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(229, 23);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 99);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Voucher Number";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(501, 96);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.AllowUserToAddRows = false;
            dataGridViewSearch.AllowUserToDeleteRows = false;
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Columns.AddRange(new DataGridViewColumn[] { SaleId, ProductId, Quantity, Price });
            dataGridViewSearch.Location = new Point(96, 180);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.ReadOnly = true;
            dataGridViewSearch.Size = new Size(609, 237);
            dataGridViewSearch.TabIndex = 3;
            // 
            // SaleId
            // 
            SaleId.DataPropertyName = "SaleId";
            SaleId.HeaderText = "Sale Id";
            SaleId.Name = "SaleId";
            SaleId.ReadOnly = true;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "Product Id";
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
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
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSearch);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(textBoxSearch);
            Name = "FormSearch";
            Text = "FormSearch";
            Load += FormSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Label label1;
        private Button btnSearch;
        private DataGridView dataGridViewSearch;
        private DataGridViewTextBoxColumn SaleId;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
    }
}