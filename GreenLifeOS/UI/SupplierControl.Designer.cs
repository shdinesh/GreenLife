namespace GreenLifeOS.UI
{
    partial class SupplierControl
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
            this.btnUpdateSup = new System.Windows.Forms.Button();
            this.btnSupDelete = new System.Windows.Forms.Button();
            this.suppliersGV = new System.Windows.Forms.DataGridView();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateSup
            // 
            this.btnUpdateSup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateSup.Location = new System.Drawing.Point(693, 469);
            this.btnUpdateSup.Name = "btnUpdateSup";
            this.btnUpdateSup.Size = new System.Drawing.Size(68, 23);
            this.btnUpdateSup.TabIndex = 16;
            this.btnUpdateSup.Text = "Update";
            this.btnUpdateSup.UseVisualStyleBackColor = true;
            this.btnUpdateSup.Click += new System.EventHandler(this.btnUpdateSup_Click);
            // 
            // btnSupDelete
            // 
            this.btnSupDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupDelete.Location = new System.Drawing.Point(767, 469);
            this.btnSupDelete.Name = "btnSupDelete";
            this.btnSupDelete.Size = new System.Drawing.Size(68, 23);
            this.btnSupDelete.TabIndex = 15;
            this.btnSupDelete.Text = "Delete";
            this.btnSupDelete.UseVisualStyleBackColor = true;
            this.btnSupDelete.Click += new System.EventHandler(this.btnSupDelete_Click);
            // 
            // suppliersGV
            // 
            this.suppliersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersGV.Location = new System.Drawing.Point(26, 28);
            this.suppliersGV.MultiSelect = false;
            this.suppliersGV.Name = "suppliersGV";
            this.suppliersGV.ReadOnly = true;
            this.suppliersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliersGV.Size = new System.Drawing.Size(802, 420);
            this.suppliersGV.TabIndex = 14;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewSupplier.Location = new System.Drawing.Point(619, 469);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(68, 23);
            this.btnNewSupplier.TabIndex = 13;
            this.btnNewSupplier.Text = "New";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // SupplierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateSup);
            this.Controls.Add(this.btnSupDelete);
            this.Controls.Add(this.suppliersGV);
            this.Controls.Add(this.btnNewSupplier);
            this.Name = "SupplierControl";
            this.Size = new System.Drawing.Size(850, 510);
            this.Load += new System.EventHandler(this.SupplierControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateSup;
        private System.Windows.Forms.Button btnSupDelete;
        private System.Windows.Forms.DataGridView suppliersGV;
        private System.Windows.Forms.Button btnNewSupplier;
    }
}
