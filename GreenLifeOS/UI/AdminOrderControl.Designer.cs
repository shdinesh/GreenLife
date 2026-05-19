using System;

namespace GreenLifeOS.UI
{
    partial class AdminOrderControl
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.orderLineItemsGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineItemTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeOrderStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.ordersListGV = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOrderTracking = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblLastUpdatedVal = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotalAmountVal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblOrderDateVal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCustPhoneNumber = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDeliveredStatus = new System.Windows.Forms.Label();
            this.lblPendingStatus = new System.Windows.Forms.Label();
            this.lblShippedStatus = new System.Windows.Forms.Label();
            this.grpSearchOrder = new System.Windows.Forms.GroupBox();
            this.btnClearTracking = new System.Windows.Forms.Button();
            this.btnOrderTrack = new System.Windows.Forms.Button();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerOrderTabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineItemsGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListGV)).BeginInit();
            this.tabOrderTracking.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSearchOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerOrderTabs
            // 
            this.customerOrderTabs.Controls.Add(this.tabPage2);
            this.customerOrderTabs.Controls.Add(this.tabOrderTracking);
            this.customerOrderTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerOrderTabs.Location = new System.Drawing.Point(0, 0);
            this.customerOrderTabs.Name = "customerOrderTabs";
            this.customerOrderTabs.SelectedIndex = 0;
            this.customerOrderTabs.Size = new System.Drawing.Size(850, 510);
            this.customerOrderTabs.TabIndex = 0;
            this.customerOrderTabs.SelectedIndexChanged += new System.EventHandler(this.customerOrderTabs_TabIndexChanged);
            this.customerOrderTabs.TabIndexChanged += new System.EventHandler(this.customerOrderTabs_TabIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.orderLineItemsGV);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Items";
            // 
            // orderLineItemsGV
            // 
            this.orderLineItemsGV.AllowUserToAddRows = false;
            this.orderLineItemsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderLineItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderLineItemsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductCode,
            this.ProductName,
            this.ItemSellingPrice,
            this.Quantity,
            this.Discount,
            this.LineItemTotal2});
            this.orderLineItemsGV.Location = new System.Drawing.Point(4, 19);
            this.orderLineItemsGV.Name = "orderLineItemsGV";
            this.orderLineItemsGV.ReadOnly = true;
            this.orderLineItemsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderLineItemsGV.Size = new System.Drawing.Size(828, 210);
            this.orderLineItemsGV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LineItemId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Line ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "Code";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ItemSellingPrice
            // 
            this.ItemSellingPrice.DataPropertyName = "SellingPrice";
            this.ItemSellingPrice.HeaderText = "SellingPrice (Rs.)";
            this.ItemSellingPrice.Name = "ItemSellingPrice";
            this.ItemSellingPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "PurchaseQuantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount (%)";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // LineItemTotal2
            // 
            this.LineItemTotal2.DataPropertyName = "LineItemTotal";
            this.LineItemTotal2.HeaderText = "Line ItemTotal (Rs.)";
            this.LineItemTotal2.Name = "LineItemTotal2";
            this.LineItemTotal2.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeOrderStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbOrderStatus);
            this.groupBox1.Controls.Add(this.ordersListGV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Info";
            // 
            // btnChangeOrderStatus
            // 
            this.btnChangeOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeOrderStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnChangeOrderStatus.Location = new System.Drawing.Point(720, 13);
            this.btnChangeOrderStatus.Name = "btnChangeOrderStatus";
            this.btnChangeOrderStatus.Size = new System.Drawing.Size(108, 23);
            this.btnChangeOrderStatus.TabIndex = 3;
            this.btnChangeOrderStatus.Text = "Change Status";
            this.btnChangeOrderStatus.UseVisualStyleBackColor = false;
            this.btnChangeOrderStatus.Click += new System.EventHandler(this.btnChangeOrderStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter by Order Status";
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Items.AddRange(new object[] {
            "All",
            "PENDING",
            "SHIPPED",
            "DELIVERED"});
            this.cmbOrderStatus.Location = new System.Drawing.Point(519, 15);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(186, 21);
            this.cmbOrderStatus.TabIndex = 1;
            this.cmbOrderStatus.SelectedValueChanged += new System.EventHandler(this.cmbOrderStatus_SelectedValueChanged);
            // 
            // ordersListGV
            // 
            this.ordersListGV.AllowUserToAddRows = false;
            this.ordersListGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersListGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderNumber,
            this.Customer,
            this.OrderDate,
            this.Amount,
            this.Status,
            this.LastUpdated});
            this.ordersListGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ordersListGV.Location = new System.Drawing.Point(6, 42);
            this.ordersListGV.Name = "ordersListGV";
            this.ordersListGV.ReadOnly = true;
            this.ordersListGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersListGV.Size = new System.Drawing.Size(828, 200);
            this.ordersListGV.TabIndex = 0;
            this.ordersListGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersListGV_CellClick);
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
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount (Rs.)";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // LastUpdated
            // 
            this.LastUpdated.DataPropertyName = "LastUpdated";
            this.LastUpdated.HeaderText = "Last Updated";
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.ReadOnly = true;
            // 
            // tabOrderTracking
            // 
            this.tabOrderTracking.Controls.Add(this.groupBox4);
            this.tabOrderTracking.Controls.Add(this.groupBox3);
            this.tabOrderTracking.Controls.Add(this.grpSearchOrder);
            this.tabOrderTracking.Location = new System.Drawing.Point(4, 22);
            this.tabOrderTracking.Name = "tabOrderTracking";
            this.tabOrderTracking.Size = new System.Drawing.Size(842, 484);
            this.tabOrderTracking.TabIndex = 2;
            this.tabOrderTracking.Text = "Order Tracking";
            this.tabOrderTracking.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblLastUpdatedVal);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblTotalAmountVal);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lblOrderDateVal);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lblDeliveryAddress);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lblCustPhoneNumber);
            this.groupBox4.Controls.Add(this.lbl10);
            this.groupBox4.Controls.Add(this.lblCustEmail);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lblCustomerName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupBox4.Location = new System.Drawing.Point(3, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(839, 193);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Details";
            // 
            // lblLastUpdatedVal
            // 
            this.lblLastUpdatedVal.AutoSize = true;
            this.lblLastUpdatedVal.Location = new System.Drawing.Point(682, 109);
            this.lblLastUpdatedVal.Name = "lblLastUpdatedVal";
            this.lblLastUpdatedVal.Size = new System.Drawing.Size(75, 13);
            this.lblLastUpdatedVal.TabIndex = 14;
            this.lblLastUpdatedVal.Text = "Last Updated";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(578, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Last Updated";
            // 
            // lblTotalAmountVal
            // 
            this.lblTotalAmountVal.AutoSize = true;
            this.lblTotalAmountVal.Location = new System.Drawing.Point(682, 71);
            this.lblTotalAmountVal.Name = "lblTotalAmountVal";
            this.lblTotalAmountVal.Size = new System.Drawing.Size(76, 13);
            this.lblTotalAmountVal.TabIndex = 12;
            this.lblTotalAmountVal.Text = "Total Amount";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(578, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Total Amount: ";
            // 
            // lblOrderDateVal
            // 
            this.lblOrderDateVal.AutoSize = true;
            this.lblOrderDateVal.Location = new System.Drawing.Point(682, 34);
            this.lblOrderDateVal.Name = "lblOrderDateVal";
            this.lblOrderDateVal.Size = new System.Drawing.Size(64, 13);
            this.lblOrderDateVal.TabIndex = 10;
            this.lblOrderDateVal.Text = "Order Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(578, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Order Date:";
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Location = new System.Drawing.Point(144, 149);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(48, 13);
            this.lblDeliveryAddress.TabIndex = 8;
            this.lblDeliveryAddress.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Delivery Address";
            // 
            // lblCustPhoneNumber
            // 
            this.lblCustPhoneNumber.AutoSize = true;
            this.lblCustPhoneNumber.Location = new System.Drawing.Point(143, 109);
            this.lblCustPhoneNumber.Name = "lblCustPhoneNumber";
            this.lblCustPhoneNumber.Size = new System.Drawing.Size(88, 13);
            this.lblCustPhoneNumber.TabIndex = 6;
            this.lblCustPhoneNumber.Text = "Customer Name";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(39, 109);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(87, 13);
            this.lbl10.TabIndex = 5;
            this.lbl10.Text = "Phone Number:";
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.Location = new System.Drawing.Point(144, 71);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(88, 13);
            this.lblCustEmail.TabIndex = 4;
            this.lblCustEmail.Text = "Customer Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Email:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(143, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(88, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer Name: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(4, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status Progress";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.2963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.7037F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDeliveredStatus, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPendingStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblShippedStatus, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 50, 60, 50);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 44);
            this.label7.TabIndex = 7;
            this.label7.Text = "→";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "→";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeliveredStatus
            // 
            this.lblDeliveredStatus.AutoSize = true;
            this.lblDeliveredStatus.BackColor = System.Drawing.Color.LightGray;
            this.lblDeliveredStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeliveredStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeliveredStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveredStatus.Location = new System.Drawing.Point(584, 50);
            this.lblDeliveredStatus.Name = "lblDeliveredStatus";
            this.lblDeliveredStatus.Size = new System.Drawing.Size(186, 44);
            this.lblDeliveredStatus.TabIndex = 5;
            this.lblDeliveredStatus.Text = "Delivered";
            this.lblDeliveredStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingStatus
            // 
            this.lblPendingStatus.AutoSize = true;
            this.lblPendingStatus.BackColor = System.Drawing.Color.LightGray;
            this.lblPendingStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPendingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendingStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingStatus.Location = new System.Drawing.Point(53, 50);
            this.lblPendingStatus.Name = "lblPendingStatus";
            this.lblPendingStatus.Size = new System.Drawing.Size(182, 44);
            this.lblPendingStatus.TabIndex = 3;
            this.lblPendingStatus.Text = "Pending";
            this.lblPendingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShippedStatus
            // 
            this.lblShippedStatus.AutoSize = true;
            this.lblShippedStatus.BackColor = System.Drawing.Color.LightGray;
            this.lblShippedStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShippedStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShippedStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippedStatus.Location = new System.Drawing.Point(317, 50);
            this.lblShippedStatus.Name = "lblShippedStatus";
            this.lblShippedStatus.Size = new System.Drawing.Size(185, 44);
            this.lblShippedStatus.TabIndex = 2;
            this.lblShippedStatus.Text = "Shipped";
            this.lblShippedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSearchOrder
            // 
            this.grpSearchOrder.Controls.Add(this.btnClearTracking);
            this.grpSearchOrder.Controls.Add(this.btnOrderTrack);
            this.grpSearchOrder.Controls.Add(this.txtOrderNumber);
            this.grpSearchOrder.Controls.Add(this.label5);
            this.grpSearchOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grpSearchOrder.Location = new System.Drawing.Point(4, 7);
            this.grpSearchOrder.Name = "grpSearchOrder";
            this.grpSearchOrder.Size = new System.Drawing.Size(839, 100);
            this.grpSearchOrder.TabIndex = 1;
            this.grpSearchOrder.TabStop = false;
            this.grpSearchOrder.Text = "Search Order";
            // 
            // btnClearTracking
            // 
            this.btnClearTracking.Location = new System.Drawing.Point(709, 36);
            this.btnClearTracking.Name = "btnClearTracking";
            this.btnClearTracking.Size = new System.Drawing.Size(92, 23);
            this.btnClearTracking.TabIndex = 3;
            this.btnClearTracking.Text = "Clear";
            this.btnClearTracking.UseVisualStyleBackColor = true;
            this.btnClearTracking.Click += new System.EventHandler(this.btnClearTracking_Click);
            // 
            // btnOrderTrack
            // 
            this.btnOrderTrack.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOrderTrack.Location = new System.Drawing.Point(562, 36);
            this.btnOrderTrack.Name = "btnOrderTrack";
            this.btnOrderTrack.Size = new System.Drawing.Size(141, 24);
            this.btnOrderTrack.TabIndex = 2;
            this.btnOrderTrack.Text = "Search";
            this.btnOrderTrack.UseVisualStyleBackColor = false;
            this.btnOrderTrack.Click += new System.EventHandler(this.btnOrderTrack_Click);
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(145, 37);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(398, 22);
            this.txtOrderNumber.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Order Number: ";
            // 
            // AdminOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerOrderTabs);
            this.Name = "AdminOrderControl";
            this.Size = new System.Drawing.Size(850, 510);
            this.Load += new System.EventHandler(this.AdminOrderControl_Load);
            this.customerOrderTabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderLineItemsGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListGV)).EndInit();
            this.tabOrderTracking.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpSearchOrder.ResumeLayout(false);
            this.grpSearchOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl customerOrderTabs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView orderLineItemsGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineItemTotal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private System.Windows.Forms.Button btnChangeOrderStatus;
        private System.Windows.Forms.DataGridView ordersListGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
        private System.Windows.Forms.TabPage tabOrderTracking;
        private System.Windows.Forms.GroupBox grpSearchOrder;
        private System.Windows.Forms.Button btnClearTracking;
        private System.Windows.Forms.Button btnOrderTrack;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLastUpdatedVal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotalAmountVal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblOrderDateVal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCustPhoneNumber;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblShippedStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDeliveredStatus;
        private System.Windows.Forms.Label lblPendingStatus;
        private System.Windows.Forms.Label label7;
    }
}
