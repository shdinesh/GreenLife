using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AdminRegistrationForm : Form
    {
        private readonly IAdminService adminService;


        public AdminRegistrationForm(Admin editableAdmin)
        {
            InitializeComponent();
            adminService = new AdminService();

        }

        public AdminRegistrationForm()
        {
            InitializeComponent();
            adminService = new AdminService();
        }

        private void btnSupClear_Click(object sender, EventArgs e)
        {
            txtAdminFirstName.Clear();
            txtAdminLastName.Clear();
            txtAdminEmail.Clear();
            txtAdminPhoneNumber.Clear();
            txtAdminUsername.Clear();
            txtAdminPassword.Clear();
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

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                var newCustomer = new Admin()
                {
                    FirstName = txtAdminFirstName.Text,
                    LastName = txtAdminLastName.Text,
                    Email = txtAdminEmail.Text,
                    PhoneNumber = txtAdminPhoneNumber.Text,
                    User = new User()
                    {
                        UserName = txtAdminUsername.Text,
                        Password = BCrypt.Net.BCrypt.HashPassword(txtAdminPassword.Text),
                        UserRole = UserRole.ADMIN.ToString(),
                    }

                };
                RegisterNewAdmin(newCustomer);

            }
            catch (Exception ex)
            {
                LogError($"Error saving admin", ex);
                ShowErrorMessage("Error", "An error occurred while registering admin user. Please try again. " + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
