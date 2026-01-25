namespace GreenLifeOS.UI
{
    partial class SuppliersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersForm));
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.suppliersGV = new System.Windows.Forms.DataGridView();
            this.btnSupDelete = new System.Windows.Forms.Button();
            this.btnUpdateSup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewSupplier
            // 
            resources.ApplyResources(this.btnNewSupplier, "btnNewSupplier");
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.button1_Click);
            // 
            // suppliersGV
            // 
            resources.ApplyResources(this.suppliersGV, "suppliersGV");
            this.suppliersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersGV.MultiSelect = false;
            this.suppliersGV.Name = "suppliersGV";
            this.suppliersGV.ReadOnly = true;
            this.suppliersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnSupDelete
            // 
            resources.ApplyResources(this.btnSupDelete, "btnSupDelete");
            this.btnSupDelete.Name = "btnSupDelete";
            this.btnSupDelete.UseVisualStyleBackColor = true;
            this.btnSupDelete.Click += new System.EventHandler(this.btnSupDelete_Click);
            // 
            // btnUpdateSup
            // 
            resources.ApplyResources(this.btnUpdateSup, "btnUpdateSup");
            this.btnUpdateSup.Name = "btnUpdateSup";
            this.btnUpdateSup.UseVisualStyleBackColor = true;
            this.btnUpdateSup.Click += new System.EventHandler(this.btnUpdateSup_Click);
            // 
            // SuppliersForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateSup);
            this.Controls.Add(this.btnSupDelete);
            this.Controls.Add(this.suppliersGV);
            this.Controls.Add(this.btnNewSupplier);
            this.Name = "SuppliersForm";
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.DataGridView suppliersGV;
        private System.Windows.Forms.Button btnSupDelete;
        private System.Windows.Forms.Button btnUpdateSup;
    }
}