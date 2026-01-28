using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class CustomerDashboard : UserControl
    {
        private readonly IOrderService orderService;
        private IProductService productService;

        public CustomerDashboard()
        {
            orderService = new OrderService();
            productService = new ProductService();
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


    }
}
