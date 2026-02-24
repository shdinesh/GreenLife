using GreenLifeOS.Service;
using GreenLifeOS.Session;
using GreenLifeOS.Utils;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AdminReportControl : UserControl
    {
        private readonly IReportsService reportsService;
        private readonly IOrderService orderService;
        private readonly IProductService productService;
        private readonly ICustomerService customerService;
        private readonly IUserService userService;

        public AdminReportControl()
        {
            reportsService = new ReportsService();
            orderService = new OrderService();
            productService = new ProductService();
            customerService = new CustomerService();
            userService = new UserService();
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

        private void CustomerProfileControl_Load(object sender, EventArgs e)
        {
            if (AppSession.CurrentUser != null)
            {
                Admin admin = userService.GetUserById(AppSession.CurrentUser.UserId).Admin;
                if (admin != null)
                {
                }

            }

        }

        private void btnChangeOrderStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnSalesReportGenerate_Click(object sender, EventArgs e)
        {
            reloadOrderItems();
        }

        private void reloadOrderItems()
        {
            try
            {

                string dateFrom = dateFromSR.Value.ToString("yyyy-MM-dd");
                string dateTo = dateToSR.Value.ToString("yyyy-MM-dd");

                var salesReportResults = reportsService.GenerateSalesReport(dateFrom, dateTo);

                salesReportGV.AutoGenerateColumns = false;
                salesReportGV.DataSource = null;
                salesReportGV.DataSource = salesReportResults;
            }
            catch (Exception ex)
            {
                LogError($"Error loading sales report", ex);
                ShowErrorMessage("Error", "An error occurred while loading sales report. Please try again. " + ex.Message);
            }
        }

        private void btnSaveSalesReport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                string dateFrom = dateFromSR.Value.ToString("yyyy-MM-dd");
                string dateTo = dateToSR.Value.ToString("yyyy-MM-dd");
                sfd.Title = "Sales Report";
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "Sales Report_" + dateFrom + "-" + dateTo + ".csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    CSVExport.ExportGridToCsv(salesReportGV, sfd.FileName);
                    MessageBox.Show("CSV exported successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
