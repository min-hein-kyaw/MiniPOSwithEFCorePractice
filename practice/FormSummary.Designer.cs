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
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Total Sale";
            // 
            // FormSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}