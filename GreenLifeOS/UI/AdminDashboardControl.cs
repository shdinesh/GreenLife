using GreenLifeOS.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AdminDashboardControl : UserControl
    {
        private readonly IAdminDashboardService adminDashboardService;

        public AdminDashboardControl()
        {
            InitializeComponent();
            adminDashboardService = new AdminDashboardService();
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

        private void loadAdminDashboardInfo()
        {
            var adminDashboardInfo = adminDashboardService.GenerateAdminDashboardStats();
            if (adminDashboardInfo != null)
            {
                lblTotalSalesToday.Text = adminDashboardInfo.TodaySalesAmount.ToString("N2");
                lblTotalOrdersToday.Text = adminDashboardInfo.TodayOrdersCount.ToString();
                lblTotalActiveOrders.Text = adminDashboardInfo.TotalActiveOrders.ToString();
                lblTotalCustomers.Text = adminDashboardInfo.TotalCustomers.ToString();
                lblTotalProducts.Text = adminDashboardInfo.TotalProducts.ToString();
                lblLowStockProducts.Text = adminDashboardInfo.TotalLowStockProducts.ToString();
            }

        }

        private void AdminDashboardControl_Load(object sender, EventArgs e)
        {
            loadAdminDashboardInfo();
        }
    }
}
