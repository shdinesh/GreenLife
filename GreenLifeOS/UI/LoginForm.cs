using GreenLifeOS.Service;
using GreenLifeOS.Session;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class LoginForm : Form
    {

        private readonly IUserService userService;

        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsername.Text;
                var password = txtPassword.Text;
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    ShowErrorMessage("Login Failed", "Username and password are required.");
                    return;
                }
                User user = userService.findUserByUsername(username);
                if (user == null)
                {
                    MessageBox.Show(this, "Invalid credentials", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isValid = BCrypt.Net.BCrypt.Verify(password, user.Password);
                if (!isValid)
                {
                    MessageBox.Show(this, "Invalid credentials", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var userRole = user.UserRole;
                if (userRole.Equals(UserRole.ADMIN.ToString()))
                {
                    AdminMainForm adminMainForm = new AdminMainForm();
                    adminMainForm.ShowDialog();
                }
                else if (userRole.Equals(UserRole.CUSTOMER.ToString()))
                {
                    AppSession.Start(new UserSessionData
                    {
                        UserId = user.Id,
                        UserName = user.UserName,
                        Role = user.UserRole,
                        CustomerId = user.Customer?.Id,
                        LoginTime = DateTime.Now
                    });
                    CustomerMainForm frm = new CustomerMainForm();
                    frm.ShowDialog();
                }

                this.Close();

            }
            catch (Exception ex)
            {
                LogError($"Error authentication", ex);
                ShowErrorMessage("Error", "An error occurred while user login. Please try again. " + ex.Message);
            }

        }


        private void ShowErrorMessage(string title, string message)
        {
            MessageBox.Show(this, message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LogError(string message, Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"{message}: {ex.Message}");
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to exit?";
            string caption = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = ShowConfirmationDialog(caption, message, buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private DialogResult ShowConfirmationDialog(string title, string message, MessageBoxButtons buttons)
        {
            return MessageBox.Show(this, message, title,
                buttons, MessageBoxIcon.Question);
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegistrationForm customerRegistration  = new CustomerRegistrationForm();
            customerRegistration.ShowDialog();
        }
    }


}
