using GreenLifeOS.Service;
using GreenLifeOS.Session;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class CustomerProfileControl : UserControl
    {
        private readonly IUserService userService;

        public CustomerProfileControl()
        {
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
            reloadProfileInfo();
            CenterLabelsUnderImage();

        }

        private void CenterLabelsUnderImage()
        {
            lblProfileName.Left = pnlProfilePicBox.Left + (pnlProfilePicBox.Width - lblProfileName.Width) / 2;
            lblRoleName.Left = pnlProfilePicBox.Left + (pnlProfilePicBox.Width - lblRoleName.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AppSession.CurrentUser != null)
            {
                Customer customer = userService.GetUserById(AppSession.CurrentUser.UserId).Customers.FirstOrDefault<Customer>(); ;
                if (customer != null)
                {
                    UserProfileUpdateForm profileUpdateForm = new UserProfileUpdateForm(customer);
                    profileUpdateForm.ShowDialog();
                    reloadProfileInfo();
                }
            }

        }

        private void reloadProfileInfo()
        {
            if (AppSession.CurrentUser != null)
            {
                Customer customer = userService.GetUserById(AppSession.CurrentUser.UserId).Customers.FirstOrDefault<Customer>(); ;
                if (customer != null)
                {
                    lblCustomerTitle.Text = customer.Title;
                    lblCustomerFirstName.Text = customer.FirstName;
                    lblCustomerLastName.Text = customer.LastName;
                    lblCustomerRole.Text = AppSession.CurrentUser.Role;
                    lblCustomerEmail.Text = customer.Email;
                    lblCustomerAddress.Text = customer.Address;
                    lblCustomerPhoneNo.Text = customer.PhoneNumber;
                    var fullName = customer.Title + ". " + customer.FirstName + " " + customer.LastName;
                    lblProfileName.Text = fullName;
                }
            }
        }
    }
}
