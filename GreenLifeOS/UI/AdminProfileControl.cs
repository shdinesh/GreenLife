using GreenLifeOS.Service;
using GreenLifeOS.Session;
using System;
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
            if (AppSession.CurrentUser != null)
            {
                Admin admin = userService.GetUserById(AppSession.CurrentUser.UserId).Admin;
                if (admin != null)
                {
                    lblAdminTitle.Text = "Mr";
                    lblAdminFirstname.Text = admin.FirstName;
                    lblAdminLastName.Text = admin.LastName;
                    lblAdminRole.Text = AppSession.CurrentUser.Role;
                    lblAdminEmail.Text = admin.Email;
                    lblAdminAddress.Text = "";//admin.Address;
                    lblAdminPhoneNumber.Text = admin.PhoneNumber;
                }

            }

        }
    }
}
