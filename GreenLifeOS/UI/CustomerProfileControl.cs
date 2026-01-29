using GreenLifeOS.Service;
using GreenLifeOS.Session;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class CustomerProfileControl : UserControl
    {
        private readonly IOrderService orderService;
        private readonly IProductService productService;
        private readonly ICustomerService customerService;
        private readonly IUserService userService;

        public CustomerProfileControl()
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
                Customer customer = userService.GetUserById(AppSession.CurrentUser.UserId).Customer;
                if (customer != null)
                {
                    lblCustomerTitle.Text = "Mr";
                    lblCustomerFirstName.Text = customer.FirstName;
                    lblCustomerLastName.Text = customer.LastName;
                    lblCustomerRole.Text = AppSession.CurrentUser.Role;
                    lblCustomerEmail.Text = customer.Email;
                    lblCustomerAddress.Text = customer.Address;
                    lblCustomerPhoneNo.Text = customer.PhoneNumber;
                }

            }

        }
    }
}
