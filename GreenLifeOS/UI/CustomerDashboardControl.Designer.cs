using System;
using System.Drawing;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    partial class CustomerDashboardControl
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
            this.roundedPanel5 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTotalDeliveredOrders = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTotalShippedOrders = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTotalPendingOrders = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTodayTotalOrders = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new GreenLifeOS.Utils.RoundedPanel();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.pnlHeader = new GreenLifeOS.Utils.RoundedPanel();
            this.pnlLogo = new GreenLifeOS.Utils.RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel5, 1, 1);
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
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.White;
            this.roundedPanel5.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel5.BorderRadius = 20;
            this.roundedPanel5.BorderSize = 1;
            this.roundedPanel5.Controls.Add(this.lblTotalDeliveredOrders);
            this.roundedPanel5.Controls.Add(this.label10);
            this.roundedPanel5.Location = new System.Drawing.Point(280, 144);
            this.roundedPanel5.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel5.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel5.TabIndex = 8;
            // 
            // lblTotalDeliveredOrders
            // 
            this.lblTotalDeliveredOrders.AutoSize = true;
            this.lblTotalDeliveredOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDeliveredOrders.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeliveredOrders.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblTotalDeliveredOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalDeliveredOrders.Location = new System.Drawing.Point(16, 33);
            this.lblTotalDeliveredOrders.Name = "lblTotalDeliveredOrders";
            this.lblTotalDeliveredOrders.Size = new System.Drawing.Size(46, 54);
            this.lblTotalDeliveredOrders.TabIndex = 1;
            this.lblTotalDeliveredOrders.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(16, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Delivered Orders";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.White;
            this.roundedPanel4.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.BorderSize = 1;
            this.roundedPanel4.Controls.Add(this.lblTotalShippedOrders);
            this.roundedPanel4.Controls.Add(this.label8);
            this.roundedPanel4.Location = new System.Drawing.Point(10, 144);
            this.roundedPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel4.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel4.TabIndex = 6;
            // 
            // lblTotalShippedOrders
            // 
            this.lblTotalShippedOrders.AutoSize = true;
            this.lblTotalShippedOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalShippedOrders.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalShippedOrders.ForeColor = System.Drawing.Color.Pink;
            this.lblTotalShippedOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalShippedOrders.Location = new System.Drawing.Point(16, 33);
            this.lblTotalShippedOrders.Name = "lblTotalShippedOrders";
            this.lblTotalShippedOrders.Size = new System.Drawing.Size(46, 54);
            this.lblTotalShippedOrders.TabIndex = 1;
            this.lblTotalShippedOrders.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(16, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Shipped Orders";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.BorderSize = 1;
            this.roundedPanel3.Controls.Add(this.lblTotalPendingOrders);
            this.roundedPanel3.Controls.Add(this.label6);
            this.roundedPanel3.Location = new System.Drawing.Point(550, 10);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel3.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel3.TabIndex = 5;
            // 
            // lblTotalPendingOrders
            // 
            this.lblTotalPendingOrders.AutoSize = true;
            this.lblTotalPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPendingOrders.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPendingOrders.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalPendingOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalPendingOrders.Location = new System.Drawing.Point(16, 33);
            this.lblTotalPendingOrders.Name = "lblTotalPendingOrders";
            this.lblTotalPendingOrders.Size = new System.Drawing.Size(46, 54);
            this.lblTotalPendingOrders.TabIndex = 1;
            this.lblTotalPendingOrders.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(16, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Pending Orders";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 1;
            this.roundedPanel2.Controls.Add(this.lblTodayTotalOrders);
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Location = new System.Drawing.Point(280, 10);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel2.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel2.TabIndex = 4;
            // 
            // lblTodayTotalOrders
            // 
            this.lblTodayTotalOrders.AutoSize = true;
            this.lblTodayTotalOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTodayTotalOrders.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTotalOrders.ForeColor = System.Drawing.Color.Gold;
            this.lblTodayTotalOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTodayTotalOrders.Location = new System.Drawing.Point(16, 33);
            this.lblTodayTotalOrders.Name = "lblTodayTotalOrders";
            this.lblTodayTotalOrders.Size = new System.Drawing.Size(46, 54);
            this.lblTodayTotalOrders.TabIndex = 1;
            this.lblTodayTotalOrders.Text = "0";
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
            this.roundedPanel1.Controls.Add(this.lblTotalOrders);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Location = new System.Drawing.Point(10, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.roundedPanel1.Size = new System.Drawing.Size(249, 114);
            this.roundedPanel1.TabIndex = 3;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalOrders.Location = new System.Drawing.Point(16, 33);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(43, 50);
            this.lblTotalOrders.TabIndex = 1;
            this.lblTotalOrders.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Orders Placed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer.Location = new System.Drawing.Point(0, 100);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(810, 15);
            this.pnlSpacer.TabIndex = 1;
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
            // CustomerDashboardControl
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlRoot);
            this.Name = "CustomerDashboardControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(850, 510);
            this.Load += new System.EventHandler(this.CustomerDashboardControl_Load);
            this.pnlRoot.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
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
        private Label lblTotalOrders;
        private Utils.RoundedPanel roundedPanel4;
        private Label lblTotalShippedOrders;
        private Label label8;
        private Utils.RoundedPanel roundedPanel3;
        private Label lblTotalPendingOrders;
        private Label label6;
        private Utils.RoundedPanel roundedPanel2;
        private Label lblTodayTotalOrders;
        private Label label4;
        private Label lblTitle;
        private Utils.RoundedPanel pnlHeader;
        private Utils.RoundedPanel pnlLogo;
        private PictureBox pictureBox1;
        private Utils.RoundedPanel roundedPanel5;
        private Label lblTotalDeliveredOrders;
        private Label label10;
    }
}
