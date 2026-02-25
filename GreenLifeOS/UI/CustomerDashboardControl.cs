using GreenLifeOS.Service;
using GreenLifeOS.Session;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class CustomerDashboardControl : UserControl
    {
        private readonly ICustomerDashboardService customerDashboardService;
        private readonly IUserService userService;


        public CustomerDashboardControl()
        {
            InitializeComponent();
            userService = new UserService();
            customerDashboardService = new CustomerDashboardService();

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

        private void CustomerDashboardControl_Load(object sender, EventArgs e)
        {
            loadCustomerDashboardInfo();
        }

        private void loadCustomerDashboardInfo()
        {
            if (AppSession.CurrentUser != null)
            {
                Customer customer = userService.GetUserById(AppSession.CurrentUser.UserId).Customers.FirstOrDefault<Customer>() ;
                if (customer != null)
                {
                    var customerDashboardInfo = customerDashboardService.GenerateCustomerboardStats(customer.Id);
                    if (customerDashboardInfo != null)
                    {
                        lblTotalOrders.Text = customerDashboardInfo.NumberOfOrdersPlaced.ToString();
                        lblTodayTotalOrders.Text = customerDashboardInfo.NumberOfOrdersPlacedToday.ToString();
                        lblTotalPendingOrders.Text = customerDashboardInfo.TotalPendingOrders.ToString();
                        lblTotalShippedOrders.Text = customerDashboardInfo.TotalShippedOrders.ToString();
                        lblTotalDeliveredOrders.Text = customerDashboardInfo.TotalDeliveredOrders.ToString();
                    }
                }

            }



        }
    }
}
