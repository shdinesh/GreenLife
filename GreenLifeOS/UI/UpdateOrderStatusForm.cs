using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class UpdateOrderStatusForm : Form
    {
        private readonly IOrderService orderService;
        private readonly OrderVo editableOrder = null;

        public UpdateOrderStatusForm(OrderVo editableOrder)
        {
            InitializeComponent();
            this.editableOrder = editableOrder;
            orderService = new OrderService();
        }

        public UpdateOrderStatusForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void btnUpdateOrderStatus_Click(object sender, System.EventArgs e)
        {
            string status = cmbOrderStatus.SelectedItem.ToString();
            UpdateOrderStatus(status);
            this.Close();

        }

        private void UpdateOrderStatusForm_Load(object sender, System.EventArgs e)
        {
            if (editableOrder != null)
            {
                lblOrderNumber.Text = editableOrder.OrderNumber;

                cmbOrderStatus.SelectedItem = editableOrder.Status.ToString();

            }
        }

        private void UpdateOrderStatus(String status)
        {
            try
            {
                editableOrder.Status = status;
                orderService.UpdateOrderStatus(editableOrder);
                ShowSuccessMessage("Success", "Order status updated successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while updating the Order status. Please try again. " + ex.Message);
            }
        }

        private void ShowErrorMessage(string title, string message)
        {
            MessageBox.Show(this, message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage(string title, string message)
        {
            MessageBox.Show(this, message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogError(string message, Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"{message}: {ex.Message}");
        }

    }


}
