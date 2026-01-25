namespace GreenLifeOS.UI
{
    partial class AddUpdateStockForm
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
            this.btnClearStock = new System.Windows.Forms.Button();
            this.btnSaveStock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.cmbStockProducts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStockSuppliers = new System.Windows.Forms.ComboBox();
            this.stockDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtStockPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClearStock
            // 
            this.btnClearStock.Location = new System.Drawing.Point(614, 122);
            this.btnClearStock.Name = "btnClearStock";
            this.btnClearStock.Size = new System.Drawing.Size(68, 23);
            this.btnClearStock.TabIndex = 20;
            this.btnClearStock.Text = "Clear";
            this.btnClearStock.UseVisualStyleBackColor = true;
            // 
            // btnSaveStock
            // 
            this.btnSaveStock.Location = new System.Drawing.Point(533, 122);
            this.btnSaveStock.Name = "btnSaveStock";
            this.btnSaveStock.Size = new System.Drawing.Size(68, 23);
            this.btnSaveStock.TabIndex = 19;
            this.btnSaveStock.Text = "Save";
            this.btnSaveStock.UseVisualStyleBackColor = true;
            this.btnSaveStock.Click += new System.EventHandler(this.btnSupSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(18, 69);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 21;
            this.Date.Text = "Date";
            // 
            // cmbStockProducts
            // 
            this.cmbStockProducts.FormattingEnabled = true;
            this.cmbStockProducts.Location = new System.Drawing.Point(85, 19);
            this.cmbStockProducts.Name = "cmbStockProducts";
            this.cmbStockProducts.Size = new System.Drawing.Size(251, 21);
            this.cmbStockProducts.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Supplier";
            // 
            // cmbStockSuppliers
            // 
            this.cmbStockSuppliers.FormattingEnabled = true;
            this.cmbStockSuppliers.Location = new System.Drawing.Point(431, 19);
            this.cmbStockSuppliers.Name = "cmbStockSuppliers";
            this.cmbStockSuppliers.Size = new System.Drawing.Size(251, 21);
            this.cmbStockSuppliers.TabIndex = 25;
            // 
            // stockDatePicker
            // 
            this.stockDatePicker.CustomFormat = "dd/MM/yyyy";
            this.stockDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stockDatePicker.Location = new System.Drawing.Point(85, 69);
            this.stockDatePicker.Name = "stockDatePicker";
            this.stockDatePicker.Size = new System.Drawing.Size(251, 20);
            this.stockDatePicker.TabIndex = 27;
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Location = new System.Drawing.Point(431, 66);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(91, 20);
            this.txtStockQuantity.TabIndex = 28;
            // 
            // txtStockPrice
            // 
            this.txtStockPrice.Location = new System.Drawing.Point(596, 66);
            this.txtStockPrice.Name = "txtStockPrice";
            this.txtStockPrice.Size = new System.Drawing.Size(86, 20);
            this.txtStockPrice.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Price";
            // 
            // AddUpdateStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 165);
            this.Controls.Add(this.txtStockPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.stockDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStockSuppliers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStockProducts);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.btnClearStock);
            this.Controls.Add(this.btnSaveStock);
            this.Controls.Add(this.label3);
            this.Name = "AddUpdateStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Stocks";
            this.Load += new System.EventHandler(this.AddUpdateProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearStock;
        private System.Windows.Forms.Button btnSaveStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.ComboBox cmbStockProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStockSuppliers;
        private System.Windows.Forms.DateTimePicker stockDatePicker;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TextBox txtStockPrice;
        private System.Windows.Forms.Label label2;
    }
}