using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class CustomerRegistrationForm : Form
    {
        private readonly ICustomerService customerService;
        private readonly IAdminService adminService;
        private Customer editableCustomer;
        private UserRole userRole;


        public CustomerRegistrationForm(UserRole userRole)
        {
            InitializeComponent();
            customerService = new CustomerService();
            adminService = new AdminService();
            this.userRole = userRole;

        }

        public CustomerRegistrationForm()
        {
            InitializeComponent();
            customerService = new CustomerService();
            adminService = new AdminService();

        }

        private void btnSupClear_Click(object sender, EventArgs e)
        {
            txtCustomerFirstName.Clear();
            txtCustomerLastName.Clear();
            txtCustomerEmail.Clear();
            txtCustomerAddress.Clear();
            txtCustomerPhoneNumber.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }


        private void RegisterNewCustomer(Customer newCustomer)
        {
            try
            {
                customerService.AddNewCustomer(newCustomer);
                ShowSuccessMessage("Success", "Customer registered successfully");
            }
            catch (Exception ex)
            {
                LogError($"Error registering customer", ex);
                ShowErrorMessage("Error", "An error occurred while registering customer. Please try again. " + ex.Message);
            }
        }

        private void RegisterNewAdmin(Admin newAdmin)
        {
            try
            {
                adminService.AddNewAdmin(newAdmin);
                ShowSuccessMessage("Success", "Admin registered successfully");
            }
            catch (Exception ex)
            {
                LogError($"Error registering admin", ex);
                ShowErrorMessage("Error", "An error occurred while registering admin user. Please try again. " + ex.Message);
            }
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserRole.CUSTOMER.Equals(userRole))
                {
                    var newCustomer = new Customer()
                    {
                        Title = (string)cmbTitle.SelectedItem,
                        FirstName = txtCustomerFirstName.Text,
                        LastName = txtCustomerLastName.Text,
                        Email = txtCustomerEmail.Text,
                        Address = txtCustomerAddress.Text,
                        PhoneNumber = txtCustomerPhoneNumber.Text,

                    };
                    newCustomer.User = new User()
                    {
                        UserName = txtUsername.Text,
                        Password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text),
                        UserRole = UserRole.CUSTOMER.ToString(),
                    };
                    RegisterNewCustomer(newCustomer);

                }
                else if (UserRole.ADMIN.Equals(userRole))
                {
                    var newAdmin = new Admin()
                    {
                        Title = (string)cmbTitle.SelectedItem,
                        FirstName = txtCustomerFirstName.Text,
                        LastName = txtCustomerLastName.Text,
                        Email = txtCustomerEmail.Text,
                        Address = txtCustomerAddress.Text,
                        PhoneNumber = txtCustomerPhoneNumber.Text,

                    };
                    newAdmin.User = new User()
                    {
                        UserName = txtUsername.Text,
                        Password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text),
                        UserRole = UserRole.ADMIN.ToString(),
                    };
                    RegisterNewAdmin(newAdmin);
                }

            }
            catch (Exception ex)
            {
                LogError($"Error saving product category", ex);
                ShowErrorMessage("Error", "An error occurred while registering customer. Please try again. " + ex.Message);
            }
            finally
            {
                this.Close();
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

        private void CustomerRegistrationForm_Load(object sender, EventArgs e)
        {
            if (UserRole.CUSTOMER.Equals(userRole))
            {
                this.Text = "Register New Customer";
            }
            else if (UserRole.ADMIN.Equals(userRole))
            {
                this.Text = "Register New Admin";

            }
        }

        private void UpdateCustomer(Customer customer)
        {
            try
            {
                customer = mapCustomerValues(customer);
                customerService.UpdateCustomer(customer);
                ShowSuccessMessage("Success", "Customer updated successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while updating the customer. Please try again. " + ex.Message);
            }
        }

        private Customer mapCustomerValues(Customer customer)
        {
            customer.Id = editableCustomer.Id;
            customer.User = editableCustomer.User;
            customer.Orders = editableCustomer.Orders;
            customer.UserId = editableCustomer.UserId;
            return customer;
        }
    }
}
