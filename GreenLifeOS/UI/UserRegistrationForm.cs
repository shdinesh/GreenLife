using GreenLifeOS.Service;
using GreenLifeOS.Validation;
using GreenLifeOS.Validation.Request;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class UserRegistrationForm : Form
    {
        private readonly UserRegistrationValidator validator = new UserRegistrationValidator();
        private readonly ICustomerService customerService;
        private readonly IAdminService adminService;
        private UserRole userRole;


        public UserRegistrationForm(UserRole userRole)
        {
            InitializeComponent();
            customerService = new CustomerService();
            adminService = new AdminService();
            this.userRole = userRole;

        }

        public UserRegistrationForm()
        {
            InitializeComponent();
            customerService = new CustomerService();
            adminService = new AdminService();

        }

        private void btnSupClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
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
            CustomerRegistrationRequest request = ReadForm();

            var validationResult = validator.Validate(request);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (UserRole.CUSTOMER.Equals(userRole))
                {
                    var newCustomer = new Customer()
                    {
                        Title = (string)cmbTitle.SelectedItem,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        Address = txtAddress.Text,
                        PhoneNumber = txtPhoneNumber.Text,

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
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        Address = txtAddress.Text,
                        PhoneNumber = txtPhoneNumber.Text,

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

        private CustomerRegistrationRequest ReadForm()
        {
            return new CustomerRegistrationRequest
            {
                Title = cmbTitle.SelectedItem == null ? "" : cmbTitle.SelectedItem.ToString(),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
                ConfirmPassword = txtConfirmPassword.Text
            };
        }
    }
}
