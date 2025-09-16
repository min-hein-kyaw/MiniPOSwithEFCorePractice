namespace practice
{
    partial class FormSummary
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
            dataGridViewSale = new DataGridView();
            SaleId = new DataGridViewTextBoxColumn();
            VoucherNo = new DataGridViewTextBoxColumn();
            SaleDate = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            textBoxTotalSold = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxExpense = new TextBox();
            label3 = new Label();
            textBoxNetIncome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSale
            // 
            dataGridViewSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSale.Columns.AddRange(new DataGridViewColumn[] { SaleId, VoucherNo, SaleDate, TotalAmount });
            dataGridViewSale.Location = new Point(103, 51);
            dataGridViewSale.Name = "dataGridViewSale";
            dataGridViewSale.Size = new Size(615, 355);
            dataGridViewSale.TabIndex = 0;
            dataGridViewSale.CellContentClick += dataGridViewSale_CellContentClick;
            // 
            // SaleId
            // 
            SaleId.DataPropertyName = "SaleId";
            SaleId.HeaderText = "Sale ID";
            SaleId.Name = "SaleId";
            // 
            // VoucherNo
            // 
            VoucherNo.DataPropertyName = "VoucherNo";
            VoucherNo.HeaderText = "Voucher No.";
            VoucherNo.Name = "VoucherNo";
            // 
            // SaleDate
            // 
            SaleDate.DataPropertyName = "SaleDate";
            SaleDate.HeaderText = "Sale Date";
            SaleDate.Name = "SaleDate";
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.Name = "TotalAmount";
            // 
            // textBoxTotalSold
            // 
            textBoxTotalSold.Location = new Point(601, 93);
            textBoxTotalSold.Name = "textBoxTotalSold";
            textBoxTotalSold.ReadOnly = true;
            textBoxTotalSold.RightToLeft = RightToLeft.Yes;
            textBoxTotalSold.Size = new Size(100, 23);
            textBoxTotalSold.TabIndex = 1;
            textBoxTotalSold.TextChanged += textBoxTotalSold_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 63);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Income";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 143);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Expense";
            // 
            // textBoxExpense
            // 
            textBoxExpense.Location = new Point(601, 170);
            textBoxExpense.Name = "textBoxExpense";
            textBoxExpense.ReadOnly = true;
            textBoxExpense.RightToLeft = RightToLeft.Yes;
            textBoxExpense.Size = new Size(100, 23);
            textBoxExpense.TabIndex = 4;
            textBoxExpense.TextChanged += textBoxExpense_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 233);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Net Income";
            // 
            // textBoxNetIncome
            // 
            textBoxNetIncome.Location = new Point(601, 261);
            textBoxNetIncome.Name = "textBoxNetIncome";
            textBoxNetIncome.Size = new Size(100, 23);
            textBoxNetIncome.TabIndex = 6;
            // 
            // FormSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxNetIncome);
            Controls.Add(label3);
            Controls.Add(textBoxExpense);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTotalSold);
            Controls.Add(dataGridViewSale);
            Name = "FormSummary";
            Text = "FormSummary";
            Load += FormSummary_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSale;
        private DataGridViewTextBoxColumn SaleId;
        private DataGridViewTextBoxColumn VoucherNo;
        private DataGridViewTextBoxColumn SaleDate;
        private DataGridViewTextBoxColumn TotalAmount;
        private TextBox textBoxTotalSold;
        private Label label1;
        private Label label2;
        private TextBox textBoxExpense;
        private Label label3;
        private TextBox textBoxNetIncome;
    }
}