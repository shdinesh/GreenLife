using GreenLifeOS.Service;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GreenLifeOS.UI
{
    public partial class UserProfileUpdateForm : Form
    {
        private readonly ICustomerService customerService;
        private readonly IAdminService adminService;
        private Customer editCustomer;
        private Admin editAdmin;


        public UserProfileUpdateForm(Customer editCustomer)
        {
            InitializeComponent();
            customerService = new CustomerService();
            this.editCustomer = editCustomer;

        }
        public UserProfileUpdateForm(Admin editAdmin)
        {
            InitializeComponent();
            adminService = new AdminService();
            this.editAdmin = editAdmin;

        }

        public UserProfileUpdateForm()
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
        }


        private void UpdateCustomerProfile(Customer newCustomer)
        {
            try
            {
                customerService.UpdateCustomer(newCustomer);
                ShowSuccessMessage("Success", "Profile updated successfully");
            }
            catch (Exception ex)
            {
                LogError($"Error saving profile", ex);
                ShowErrorMessage("Error", "An error occurred while saving profile information. Please try again. " + ex.Message);
            }
        }

        private void UpdateAdminProfile(Admin newAdmin)
        {
            try
            {
                adminService.UpdateAdmin(newAdmin);
                ShowSuccessMessage("Success", "Profile updated successfully");
            }
            catch (Exception ex)
            {
                LogError($"Error saving profile", ex);
                ShowErrorMessage("Error", "An error occurred while saving profile information. Please try again. " + ex.Message);
            }
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.editCustomer != null)
                {
                    var newCustomer = new Customer()
                    {
                        Id = editCustomer.Id,
                        Title = (string)cmbTitle.SelectedItem,
                        FirstName = txtCustomerFirstName.Text,
                        LastName = txtCustomerLastName.Text,
                        Email = txtCustomerEmail.Text,
                        Address = txtCustomerAddress.Text,
                        PhoneNumber = txtCustomerPhoneNumber.Text,
                        UserId = editCustomer.UserId,
                    };

                    UpdateCustomerProfile(newCustomer);

                }
                else if (this.editAdmin != null)
                {
                    var newAdmin = new Admin()
                    {
                        Id = editAdmin.Id,
                        Title = (string)cmbTitle.SelectedItem,
                        FirstName = txtCustomerFirstName.Text,
                        LastName = txtCustomerLastName.Text,
                        Email = txtCustomerEmail.Text,
                        Address = txtCustomerAddress.Text,
                        PhoneNumber = txtCustomerPhoneNumber.Text,
                        UserId = editAdmin.UserId,


                    };
                    UpdateAdminProfile(newAdmin);
                }

            }
            catch (Exception ex)
            {
                LogError($"Error saving profile information", ex);
                ShowErrorMessage("Error", "An error occurred while saving profile information. Please try again. " + ex.Message);
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
            if (editCustomer != null)
            {
                cmbTitle.SelectedItem = editCustomer.Title;
                txtCustomerFirstName.Text = editCustomer.FirstName;
                txtCustomerLastName.Text = editCustomer.LastName;
                txtCustomerEmail.Text = editCustomer.Email;
                txtCustomerAddress.Text = editCustomer.Address;
                txtCustomerPhoneNumber.Text = editCustomer.PhoneNumber;
            }
            else if (editAdmin != null)
            {
                cmbTitle.SelectedItem = editAdmin.Title;
                txtCustomerFirstName.Text = editAdmin.FirstName;
                txtCustomerLastName.Text = editAdmin.LastName;
                txtCustomerEmail.Text = editAdmin.Email;
                txtCustomerAddress.Text = editAdmin.Address;
                txtCustomerPhoneNumber.Text = editAdmin.PhoneNumber;
            }
        }
    }
}
