using System;
using System.Drawing;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    partial class AdminDashboardControl
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
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.roundedPanel6 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblLowStockProducts = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.roundedPanelProducts = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTotalActiveOrders = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTotalOrdersToday = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTotalSalesToday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new GreenLifeOS.Utils.RoundedPanel();
            this.pnlLogo = new GreenLifeOS.Utils.RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundedPanel6.SuspendLayout();
            this.roundedPanelProducts.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoot.Controls.Add(this.tableLayoutPanel1);
            this.pnlRoot.Controls.Add(this.pnlSpacer);
            this.pnlRoot.Controls.Add(this.pnlHeader);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(20, 20);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Size = new System.Drawing.Size(810, 470);
            this.pnlRoot.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanelProducts, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 268);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer.Location = new System.Drawing.Point(0, 100);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(810, 15);
            this.pnlSpacer.TabIndex = 1;
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.Color.White;
            this.roundedPanel6.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel6.BorderRadius = 20;
            this.roundedPanel6.BorderSize = 1;
            this.roundedPanel6.Controls.Add(this.lblLowStockProducts);
            this.roundedPanel6.Controls.Add(this.label12);
            this.roundedPanel6.Location = new System.Drawing.Point(550, 144);
            this.roundedPanel6.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel6.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel6.TabIndex = 8;
            // 
            // lblLowStockProducts
            // 
            this.lblLowStockProducts.AutoSize = true;
            this.lblLowStockProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowStockProducts.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockProducts.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblLowStockProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLowStockProducts.Location = new System.Drawing.Point(16, 33);
            this.lblLowStockProducts.Name = "lblLowStockProducts";
            this.lblLowStockProducts.Size = new System.Drawing.Size(46, 54);
            this.lblLowStockProducts.TabIndex = 1;
            this.lblLowStockProducts.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(16, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Low Stock Products (Below 10)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanelProducts
            // 
            this.roundedPanelProducts.BackColor = System.Drawing.Color.White;
            this.roundedPanelProducts.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanelProducts.BorderRadius = 20;
            this.roundedPanelProducts.BorderSize = 1;
            this.roundedPanelProducts.Controls.Add(this.lblTotalProducts);
            this.roundedPanelProducts.Controls.Add(this.label10);
            this.roundedPanelProducts.Location = new System.Drawing.Point(280, 144);
            this.roundedPanelProducts.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanelProducts.Name = "roundedPanelProducts";
            this.roundedPanelProducts.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanelProducts.Size = new System.Drawing.Size(249, 114);
            this.roundedPanelProducts.TabIndex = 7;
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblTotalProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalProducts.Location = new System.Drawing.Point(16, 33);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(46, 54);
            this.lblTotalProducts.TabIndex = 1;
            this.lblTotalProducts.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(16, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Registered Products";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.White;
            this.roundedPanel4.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.BorderSize = 1;
            this.roundedPanel4.Controls.Add(this.lblTotalCustomers);
            this.roundedPanel4.Controls.Add(this.label8);
            this.roundedPanel4.Location = new System.Drawing.Point(10, 144);
            this.roundedPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel4.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel4.TabIndex = 6;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.Pink;
            this.lblTotalCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalCustomers.Location = new System.Drawing.Point(16, 33);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(46, 54);
            this.lblTotalCustomers.TabIndex = 1;
            this.lblTotalCustomers.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(16, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Registered Customers";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.BorderSize = 1;
            this.roundedPanel3.Controls.Add(this.lblTotalActiveOrders);
            this.roundedPanel3.Controls.Add(this.label6);
            this.roundedPanel3.Location = new System.Drawing.Point(550, 10);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel3.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel3.TabIndex = 5;
            // 
            // lblTotalActiveOrders
            // 
            this.lblTotalActiveOrders.AutoSize = true;
            this.lblTotalActiveOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalActiveOrders.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalActiveOrders.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalActiveOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalActiveOrders.Location = new System.Drawing.Point(16, 33);
            this.lblTotalActiveOrders.Name = "lblTotalActiveOrders";
            this.lblTotalActiveOrders.Size = new System.Drawing.Size(46, 54);
            this.lblTotalActiveOrders.TabIndex = 1;
            this.lblTotalActiveOrders.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(16, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Active Orders";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 1;
            this.roundedPanel2.Controls.Add(this.lblTotalOrdersToday);
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Location = new System.Drawing.Point(280, 10);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel2.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel2.TabIndex = 4;
            // 
            // lblTotalOrdersToday
            // 
            this.lblTotalOrdersToday.AutoSize = true;
            this.lblTotalOrdersToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalOrdersToday.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrdersToday.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalOrdersToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalOrdersToday.Location = new System.Drawing.Point(16, 33);
            this.lblTotalOrdersToday.Name = "lblTotalOrdersToday";
            this.lblTotalOrdersToday.Size = new System.Drawing.Size(46, 54);
            this.lblTotalOrdersToday.TabIndex = 1;
            this.lblTotalOrdersToday.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Orders Today";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 1;
            this.roundedPanel1.Controls.Add(this.lblTotalSalesToday);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Location = new System.Drawing.Point(10, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel1.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel1.TabIndex = 3;
            // 
            // lblTotalSalesToday
            // 
            this.lblTotalSalesToday.AutoSize = true;
            this.lblTotalSalesToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalSalesToday.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesToday.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalSalesToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalSalesToday.Location = new System.Drawing.Point(16, 33);
            this.lblTotalSalesToday.Name = "lblTotalSalesToday";
            this.lblTotalSalesToday.Size = new System.Drawing.Size(95, 50);
            this.lblTotalSalesToday.TabIndex = 1;
            this.lblTotalSalesToday.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Sales Today (Rs.)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderColor = System.Drawing.Color.LightGray;
            this.pnlHeader.BorderRadius = 20;
            this.pnlHeader.BorderSize = 1;
            this.pnlHeader.Controls.Add(this.pnlLogo);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.pnlHeader.Size = new System.Drawing.Size(810, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BorderColor = System.Drawing.Color.LightGray;
            this.pnlLogo.BorderRadius = 20;
            this.pnlLogo.BorderSize = 0;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLogo.Location = new System.Drawing.Point(640, 5);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLogo.Size = new System.Drawing.Size(150, 90);
            this.pnlLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GreenLifeOS.Properties.Resources.GLOS60;
            this.pictureBox1.Location = new System.Drawing.Point(19, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTitle.Location = new System.Drawing.Point(18, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(632, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Green Life Organic Store";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminDashboardControl
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlRoot);
            this.Name = "AdminDashboardControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(850, 510);
            this.Load += new System.EventHandler(this.AdminDashboardControl_Load);
            this.pnlRoot.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            this.roundedPanelProducts.ResumeLayout(false);
            this.roundedPanelProducts.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomersValue;
        private System.Windows.Forms.Label lblSuppliersValue;
        private System.Windows.Forms.Label lblProductsValue;
        private System.Windows.Forms.Label lblActiveOrdersValue;
        private System.Windows.Forms.Label lblLowStockValue;
        private Panel pnlRoot;
        private Panel pnlSpacer;
        private TableLayoutPanel tableLayoutPanel1;
        private Utils.RoundedPanel roundedPanel1;
        private Label label1;
        private Label lblTotalSalesToday;
        private Utils.RoundedPanel roundedPanel6;
        private Label lblLowStockProducts;
        private Label label12;
        private Utils.RoundedPanel roundedPanelProducts;
        private Label lblTotalProducts;
        private Label label10;
        private Utils.RoundedPanel roundedPanel4;
        private Label lblTotalCustomers;
        private Label label8;
        private Utils.RoundedPanel roundedPanel3;
        private Label lblTotalActiveOrders;
        private Label label6;
        private Utils.RoundedPanel roundedPanel2;
        private Label lblTotalOrdersToday;
        private Label label4;
        private Label lblTitle;
        private Utils.RoundedPanel pnlHeader;
        private Utils.RoundedPanel pnlLogo;
        private PictureBox pictureBox1;
    }
}
