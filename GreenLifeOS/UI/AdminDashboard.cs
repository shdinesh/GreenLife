using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AdminDashboard : UserControl
    {
        private readonly IOrderService orderService;
        private IProductService productService;

        public AdminDashboard()
        {
            orderService = new OrderService();
            productService = new ProductService();
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


    }
}
