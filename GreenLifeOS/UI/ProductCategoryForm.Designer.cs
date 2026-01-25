namespace GreenLifeOS.UI
{
    partial class ProductCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCategoryForm));
            this.btnNewProductCategory = new System.Windows.Forms.Button();
            this.productCategoryGV = new System.Windows.Forms.DataGridView();
            this.btnDeleteProductCategory = new System.Windows.Forms.Button();
            this.btnUpdateroductCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewProductCategory
            // 
            resources.ApplyResources(this.btnNewProductCategory, "btnNewProductCategory");
            this.btnNewProductCategory.Name = "btnNewProductCategory";
            this.btnNewProductCategory.UseVisualStyleBackColor = true;
            this.btnNewProductCategory.Click += new System.EventHandler(this.btnNewProductCategory_Click);
            // 
            // productCategoryGV
            // 
            this.productCategoryGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productCategoryGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.productCategoryGV, "productCategoryGV");
            this.productCategoryGV.MultiSelect = false;
            this.productCategoryGV.Name = "productCategoryGV";
            this.productCategoryGV.ReadOnly = true;
            this.productCategoryGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnDeleteProductCategory
            // 
            resources.ApplyResources(this.btnDeleteProductCategory, "btnDeleteProductCategory");
            this.btnDeleteProductCategory.Name = "btnDeleteProductCategory";
            this.btnDeleteProductCategory.UseVisualStyleBackColor = true;
            this.btnDeleteProductCategory.Click += new System.EventHandler(this.btnDeleteProductCategory_Click);
            // 
            // btnUpdateroductCategory
            // 
            resources.ApplyResources(this.btnUpdateroductCategory, "btnUpdateroductCategory");
            this.btnUpdateroductCategory.Name = "btnUpdateroductCategory";
            this.btnUpdateroductCategory.UseVisualStyleBackColor = true;
            this.btnUpdateroductCategory.Click += new System.EventHandler(this.btnUpdateroductCategory_Click);
            // 
            // ProductCategoryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateroductCategory);
            this.Controls.Add(this.btnDeleteProductCategory);
            this.Controls.Add(this.productCategoryGV);
            this.Controls.Add(this.btnNewProductCategory);
            this.Name = "ProductCategoryForm";
            this.Load += new System.EventHandler(this.ProductCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewProductCategory;
        private System.Windows.Forms.DataGridView productCategoryGV;
        private System.Windows.Forms.Button btnDeleteProductCategory;
        private System.Windows.Forms.Button btnUpdateroductCategory;
    }
}