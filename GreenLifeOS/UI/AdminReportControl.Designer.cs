using System;

namespace GreenLifeOS.UI
{
    partial class AdminReportControl
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
            this.customerOrderTabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveSalesReport = new System.Windows.Forms.Button();
            this.salesReportGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateToSR = new System.Windows.Forms.DateTimePicker();
            this.btnSalesReportGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFromSR = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveOrderHistoryReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStatusFilterOH = new System.Windows.Forms.ComboBox();
            this.cmbCustomerFilterOH = new System.Windows.Forms.ComboBox();
            this.dateToOH = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateOH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.dateFromOH = new System.Windows.Forms.DateTimePicker();
            this.orderHistoryGV = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrderTabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customerOrderTabs
            // 
            this.customerOrderTabs.Controls.Add(this.tabPage3);
            this.customerOrderTabs.Controls.Add(this.tabPage2);
            this.customerOrderTabs.Location = new System.Drawing.Point(0, 2);
            this.customerOrderTabs.Name = "customerOrderTabs";
            this.customerOrderTabs.SelectedIndex = 0;
            this.customerOrderTabs.Size = new System.Drawing.Size(850, 508);
            this.customerOrderTabs.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSaveSalesReport);
            this.tabPage3.Controls.Add(this.salesReportGV);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(842, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sales Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSaveSalesReport
            // 
            this.btnSaveSalesReport.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSaveSalesReport.Location = new System.Drawing.Point(721, 443);
            this.btnSaveSalesReport.Name = "btnSaveSalesReport";
            this.btnSaveSalesReport.Size = new System.Drawing.Size(112, 25);
            this.btnSaveSalesReport.TabIndex = 36;
            this.btnSaveSalesReport.Text = "Save Report";
            this.btnSaveSalesReport.UseVisualStyleBackColor = true;
            this.btnSaveSalesReport.Click += new System.EventHandler(this.btnSaveSalesReport_Click);
            // 
            // salesReportGV
            // 
            this.salesReportGV.AllowUserToAddRows = false;
            this.salesReportGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesReportGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesReportGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.salesReportGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesReportGV.Location = new System.Drawing.Point(5, 57);
            this.salesReportGV.Name = "salesReportGV";
            this.salesReportGV.ReadOnly = true;
            this.salesReportGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesReportGV.Size = new System.Drawing.Size(833, 368);
            this.salesReportGV.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FormattedOrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumberOfOrders";
            this.dataGridViewTextBoxColumn2.HeaderText = "Number of Orders";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumberOfProducts";
            this.dataGridViewTextBoxColumn3.HeaderText = "Number of Products";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalSalesAmount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Sales Amount (Rs.)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateToSR);
            this.groupBox2.Controls.Add(this.btnSalesReportGenerate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateFromSR);
            this.groupBox2.Location = new System.Drawing.Point(9, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 43);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // dateToSR
            // 
            this.dateToSR.CustomFormat = "dd/MM/yyyy";
            this.dateToSR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToSR.Location = new System.Drawing.Point(265, 14);
            this.dateToSR.Name = "dateToSR";
            this.dateToSR.Size = new System.Drawing.Size(143, 20);
            this.dateToSR.TabIndex = 31;
            // 
            // btnSalesReportGenerate
            // 
            this.btnSalesReportGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesReportGenerate.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSalesReportGenerate.Location = new System.Drawing.Point(436, 13);
            this.btnSalesReportGenerate.Name = "btnSalesReportGenerate";
            this.btnSalesReportGenerate.Size = new System.Drawing.Size(108, 23);
            this.btnSalesReportGenerate.TabIndex = 3;
            this.btnSalesReportGenerate.Text = "Generate";
            this.btnSalesReportGenerate.UseVisualStyleBackColor = false;
            this.btnSalesReportGenerate.Click += new System.EventHandler(this.btnSalesReportGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Date To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date From";
            // 
            // dateFromSR
            // 
            this.dateFromSR.CustomFormat = "dd/MM/yyyy";
            this.dateFromSR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromSR.Location = new System.Drawing.Point(64, 14);
            this.dateFromSR.Name = "dateFromSR";
            this.dateFromSR.Size = new System.Drawing.Size(130, 20);
            this.dateFromSR.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveOrderHistoryReport);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.orderHistoryGV);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order History Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrderHistoryReport
            // 
            this.btnSaveOrderHistoryReport.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSaveOrderHistoryReport.Location = new System.Drawing.Point(716, 445);
            this.btnSaveOrderHistoryReport.Name = "btnSaveOrderHistoryReport";
            this.btnSaveOrderHistoryReport.Size = new System.Drawing.Size(112, 25);
            this.btnSaveOrderHistoryReport.TabIndex = 34;
            this.btnSaveOrderHistoryReport.Text = "Save Report";
            this.btnSaveOrderHistoryReport.UseVisualStyleBackColor = true;
            this.btnSaveOrderHistoryReport.Click += new System.EventHandler(this.btnSaveOrderHistoryReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatusFilterOH);
            this.groupBox1.Controls.Add(this.cmbCustomerFilterOH);
            this.groupBox1.Controls.Add(this.dateToOH);
            this.groupBox1.Controls.Add(this.btnGenerateOH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.dateFromOH);
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 43);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // cmbStatusFilterOH
            // 
            this.cmbStatusFilterOH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbStatusFilterOH.FormattingEnabled = true;
            this.cmbStatusFilterOH.Items.AddRange(new object[] {
            "All",
            "PENDING",
            "SHIPPED",
            "DELIVERED"});
            this.cmbStatusFilterOH.Location = new System.Drawing.Point(541, 8);
            this.cmbStatusFilterOH.Name = "cmbStatusFilterOH";
            this.cmbStatusFilterOH.Size = new System.Drawing.Size(163, 21);
            this.cmbStatusFilterOH.TabIndex = 32;
            // 
            // cmbCustomerFilterOH
            // 
            this.cmbCustomerFilterOH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbCustomerFilterOH.FormattingEnabled = true;
            this.cmbCustomerFilterOH.Items.AddRange(new object[] {
            "All",
            "PENDING",
            "SHIPPED",
            "DELIVERED"});
            this.cmbCustomerFilterOH.Location = new System.Drawing.Point(338, 8);
            this.cmbCustomerFilterOH.Name = "cmbCustomerFilterOH";
            this.cmbCustomerFilterOH.Size = new System.Drawing.Size(186, 21);
            this.cmbCustomerFilterOH.TabIndex = 1;
            // 
            // dateToOH
            // 
            this.dateToOH.CustomFormat = "dd/MM/yyyy";
            this.dateToOH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToOH.Location = new System.Drawing.Point(226, 8);
            this.dateToOH.Name = "dateToOH";
            this.dateToOH.Size = new System.Drawing.Size(92, 22);
            this.dateToOH.TabIndex = 31;
            // 
            // btnGenerateOH
            // 
            this.btnGenerateOH.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateOH.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnGenerateOH.Location = new System.Drawing.Point(715, 9);
            this.btnGenerateOH.Name = "btnGenerateOH";
            this.btnGenerateOH.Size = new System.Drawing.Size(108, 23);
            this.btnGenerateOH.TabIndex = 3;
            this.btnGenerateOH.Text = "Generate";
            this.btnGenerateOH.UseVisualStyleBackColor = false;
            this.btnGenerateOH.Click += new System.EventHandler(this.btnGenerateOrderHistory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date To";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(-3, 13);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(60, 13);
            this.Date.TabIndex = 28;
            this.Date.Text = "Date From";
            // 
            // dateFromOH
            // 
            this.dateFromOH.CustomFormat = "dd/MM/yyyy";
            this.dateFromOH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromOH.Location = new System.Drawing.Point(64, 8);
            this.dateFromOH.Name = "dateFromOH";
            this.dateFromOH.Size = new System.Drawing.Size(92, 22);
            this.dateFromOH.TabIndex = 29;
            // 
            // orderHistoryGV
            // 
            this.orderHistoryGV.AllowUserToAddRows = false;
            this.orderHistoryGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderHistoryGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderHistoryGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderNumber,
            this.Customer,
            this.OrderDate,
            this.Amount,
            this.OrderStatus,
            this.LastUpdated});
            this.orderHistoryGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderHistoryGV.Location = new System.Drawing.Point(3, 60);
            this.orderHistoryGV.Name = "orderHistoryGV";
            this.orderHistoryGV.ReadOnly = true;
            this.orderHistoryGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderHistoryGV.Size = new System.Drawing.Size(833, 368);
            this.orderHistoryGV.TabIndex = 0;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "Order ID";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Visible = false;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "Order Number";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "CustomerName";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "FormattedOrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "OrderAmount";
            this.Amount.HeaderText = "Amount (Rs.)";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // OrderStatus
            // 
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.HeaderText = "Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            // 
            // LastUpdated
            // 
            this.LastUpdated.DataPropertyName = "NumberOfProducts";
            this.LastUpdated.HeaderText = "Number of Products";
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.ReadOnly = true;
            // 
            // AdminReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerOrderTabs);
            this.Name = "AdminReportControl";
            this.Size = new System.Drawing.Size(850, 510);
            this.Load += new System.EventHandler(this.CustomerProfileControl_Load);
            this.customerOrderTabs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl customerOrderTabs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGenerateOH;
        private System.Windows.Forms.ComboBox cmbCustomerFilterOH;
        private System.Windows.Forms.DataGridView orderHistoryGV;
        private System.Windows.Forms.DateTimePicker dateToOH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFromOH;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbStatusFilterOH;
        private System.Windows.Forms.Button btnSaveOrderHistoryReport;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateToSR;
        private System.Windows.Forms.Button btnSalesReportGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFromSR;
        private System.Windows.Forms.Button btnSaveSalesReport;
        private System.Windows.Forms.DataGridView salesReportGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
    }
}
