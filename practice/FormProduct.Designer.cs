namespace practice
{
    partial class FormProduct
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
            label1 = new Label();
            textBox_ProductCode = new TextBox();
            label2 = new Label();
            textBox_ProductName = new TextBox();
            Quantity = new Label();
            label3 = new Label();
            textBox_Quantity = new TextBox();
            textBox_Price = new TextBox();
            btn_Add = new Button();
            dgvTable = new DataGridView();
            btnUpdate = new Button();
            btnRefresh = new Button();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            ProductID = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductQuantity = new DataGridViewTextBoxColumn();
            DeleteFlag = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 47);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Code";
            // 
            // textBox_ProductCode
            // 
            textBox_ProductCode.Location = new Point(384, 44);
            textBox_ProductCode.Name = "textBox_ProductCode";
            textBox_ProductCode.Size = new Size(190, 23);
            textBox_ProductCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 82);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Product Name";
            // 
            // textBox_ProductName
            // 
            textBox_ProductName.Location = new Point(384, 79);
            textBox_ProductName.Name = "textBox_ProductName";
            textBox_ProductName.Size = new Size(190, 23);
            textBox_ProductName.TabIndex = 3;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(283, 119);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(53, 15);
            Quantity.TabIndex = 4;
            Quantity.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 163);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // textBox_Quantity
            // 
            textBox_Quantity.Location = new Point(384, 119);
            textBox_Quantity.Name = "textBox_Quantity";
            textBox_Quantity.Size = new Size(190, 23);
            textBox_Quantity.TabIndex = 5;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(384, 160);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(190, 23);
            textBox_Price.TabIndex = 7;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(428, 189);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // dgvTable
            // 
            dgvTable.AllowUserToAddRows = false;
            dgvTable.AllowUserToDeleteRows = false;
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Columns.AddRange(new DataGridViewColumn[] { btnEdit, btnDelete, ProductID, ProductCode, ProductName, ProductPrice, ProductQuantity, DeleteFlag });
            dgvTable.Location = new Point(126, 250);
            dgvTable.Name = "dgvTable";
            dgvTable.ReadOnly = true;
            dgvTable.Size = new Size(643, 349);
            dgvTable.TabIndex = 9;
            dgvTable.CellContentClick += dgvTable_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(428, 189);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(509, 189);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(65, 23);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "";
            btnEdit.Name = "btnEdit";
            btnEdit.ReadOnly = true;
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "";
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // ProductID
            // 
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "Product ID";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            ProductID.Visible = false;
            // 
            // ProductCode
            // 
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "Product Code";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Product Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // ProductPrice
            // 
            ProductPrice.DataPropertyName = "Price";
            ProductPrice.HeaderText = "Price";
            ProductPrice.Name = "ProductPrice";
            ProductPrice.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            ProductQuantity.DataPropertyName = "Quantity";
            ProductQuantity.HeaderText = "Quantity";
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.ReadOnly = true;
            // 
            // DeleteFlag
            // 
            DeleteFlag.DataPropertyName = "DeleteFlag";
            DeleteFlag.HeaderText = "Delete Flag";
            DeleteFlag.Name = "DeleteFlag";
            DeleteFlag.ReadOnly = true;
            DeleteFlag.Visible = false;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 611);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(dgvTable);
            Controls.Add(btn_Add);
            Controls.Add(textBox_Price);
            Controls.Add(label3);
            Controls.Add(textBox_Quantity);
            Controls.Add(Quantity);
            Controls.Add(textBox_ProductName);
            Controls.Add(label2);
            Controls.Add(textBox_ProductCode);
            Controls.Add(label1);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduct";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_ProductCode;
        private Label label2;
        private TextBox textBox_ProductName;
        private Label Quantity;
        private Label label3;
        private TextBox textBox_Quantity;
        private TextBox textBox_Price;
        private Button btn_Add;
        private DataGridView dgvTable;
        private Button btnUpdate;
        private Button btnRefresh;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewTextBoxColumn DeleteFlag;
    }
}