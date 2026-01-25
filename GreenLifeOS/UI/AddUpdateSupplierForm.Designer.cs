namespace GreenLifeOS.UI
{
    partial class AddUpdateSupplierForm
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
            this.btnSupClear = new System.Windows.Forms.Button();
            this.btnSupSave = new System.Windows.Forms.Button();
            this.txtSupEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSupClear
            // 
            this.btnSupClear.Location = new System.Drawing.Point(592, 102);
            this.btnSupClear.Name = "btnSupClear";
            this.btnSupClear.Size = new System.Drawing.Size(68, 23);
            this.btnSupClear.TabIndex = 20;
            this.btnSupClear.Text = "Clear";
            this.btnSupClear.UseVisualStyleBackColor = true;
            this.btnSupClear.Click += new System.EventHandler(this.btnSupClear_Click);
            // 
            // btnSupSave
            // 
            this.btnSupSave.Location = new System.Drawing.Point(518, 102);
            this.btnSupSave.Name = "btnSupSave";
            this.btnSupSave.Size = new System.Drawing.Size(68, 23);
            this.btnSupSave.TabIndex = 19;
            this.btnSupSave.Text = "Save";
            this.btnSupSave.UseVisualStyleBackColor = true;
            this.btnSupSave.Click += new System.EventHandler(this.btnSupSave_Click);
            // 
            // txtSupEmail
            // 
            this.txtSupEmail.Location = new System.Drawing.Point(416, 62);
            this.txtSupEmail.Name = "txtSupEmail";
            this.txtSupEmail.Size = new System.Drawing.Size(244, 20);
            this.txtSupEmail.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // txtSupPhone
            // 
            this.txtSupPhone.Location = new System.Drawing.Point(69, 59);
            this.txtSupPhone.Name = "txtSupPhone";
            this.txtSupPhone.Size = new System.Drawing.Size(242, 20);
            this.txtSupPhone.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone";
            // 
            // txtSupAddress
            // 
            this.txtSupAddress.Location = new System.Drawing.Point(416, 21);
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.Size = new System.Drawing.Size(244, 20);
            this.txtSupAddress.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Address";
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(69, 21);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(242, 20);
            this.txtSupName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // AddUpdateSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 141);
            this.Controls.Add(this.btnSupClear);
            this.Controls.Add(this.btnSupSave);
            this.Controls.Add(this.txtSupEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSupPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.label1);
            this.Name = "AddUpdateSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add-Update Supplier";
            this.Load += new System.EventHandler(this.AddUpdateSupplierForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupClear;
        private System.Windows.Forms.Button btnSupSave;
        private System.Windows.Forms.TextBox txtSupEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label label1;
    }
}