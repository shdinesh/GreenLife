using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class CustomerRegistrationForm : Form
    {
        private readonly ICustomerService customerService;
        private Customer editableCustomer;


        public CustomerRegistrationForm(Customer editableCustomer)
        {
            InitializeComponent();
            customerService = new CustomerService();
            this.editableCustomer = editableCustomer;

        }

        public CustomerRegistrationForm()
        {
            InitializeComponent();
            customerService = new CustomerService();

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




        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var newCustomer = new Customer()
                {

                    FirstName = txtCustomerFirstName.Text,
                    LastName = txtCustomerLastName.Text,
                    Email = txtCustomerEmail.Text,
                    Address = txtCustomerAddress.Text,
                    PhoneNumber = txtCustomerPhoneNumber.Text,

                };

                if (editableCustomer == null)
                {
                    newCustomer.User = new User()
                    {
                        UserName = txtUsername.Text,
                        Password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text),
                        UserRole = UserRole.CUSTOMER.ToString(),
                    };
                    RegisterNewCustomer(newCustomer);
                }
                else
                {

                    UpdateCustomer(newCustomer);
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
            if (editableCustomer != null)
            {
                txtCustomerFirstName.Text = editableCustomer.FirstName;
                txtCustomerLastName.Text = editableCustomer.LastName;
                txtCustomerEmail.Text = editableCustomer.Email;
                txtCustomerAddress.Text = editableCustomer.Address;
                txtCustomerPhoneNumber.Text = editableCustomer.PhoneNumber;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
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
