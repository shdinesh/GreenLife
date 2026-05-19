using GreenLifeOS.Service;
using GreenLifeOS.Validation;
using GreenLifeOS.Validation.Request;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class UserProfileUpdateForm : Form
    {
        private readonly ICustomerService customerService;
        private readonly IAdminService adminService;
        private Customer editCustomer;
        private Admin editAdmin;
        private int mode;
        private readonly UserProfileUpdateValidator validator;



        public UserProfileUpdateForm(Customer editCustomer, int mode)
        {
            InitializeComponent();
            customerService = new CustomerService();
            this.editCustomer = editCustomer;
            this.mode = mode;
            this.validator = new UserProfileUpdateValidator();
            setTitle();

        }
        public UserProfileUpdateForm(Admin editAdmin, int mode)
        {
            InitializeComponent();
            adminService = new AdminService();
            this.editAdmin = editAdmin;
            this.mode = mode;
            this.validator = new UserProfileUpdateValidator();
            setTitle();

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
            UserProfileUpdateRequest request = ReadForm();

            var validationResult = validator.Validate(request);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void setTitle()
        {
            switch (mode)
            {
                case 1:
                    this.Text = "Update Profile";
                    break;
                case 2:
                    this.Text = "Update Customer";
                    break;
                default:
                    break;

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

        private UserProfileUpdateRequest ReadForm()
        {
            return new UserProfileUpdateRequest
            {
                Title = cmbTitle.SelectedItem == null ? "" : cmbTitle.SelectedItem.ToString(),
                FirstName = txtCustomerFirstName.Text,
                LastName = txtCustomerLastName.Text,
                Email = txtCustomerEmail.Text,
                Address = txtCustomerAddress.Text,
                PhoneNumber = txtCustomerPhoneNumber.Text,
            };
        }

    }
}
