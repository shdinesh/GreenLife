using GreenLifeOS.Service;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AdminUserControl : UserControl
    {
        private ICustomerService customerService;
        private IUserService userService;
        private IAdminService adminService;

        public AdminUserControl()
        {
            customerService = new CustomerService();
            adminService = new AdminService();
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

        private void reloadAllCustomers()
        {
            try
            {
                customersGV.AutoGenerateColumns = false;
                customersGV.DataSource = null;
                customersGV.DataSource = customerService.GetAllCustomers();
            }
            catch (Exception ex)
            {
                LogError($"Error loading customers", ex);
                ShowErrorMessage("Error", "An error occurred while loading customers. Please try again. " + ex.Message);
            }

        }

        private void reloadAllAdmins()
        {
            try
            {
                adminsGV.AutoGenerateColumns = false;
                adminsGV.DataSource = null;
                adminsGV.DataSource = adminService.GetAllAdmins();
            }
            catch (Exception ex)
            {
                LogError($"Error loading customers", ex);
                ShowErrorMessage("Error", "An error occurred while loading customers. Please try again. " + ex.Message);
            }

        }

        private void ShowSuccessMessage(string title, string message)
        {
            MessageBox.Show(this, message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (customersGV.CurrentRow?.DataBoundItem is Customer customer)
            {
                CustomerRegistrationForm customerRegistration = new CustomerRegistrationForm(customer);
                customerRegistration.ShowDialog();
                reloadAllCustomers();
            }
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            reloadAllCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (customersGV.CurrentRow?.DataBoundItem is Customer customer)
            {
                try
                {
                    string message = "Are you sure you want to delete this Customer?";
                    string caption = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = ShowConfirmationDialog(caption, message, buttons);

                    if (result == DialogResult.Yes)
                    {
                        int customerId = customer.Id;
                        customerService.DeleteCustomer(customerId);
                        userService.DeleteUser(customer.User.Id);
                        reloadAllCustomers();
                    }

                }
                catch (Exception ex)
                {
                    LogError($"Error deleting customer ID {customer.Id}", ex);
                    ShowErrorMessage("Error", "An error occurred while deleting the customer. Please try again. " + ex.Message);
                }
            }
        }
        private void adminUsersTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (adminUsersTabs.SelectedIndex)
            {
                case 0:
                    reloadAllCustomers();
                    break;
                case 1:
                    reloadAllAdmins();
                    break;
            }
        }

        private void btnNewAdmin_Click(object sender, EventArgs e)
        {
            AdminRegistrationForm adminRegistration = new AdminRegistrationForm();
            adminRegistration.ShowDialog();
            reloadAllAdmins();
        }
    }
}
