using System;

namespace GreenLifeOS.UI
{
    partial class CustomerOrderTrackingControl
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
            this.grpSearchOrder = new System.Windows.Forms.GroupBox();
            this.btnClearTracking = new System.Windows.Forms.Button();
            this.btnOrderTrack = new System.Windows.Forms.Button();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.grpSearchOrder.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearchOrder
            // 
            this.grpSearchOrder.Controls.Add(this.btnClearTracking);
            this.grpSearchOrder.Controls.Add(this.btnOrderTrack);
            this.grpSearchOrder.Controls.Add(this.txtOrderNumber);
            this.grpSearchOrder.Controls.Add(this.label5);
            this.grpSearchOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grpSearchOrder.Location = new System.Drawing.Point(3, 3);
            this.grpSearchOrder.Name = "grpSearchOrder";
            this.grpSearchOrder.Size = new System.Drawing.Size(844, 100);
            this.grpSearchOrder.TabIndex = 2;
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
            this.groupBox4.Location = new System.Drawing.Point(3, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(844, 227);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Details";
            // 
            // lblLastUpdatedVal
            // 
            this.lblLastUpdatedVal.AutoSize = true;
            this.lblLastUpdatedVal.Location = new System.Drawing.Point(682, 109);
            this.lblLastUpdatedVal.Name = "lblLastUpdatedVal";
            this.lblLastUpdatedVal.Size = new System.Drawing.Size(0, 13);
            this.lblLastUpdatedVal.TabIndex = 14;
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
            this.lblTotalAmountVal.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmountVal.TabIndex = 12;
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
            this.lblOrderDateVal.Size = new System.Drawing.Size(0, 13);
            this.lblOrderDateVal.TabIndex = 10;
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
            this.lblDeliveryAddress.Size = new System.Drawing.Size(0, 13);
            this.lblDeliveryAddress.TabIndex = 8;
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
            this.lblCustPhoneNumber.Size = new System.Drawing.Size(0, 13);
            this.lblCustPhoneNumber.TabIndex = 6;
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
            this.lblCustEmail.Size = new System.Drawing.Size(0, 13);
            this.lblCustEmail.TabIndex = 4;
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
            this.lblCustomerName.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerName.TabIndex = 2;
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
            this.groupBox3.Location = new System.Drawing.Point(3, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(847, 165);
            this.groupBox3.TabIndex = 5;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(514, 50);
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
            this.label3.Location = new System.Drawing.Point(246, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 44);
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
            this.lblDeliveredStatus.Location = new System.Drawing.Point(590, 50);
            this.lblDeliveredStatus.Name = "lblDeliveredStatus";
            this.lblDeliveredStatus.Size = new System.Drawing.Size(188, 44);
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
            this.lblPendingStatus.Size = new System.Drawing.Size(187, 44);
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
            this.lblShippedStatus.Location = new System.Drawing.Point(323, 50);
            this.lblShippedStatus.Name = "lblShippedStatus";
            this.lblShippedStatus.Size = new System.Drawing.Size(185, 44);
            this.lblShippedStatus.TabIndex = 2;
            this.lblShippedStatus.Text = "Shipped";
            this.lblShippedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerOrderTrackingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpSearchOrder);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerOrderTrackingControl";
            this.Size = new System.Drawing.Size(850, 510);
            this.Load += new System.EventHandler(this.CustomerProfileControl_Load);
            this.grpSearchOrder.ResumeLayout(false);
            this.grpSearchOrder.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchOrder;
        private System.Windows.Forms.Button btnClearTracking;
        private System.Windows.Forms.Button btnOrderTrack;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDeliveredStatus;
        private System.Windows.Forms.Label lblPendingStatus;
        private System.Windows.Forms.Label lblShippedStatus;
    }
}
