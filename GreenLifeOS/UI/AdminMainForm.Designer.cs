namespace GreenLifeOS
{
    partial class AdminMainForm
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
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.btnAdminUsers = new System.Windows.Forms.Button();
            this.panelRightControl = new System.Windows.Forms.Panel();
            this.btnAdminInventory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUserLogout = new System.Windows.Forms.Button();
            this.btnAdminOrders = new System.Windows.Forms.Button();
            this.btnAdminReports = new System.Windows.Forms.Button();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDashboard.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAdminDashboard.Location = new System.Drawing.Point(19, 28);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(133, 37);
            this.btnAdminDashboard.TabIndex = 0;
            this.btnAdminDashboard.Text = "Dashboard";
            this.btnAdminDashboard.UseVisualStyleBackColor = true;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnAdminUsers
            // 
            this.btnAdminUsers.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAdminUsers.Location = new System.Drawing.Point(19, 193);
            this.btnAdminUsers.Name = "btnAdminUsers";
            this.btnAdminUsers.Size = new System.Drawing.Size(133, 38);
            this.btnAdminUsers.TabIndex = 2;
            this.btnAdminUsers.Text = "Users";
            this.btnAdminUsers.UseVisualStyleBackColor = true;
            this.btnAdminUsers.Click += new System.EventHandler(this.btnAdminUsers_Click);
            // 
            // panelRightControl
            // 
            this.panelRightControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightControl.Location = new System.Drawing.Point(170, 0);
            this.panelRightControl.Name = "panelRightControl";
            this.panelRightControl.Size = new System.Drawing.Size(867, 510);
            this.panelRightControl.TabIndex = 3;
            this.panelRightControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelRightControl.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // btnAdminInventory
            // 
            this.btnAdminInventory.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminInventory.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAdminInventory.Location = new System.Drawing.Point(19, 138);
            this.btnAdminInventory.Name = "btnAdminInventory";
            this.btnAdminInventory.Size = new System.Drawing.Size(133, 38);
            this.btnAdminInventory.TabIndex = 4;
            this.btnAdminInventory.Text = "Inventory";
            this.btnAdminInventory.UseVisualStyleBackColor = true;
            this.btnAdminInventory.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdminProfile);
            this.panel2.Controls.Add(this.btnUserLogout);
            this.panel2.Controls.Add(this.btnAdminOrders);
            this.panel2.Controls.Add(this.btnAdminReports);
            this.panel2.Controls.Add(this.btnAdminDashboard);
            this.panel2.Controls.Add(this.btnAdminInventory);
            this.panel2.Controls.Add(this.btnAdminUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 510);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnUserLogout
            // 
            this.btnUserLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnUserLogout.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLogout.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUserLogout.Location = new System.Drawing.Point(19, 460);
            this.btnUserLogout.Name = "btnUserLogout";
            this.btnUserLogout.Size = new System.Drawing.Size(133, 38);
            this.btnUserLogout.TabIndex = 7;
            this.btnUserLogout.Text = "Logout";
            this.btnUserLogout.UseVisualStyleBackColor = false;
            // 
            // btnAdminOrders
            // 
            this.btnAdminOrders.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminOrders.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAdminOrders.Location = new System.Drawing.Point(19, 81);
            this.btnAdminOrders.Name = "btnAdminOrders";
            this.btnAdminOrders.Size = new System.Drawing.Size(133, 38);
            this.btnAdminOrders.TabIndex = 6;
            this.btnAdminOrders.Text = "Orders";
            this.btnAdminOrders.UseVisualStyleBackColor = true;
            this.btnAdminOrders.Click += new System.EventHandler(this.btnAdminOrders_Click);
            // 
            // btnAdminReports
            // 
            this.btnAdminReports.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminReports.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAdminReports.Location = new System.Drawing.Point(19, 248);
            this.btnAdminReports.Name = "btnAdminReports";
            this.btnAdminReports.Size = new System.Drawing.Size(133, 38);
            this.btnAdminReports.TabIndex = 5;
            this.btnAdminReports.Text = "Reports";
            this.btnAdminReports.UseVisualStyleBackColor = true;
            this.btnAdminReports.Click += new System.EventHandler(this.btnAdminReports_Click);
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminProfile.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAdminProfile.Location = new System.Drawing.Point(19, 305);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(133, 38);
            this.btnAdminProfile.TabIndex = 8;
            this.btnAdminProfile.Text = "Profile";
            this.btnAdminProfile.UseVisualStyleBackColor = true;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRightControl);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Button btnAdminUsers;
        private System.Windows.Forms.Panel panelRightControl;
        private System.Windows.Forms.Button btnAdminInventory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdminReports;
        private System.Windows.Forms.Button btnAdminOrders;
        private System.Windows.Forms.Button btnUserLogout;
        private System.Windows.Forms.Button btnAdminProfile;
    }
}

