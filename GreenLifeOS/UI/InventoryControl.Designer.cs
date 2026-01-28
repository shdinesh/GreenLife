using GreenLifeOS.Utils;

namespace GreenLifeOS.UI
{
    partial class InventoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inventoryTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.cmbProductCategories = new System.Windows.Forms.ComboBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.productsGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.btnAddNewStock = new System.Windows.Forms.Button();
            this.stocksGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdateProductCategory = new System.Windows.Forms.Button();
            this.btnDeleteProductCategory = new System.Windows.Forms.Button();
            this.productCategoryGV = new System.Windows.Forms.DataGridView();
            this.btnNewProductCategory = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.suppliersGV = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.inventoryTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryGV)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryTabs
            // 
            this.inventoryTabs.Controls.Add(this.tabPage1);
            this.inventoryTabs.Controls.Add(this.tabPage2);
            this.inventoryTabs.Controls.Add(this.tabPage3);
            this.inventoryTabs.Controls.Add(this.tabPage4);
            this.inventoryTabs.Location = new System.Drawing.Point(0, 0);
            this.inventoryTabs.Name = "inventoryTabs";
            this.inventoryTabs.SelectedIndex = 0;
            this.inventoryTabs.Size = new System.Drawing.Size(847, 510);
            this.inventoryTabs.TabIndex = 0;
            this.inventoryTabs.SelectedIndexChanged += new System.EventHandler(this.inventoryTabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMaxPrice);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMinPrice);
            this.tabPage1.Controls.Add(this.txtSearchProduct);
            this.tabPage1.Controls.Add(this.cmbProductCategories);
            this.tabPage1.Controls.Add(this.btnUpdateProduct);
            this.tabPage1.Controls.Add(this.btnDeleteProduct);
            this.tabPage1.Controls.Add(this.productsGV);
            this.tabPage1.Controls.Add(this.btnNewProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(623, 15);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(104, 20);
            this.txtMaxPrice.TabIndex = 29;
            this.txtMaxPrice.TextChanged += new System.EventHandler(this.txtMaxPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(451, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Price";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(491, 15);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(110, 20);
            this.txtMinPrice.TabIndex = 27;
            this.txtMinPrice.TextChanged += new System.EventHandler(this.txtMinPrice_TextChanged);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(134, 15);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(283, 20);
            this.txtSearchProduct.TabIndex = 26;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // cmbProductCategories
            // 
            this.cmbProductCategories.FormattingEnabled = true;
            this.cmbProductCategories.ItemHeight = 13;
            this.cmbProductCategories.Location = new System.Drawing.Point(7, 14);
            this.cmbProductCategories.Name = "cmbProductCategories";
            this.cmbProductCategories.Size = new System.Drawing.Size(121, 21);
            this.cmbProductCategories.TabIndex = 25;
            this.cmbProductCategories.SelectedValueChanged += new System.EventHandler(this.cmbProductCategories_SelectedValueChanged);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateProduct.Location = new System.Drawing.Point(688, 447);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(68, 23);
            this.btnUpdateProduct.TabIndex = 24;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteProduct.Location = new System.Drawing.Point(762, 447);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(68, 23);
            this.btnDeleteProduct.TabIndex = 23;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // productsGV
            // 
            this.productsGV.AllowUserToAddRows = false;
            this.productsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CategoryId,
            this.PName,
            this.Code,
            this.SellingPrice,
            this.Category,
            this.Description,
            this.AvailableStock});
            this.productsGV.Location = new System.Drawing.Point(3, 49);
            this.productsGV.MultiSelect = false;
            this.productsGV.Name = "productsGV";
            this.productsGV.ReadOnly = true;
            this.productsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGV.Size = new System.Drawing.Size(836, 385);
            this.productsGV.TabIndex = 22;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Visible = false;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // AvailableStock
            // 
            this.AvailableStock.DataPropertyName = "AvailableStock";
            this.AvailableStock.HeaderText = "Available Stock";
            this.AvailableStock.Name = "AvailableStock";
            this.AvailableStock.ReadOnly = true;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewProduct.Location = new System.Drawing.Point(614, 447);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(68, 23);
            this.btnNewProduct.TabIndex = 21;
            this.btnNewProduct.Text = "New";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateStock);
            this.tabPage2.Controls.Add(this.btnDeleteStock);
            this.tabPage2.Controls.Add(this.btnAddNewStock);
            this.tabPage2.Controls.Add(this.stocksGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stocks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateStock.Location = new System.Drawing.Point(680, 447);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(68, 23);
            this.btnUpdateStock.TabIndex = 35;
            this.btnUpdateStock.Text = "Update";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteStock.Location = new System.Drawing.Point(754, 447);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(68, 23);
            this.btnDeleteStock.TabIndex = 34;
            this.btnDeleteStock.Text = "Delete";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // btnAddNewStock
            // 
            this.btnAddNewStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddNewStock.Location = new System.Drawing.Point(606, 447);
            this.btnAddNewStock.Name = "btnAddNewStock";
            this.btnAddNewStock.Size = new System.Drawing.Size(68, 23);
            this.btnAddNewStock.TabIndex = 33;
            this.btnAddNewStock.Text = "New";
            this.btnAddNewStock.UseVisualStyleBackColor = true;
            this.btnAddNewStock.Click += new System.EventHandler(this.btnAddNewStock_Click);
            // 
            // stocksGV
            // 
            this.stocksGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stocksGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Product,
            this.Quantity,
            this.Supplier,
            this.Date,
            this.Price});
            this.stocksGV.Location = new System.Drawing.Point(1, 6);
            this.stocksGV.MultiSelect = false;
            this.stocksGV.Name = "stocksGV";
            this.stocksGV.ReadOnly = true;
            this.stocksGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stocksGV.Size = new System.Drawing.Size(836, 429);
            this.stocksGV.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUpdateProductCategory);
            this.tabPage3.Controls.Add(this.btnDeleteProductCategory);
            this.tabPage3.Controls.Add(this.productCategoryGV);
            this.tabPage3.Controls.Add(this.btnNewProductCategory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(839, 484);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Categories";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProductCategory
            // 
            this.btnUpdateProductCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateProductCategory.Location = new System.Drawing.Point(688, 447);
            this.btnUpdateProductCategory.Name = "btnUpdateProductCategory";
            this.btnUpdateProductCategory.Size = new System.Drawing.Size(68, 23);
            this.btnUpdateProductCategory.TabIndex = 20;
            this.btnUpdateProductCategory.Text = "Update";
            this.btnUpdateProductCategory.UseVisualStyleBackColor = true;
            this.btnUpdateProductCategory.Click += new System.EventHandler(this.btnUpdateProductCategory_Click);
            // 
            // btnDeleteProductCategory
            // 
            this.btnDeleteProductCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteProductCategory.Location = new System.Drawing.Point(762, 447);
            this.btnDeleteProductCategory.Name = "btnDeleteProductCategory";
            this.btnDeleteProductCategory.Size = new System.Drawing.Size(68, 23);
            this.btnDeleteProductCategory.TabIndex = 19;
            this.btnDeleteProductCategory.Text = "Delete";
            this.btnDeleteProductCategory.UseVisualStyleBackColor = true;
            this.btnDeleteProductCategory.Click += new System.EventHandler(this.btnDeleteProductCategory_Click);
            // 
            // productCategoryGV
            // 
            this.productCategoryGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productCategoryGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCategoryGV.Location = new System.Drawing.Point(3, 15);
            this.productCategoryGV.MultiSelect = false;
            this.productCategoryGV.Name = "productCategoryGV";
            this.productCategoryGV.ReadOnly = true;
            this.productCategoryGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productCategoryGV.Size = new System.Drawing.Size(836, 419);
            this.productCategoryGV.TabIndex = 18;
            // 
            // btnNewProductCategory
            // 
            this.btnNewProductCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewProductCategory.Location = new System.Drawing.Point(614, 447);
            this.btnNewProductCategory.Name = "btnNewProductCategory";
            this.btnNewProductCategory.Size = new System.Drawing.Size(68, 23);
            this.btnNewProductCategory.TabIndex = 17;
            this.btnNewProductCategory.Text = "New";
            this.btnNewProductCategory.UseVisualStyleBackColor = true;
            this.btnNewProductCategory.Click += new System.EventHandler(this.btnNewProductCategory_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnUpdateSupplier);
            this.tabPage4.Controls.Add(this.btnDeleteSupplier);
            this.tabPage4.Controls.Add(this.suppliersGV);
            this.tabPage4.Controls.Add(this.btnNewSupplier);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(839, 484);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Suppliers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(688, 448);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(68, 23);
            this.btnUpdateSupplier.TabIndex = 16;
            this.btnUpdateSupplier.Text = "Update";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(762, 448);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(68, 23);
            this.btnDeleteSupplier.TabIndex = 15;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // suppliersGV
            // 
            this.suppliersGV.AllowUserToAddRows = false;
            this.suppliersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupplierName,
            this.SupplierAddress,
            this.SupplierEmail,
            this.PhoneNo});
            this.suppliersGV.Location = new System.Drawing.Point(3, 16);
            this.suppliersGV.MultiSelect = false;
            this.suppliersGV.Name = "suppliersGV";
            this.suppliersGV.ReadOnly = true;
            this.suppliersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliersGV.Size = new System.Drawing.Size(836, 419);
            this.suppliersGV.TabIndex = 14;
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "Id";
            this.SupplierId.HeaderText = "Supplier ID";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "Name";
            this.SupplierName.HeaderText = "Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.DataPropertyName = "Address";
            this.SupplierAddress.HeaderText = "Address";
            this.SupplierAddress.Name = "SupplierAddress";
            this.SupplierAddress.ReadOnly = true;
            // 
            // SupplierEmail
            // 
            this.SupplierEmail.DataPropertyName = "Email";
            this.SupplierEmail.HeaderText = "Email";
            this.SupplierEmail.Name = "SupplierEmail";
            this.SupplierEmail.ReadOnly = true;
            // 
            // PhoneNo
            // 
            this.PhoneNo.DataPropertyName = "Phone";
            this.PhoneNo.HeaderText = "Phone Number";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewSupplier.Location = new System.Drawing.Point(614, 448);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(68, 23);
            this.btnNewSupplier.TabIndex = 13;
            this.btnNewSupplier.Text = "New";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inventoryTabs);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(850, 510);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            this.inventoryTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stocksGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryGV)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl inventoryTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.DataGridView suppliersGV;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.Button btnUpdateProductCategory;
        private System.Windows.Forms.Button btnDeleteProductCategory;
        private System.Windows.Forms.DataGridView productCategoryGV;
        private System.Windows.Forms.Button btnNewProductCategory;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridView productsGV;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.ComboBox cmbProductCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.DataGridView stocksGV;
        private System.Windows.Forms.Button btnAddNewStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
    }
}
