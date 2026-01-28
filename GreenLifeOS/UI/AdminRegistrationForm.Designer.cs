namespace GreenLifeOS.UI
{
    partial class AdminRegistrationForm
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
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnRegisterAdmin = new System.Windows.Forms.Button();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdminPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(308, 337);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(68, 23);
            this.btnClearFields.TabIndex = 20;
            this.btnClearFields.Text = "Clear";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnSupClear_Click);
            // 
            // btnRegisterAdmin
            // 
            this.btnRegisterAdmin.Location = new System.Drawing.Point(234, 337);
            this.btnRegisterAdmin.Name = "btnRegisterAdmin";
            this.btnRegisterAdmin.Size = new System.Drawing.Size(68, 23);
            this.btnRegisterAdmin.TabIndex = 19;
            this.btnRegisterAdmin.Text = "Save";
            this.btnRegisterAdmin.UseVisualStyleBackColor = true;
            this.btnRegisterAdmin.Click += new System.EventHandler(this.btnRegisterAdmin_Click);
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(120, 19);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(251, 20);
            this.txtAdminUsername.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Username";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(120, 56);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(251, 20);
            this.txtAdminPassword.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdminUsername);
            this.groupBox1.Controls.Add(this.txtAdminPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(5, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 94);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdminPhoneNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAdminEmail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAdminLastName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAdminFirstName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 217);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // txtAdminPhoneNumber
            // 
            this.txtAdminPhoneNumber.Location = new System.Drawing.Point(119, 119);
            this.txtAdminPhoneNumber.Name = "txtAdminPhoneNumber";
            this.txtAdminPhoneNumber.Size = new System.Drawing.Size(251, 20);
            this.txtAdminPhoneNumber.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Phone No.";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(119, 85);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(251, 20);
            this.txtAdminEmail.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Email";
            // 
            // txtAdminLastName
            // 
            this.txtAdminLastName.Location = new System.Drawing.Point(119, 52);
            this.txtAdminLastName.Name = "txtAdminLastName";
            this.txtAdminLastName.Size = new System.Drawing.Size(251, 20);
            this.txtAdminLastName.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Last Name";
            // 
            // txtAdminFirstName
            // 
            this.txtAdminFirstName.Location = new System.Drawing.Point(119, 19);
            this.txtAdminFirstName.Name = "txtAdminFirstName";
            this.txtAdminFirstName.Size = new System.Drawing.Size(251, 20);
            this.txtAdminFirstName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "First name";
            // 
            // AdminRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnRegisterAdmin);
            this.Name = "AdminRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnRegisterAdmin;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAdminPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminFirstName;
        private System.Windows.Forms.Label label1;
    }
}