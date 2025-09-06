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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 131);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Code";
            // 
            // textBox_ProductCode
            // 
            textBox_ProductCode.Location = new Point(346, 128);
            textBox_ProductCode.Name = "textBox_ProductCode";
            textBox_ProductCode.Size = new Size(190, 23);
            textBox_ProductCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 166);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Product Name";
            // 
            // textBox_ProductName
            // 
            textBox_ProductName.Location = new Point(346, 163);
            textBox_ProductName.Name = "textBox_ProductName";
            textBox_ProductName.Size = new Size(190, 23);
            textBox_ProductName.TabIndex = 3;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(245, 203);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(53, 15);
            Quantity.TabIndex = 4;
            Quantity.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 247);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // textBox_Quantity
            // 
            textBox_Quantity.Location = new Point(346, 203);
            textBox_Quantity.Name = "textBox_Quantity";
            textBox_Quantity.Size = new Size(190, 23);
            textBox_Quantity.TabIndex = 5;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(346, 244);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(190, 23);
            textBox_Price.TabIndex = 7;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(390, 273);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Text = "FormProduct";
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
    }
}