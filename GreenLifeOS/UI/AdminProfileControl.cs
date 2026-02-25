using GreenLifeOS.Service;
using GreenLifeOS.Session;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AdminProfileControl : UserControl
    {
        private readonly IOrderService orderService;
        private readonly IProductService productService;
        private readonly ICustomerService customerService;
        private readonly IUserService userService;

        public AdminProfileControl()
        {
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
                Admin admin = userService.GetUserById(AppSession.CurrentUser.UserId).Admins.FirstOrDefault<Admin>();
                if (admin != null)
                {
                    UserProfileUpdateForm profileUpdateForm = new UserProfileUpdateForm(admin);
                    profileUpdateForm.ShowDialog();
                    reloadProfileInfo();
                }
            }
        }

        private void reloadProfileInfo()
        {
            if (AppSession.CurrentUser != null)
            {
                Admin admin = userService.GetUserById(AppSession.CurrentUser.UserId).Admins.FirstOrDefault<Admin>(); ;
                if (admin != null)
                {
                    lblAdminTitle.Text = admin.Title;
                    lblAdminFirstname.Text = admin.FirstName;
                    lblAdminLastName.Text = admin.LastName;
                    lblAdminRole.Text = AppSession.CurrentUser.Role;
                    lblAdminEmail.Text = admin.Email;
                    lblAdminAddress.Text = admin.Address;
                    lblAdminPhoneNumber.Text = admin.PhoneNumber;
                    var fullName = admin.Title + ". " + admin.FirstName + " " + admin.LastName;
                    lblProfileName.Text = fullName;
                }

            }
        }
    }
}
