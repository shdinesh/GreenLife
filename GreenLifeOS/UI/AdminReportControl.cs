using GreenLifeOS.Service;
using GreenLifeOS.Session;
using GreenLifeOS.Utils;
using Microsoft.EntityFrameworkCore.Internal;
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
            loadCustomers();

        }

        private void btnSalesReportGenerate_Click(object sender, EventArgs e)
        {
            generateSalesReport();
        }

        private void generateSalesReport()
        {
            try
            {

                string dateFrom = dateFromSR.Value.ToString("yyyy-MM-dd");
                string dateTo = dateToSR.Value.ToString("yyyy-MM-dd");

                var salesReportResults = reportsService.GenerateSalesReport(dateFrom, dateTo);

                salesReportGV.AutoGenerateColumns = false;
                salesReportGV.DataSource = null;
                if (salesReportResults == null || !salesReportResults.Any())
                {
                    ShowInfoMessage("Information", "No records found for the selected criteria.");
                    return;
                }

                salesReportGV.DataSource = salesReportResults;
            }
            catch (Exception ex)
            {
                LogError($"Error loading sales report", ex);
                ShowErrorMessage("Error", "An error occurred while loading sales report. Please try again. " + ex.Message);
            }
        }

        private void generateOrderHistoryReport()
        {
            try
            {

                string dateFrom = dateFromOH.Value.ToString("yyyy-MM-dd");
                string dateTo = dateToOH.Value.ToString("yyyy-MM-dd");
                var customer = cmbCustomerFilterOH.SelectedItem as CustomerVo;

                string customerName = null;

                if (customer != null && customer.Id != 0)
                {
                    customerName = customer.FullName.Trim();
                }
                string orderStatus = cmbStatusFilterOH.SelectedItem?.ToString().Trim();

                var orderHistoryReportResults = reportsService.GenerateOrderHistoryReport(customerName, dateFrom, dateTo, orderStatus);

                orderHistoryGV.AutoGenerateColumns = false;
                orderHistoryGV.DataSource = null;
                if (orderHistoryReportResults == null || !orderHistoryReportResults.Any())
                {
                    ShowInfoMessage("Information", "No records found for the selected criteria.");
                    return;
                }

                orderHistoryGV.DataSource = orderHistoryReportResults;
            }
            catch (Exception ex)
            {
                LogError($"Error loading order history report", ex);
                ShowErrorMessage("Error", "An error occurred while loading order history report. Please try again. " + ex.Message);
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
                    MessageBox.Show("Report exported successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void loadCustomers()
        {
            try
            {
                var customers = customerService.GetAllCustomers();
                customers.Insert(0, new CustomerVo
                {
                    Id = 0,
                    FullName = "All",
                });

                cmbCustomerFilterOH.DataSource = null;
                cmbCustomerFilterOH.DataSource = customers;
                cmbCustomerFilterOH.DisplayMember = "FullName";
                cmbCustomerFilterOH.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                LogError($"Error loading customers", ex);
                ShowErrorMessage("Error", "An error occurred while loading customers. Please try again. " + ex.Message);
            }
        }

        private void btnGenerateOrderHistory_Click(object sender, EventArgs e)
        {
            generateOrderHistoryReport();
        }

        private void ShowInfoMessage(string title, string message)
        {
            MessageBox.Show(this, message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveOrderHistoryReport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                string dateFrom = dateFromOH.Value.ToString("yyyy-MM-dd");
                string dateTo = dateToOH.Value.ToString("yyyy-MM-dd");
                sfd.Title = "Order History Report";
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "Order History Report_" + dateFrom + "-" + dateTo + ".csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    CSVExport.ExportGridToCsv(orderHistoryGV, sfd.FileName);
                    MessageBox.Show("Report exported successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
