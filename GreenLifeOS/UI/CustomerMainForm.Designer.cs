namespace GreenLifeOS
{
    partial class CustomerMainForm
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
            this.btnCustomerDashBoard = new System.Windows.Forms.Button();
            this.btnCustomerOrders = new System.Windows.Forms.Button();
            this.btnCustomerProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUserLogout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomerDashBoard
            // 
            this.btnCustomerDashBoard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDashBoard.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCustomerDashBoard.Location = new System.Drawing.Point(19, 28);
            this.btnCustomerDashBoard.Name = "btnCustomerDashBoard";
            this.btnCustomerDashBoard.Size = new System.Drawing.Size(133, 37);
            this.btnCustomerDashBoard.TabIndex = 0;
            this.btnCustomerDashBoard.Text = "Dashboard";
            this.btnCustomerDashBoard.UseVisualStyleBackColor = true;
            this.btnCustomerDashBoard.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnCustomerOrders
            // 
            this.btnCustomerOrders.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerOrders.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCustomerOrders.Location = new System.Drawing.Point(19, 83);
            this.btnCustomerOrders.Name = "btnCustomerOrders";
            this.btnCustomerOrders.Size = new System.Drawing.Size(133, 37);
            this.btnCustomerOrders.TabIndex = 1;
            this.btnCustomerOrders.Text = "Orders";
            this.btnCustomerOrders.UseVisualStyleBackColor = true;
            this.btnCustomerOrders.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCustomerProfile
            // 
            this.btnCustomerProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerProfile.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCustomerProfile.Location = new System.Drawing.Point(19, 138);
            this.btnCustomerProfile.Name = "btnCustomerProfile";
            this.btnCustomerProfile.Size = new System.Drawing.Size(133, 37);
            this.btnCustomerProfile.TabIndex = 2;
            this.btnCustomerProfile.Text = "Profile";
            this.btnCustomerProfile.UseVisualStyleBackColor = true;
            this.btnCustomerProfile.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(168, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 510);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUserLogout);
            this.panel2.Controls.Add(this.btnCustomerDashBoard);
            this.panel2.Controls.Add(this.btnCustomerOrders);
            this.panel2.Controls.Add(this.btnCustomerProfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 510);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnUserLogout
            // 
            this.btnUserLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnUserLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLogout.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUserLogout.Location = new System.Drawing.Point(19, 455);
            this.btnUserLogout.Name = "btnUserLogout";
            this.btnUserLogout.Size = new System.Drawing.Size(133, 38);
            this.btnUserLogout.TabIndex = 8;
            this.btnUserLogout.Text = "Logout";
            this.btnUserLogout.UseVisualStyleBackColor = false;
            this.btnUserLogout.Click += new System.EventHandler(this.btnUserLogout_Click);
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerMainForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerMainForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerDashBoard;
        private System.Windows.Forms.Button btnCustomerOrders;
        private System.Windows.Forms.Button btnCustomerProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUserLogout;
    }
}

