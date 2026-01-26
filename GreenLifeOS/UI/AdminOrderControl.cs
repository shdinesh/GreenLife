using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AdminOrderControl : UserControl
    {
        private readonly IOrderService orderService;

        public AdminOrderControl()
        {
            orderService = new OrderService();
            InitializeComponent();
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




        private void customerOrderTabs_TabIndexChanged(object sender, EventArgs e)
        {
            switch (customerOrderTabs.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    reloadOrders();
                    break;
            }
        }

        private void reloadOrders()
        {
            try
            {
                ordersListGV.AutoGenerateColumns = false;
                ordersListGV.DataSource = null;

                OrderStatus? selectedStatus = Enum.TryParse(cmbOrderStatus.SelectedItem?.ToString(), out OrderStatus status)? 
                    status: (OrderStatus?)null;

                var orders = selectedStatus.HasValue
                    ? orderService.GetAllOrdersByStatus(selectedStatus.Value.ToString())
                    : orderService.GetAllOrders();

                ordersListGV.DataSource = orders;
            }
            catch (Exception ex)
            {
                LogError($"Error loading orders", ex);
                ShowErrorMessage("Error", "An error occurred while loading orders. Please try again. " + ex.Message);
            }

        }
        private void reloadOrderItems(int OrderId)
        {
            try
            {
                orderLineItemsGV.AutoGenerateColumns = false;
                orderLineItemsGV.DataSource = null;
                orderLineItemsGV.DataSource = orderService.GetAllLineItems(OrderId);
            }
            catch (Exception ex)
            {
                LogError($"Error loading orders", ex);
                ShowErrorMessage("Error", "An error occurred while loading orders. Please try again. " + ex.Message);
            }

        }

        private void ShowSuccessMessage(string title, string message)
        {
            MessageBox.Show(this, message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ordersListGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ordersListGV.CurrentRow?.DataBoundItem is OrderVo orderVo)
            {
                reloadOrderItems(orderVo.OrderId);
            }

        }

        private void AdminOrderControl_Load(object sender, EventArgs e)
        {
            reloadOrders();
        }

        private void cmbOrderStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            reloadOrders();
        }
    }
}
