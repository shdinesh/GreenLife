using GreenLifeOS.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class CustomerOrderTrackingControl : UserControl
    {
        private readonly IOrderService orderService;

        public CustomerOrderTrackingControl()
        {
            orderService = new OrderService();
            InitializeComponent();
            lblPendingStatus.BackColor = System.Drawing.Color.LightGray;
            lblShippedStatus.BackColor = System.Drawing.Color.LightGray;
            lblDeliveredStatus.BackColor = System.Drawing.Color.LightGray;
        }


        private void ShowErrorMessage(string title, string message)
        {
            MessageBox.Show(this, message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult ShowConfirmationDialog(string title, string message, MessageBoxButtons buttons)
        {
            return MessageBox.Show(this, message, title,
                buttons, MessageBoxIcon.Question);
        }

        private void LogError(string message, Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"{message}: {ex.Message}");
        }

        private void CustomerProfileControl_Load(object sender, EventArgs e)
        {


        }

        private void btnOrderTrack_Click(object sender, EventArgs e)
        {
            try
            {
                string orderNumber = txtOrderNumber.Text;
                Order order = orderService.GetOrderByNumber(orderNumber);
                if (order != null)
                {
                    lblCustomerName.Text = order.Customer.FirstName;
                    lblCustEmail.Text = order.Customer.Email;
                    lblCustPhoneNumber.Text = order.Customer.PhoneNumber;
                    lblDeliveryAddress.Text = order.Customer.Address;

                    lblOrderDateVal.Text = order.Date.ToString("dd-MM-yyyy hh:mm:ss tt");
                    lblTotalAmountVal.Text = $"Rs. {order.Amount:#,##0.00}";
                    lblLastUpdatedVal.Text = order.LastUpdated?.ToString("dd-MM-yyyy hh:mm:ss tt");
                    OrderStatus? selectedStatus = Enum.TryParse(order.Status, out OrderStatus status) ?
                    status : (OrderStatus?)null;
                    applyStatusColors(selectedStatus);
                }
            }
            catch (KeyNotFoundException ex)
            {
                ShowErrorMessage("Error", ex.Message);
            }
            catch (Exception ex)
            {
                LogError($"Error loading orders", ex);
                ShowErrorMessage("Error", ex.Message);
            }
        }

        private void applyStatusColors(OrderStatus? orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.PENDING:
                    lblPendingStatus.BackColor = System.Drawing.Color.Khaki;
                    break;
                case OrderStatus.SHIPPED:
                    lblPendingStatus.BackColor = System.Drawing.Color.Khaki;
                    lblShippedStatus.BackColor = System.Drawing.Color.DeepSkyBlue;

                    break;
                case OrderStatus.DELIVERED:
                    lblPendingStatus.BackColor = System.Drawing.Color.Khaki;
                    lblShippedStatus.BackColor = System.Drawing.Color.DeepSkyBlue;
                    lblDeliveredStatus.BackColor = System.Drawing.Color.LimeGreen;
                    break;
            }
        }

        private void btnClearTracking_Click(object sender, EventArgs e)
        {
            txtOrderNumber.Text = string.Empty;
            lblCustomerName.Text = string.Empty;
            lblCustEmail.Text = string.Empty;
            lblCustPhoneNumber.Text = string.Empty;
            lblDeliveryAddress.Text = string.Empty;
            lblLastUpdatedVal.Text = string.Empty;
            lblOrderDateVal.Text = string.Empty;
            lblTotalAmountVal.Text = string.Empty;

            lblPendingStatus.BackColor = System.Drawing.Color.LightGray;
            lblShippedStatus.BackColor = System.Drawing.Color.LightGray;
            lblDeliveredStatus.BackColor = System.Drawing.Color.LightGray;
        }
    }
}
