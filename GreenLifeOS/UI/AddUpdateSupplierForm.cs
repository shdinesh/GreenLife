using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AddUpdateSupplierForm : Form
    {
        private readonly ISupplierService supplierService;
        private readonly Supplier editableSupplier = null;


        public AddUpdateSupplierForm(Supplier editableSupplier)
        {
            InitializeComponent();
            supplierService = new SupplierService();
            this.editableSupplier = editableSupplier;

        }

        public AddUpdateSupplierForm()
        {
            InitializeComponent();
            supplierService = new SupplierService();

        }

        private void btnSupSave_Click(object sender, EventArgs e)

        {
            try
            {
                var newSupplier = new Supplier()
                {
                    Name = txtSupName.Text.Trim(),
                    Address = txtSupAddress.Text.Trim(),
                    Email = txtSupEmail.Text.Trim(),
                    Phone = txtSupPhone.Text.Trim(),
                };

                if (editableSupplier == null)
                {
                    AddNewSupplier(newSupplier);
                }
                else
                {
                    UpdateSupplier(newSupplier);
                }
            }
            catch (Exception ex)
            {
                LogError($"Error saving supplier", ex);
                ShowErrorMessage("Error", "An error occurred while saving the supplier. Please try again. " + ex.Message);
            }
            finally
            {
                this.Close();
            }

        }

        private void btnSupClear_Click(object sender, EventArgs e)
        {
            txtSupName.Clear();
            txtSupAddress.Clear();
            txtSupEmail.Clear();
            txtSupPhone.Clear();
        }

        private void AddUpdateSupplierForm_Load(object sender, EventArgs e)
        {
            if (editableSupplier != null)
            {
                txtSupName.Text = editableSupplier.Name;
                txtSupAddress.Text = editableSupplier.Address;
                txtSupEmail.Text = editableSupplier.Email;
                txtSupPhone.Text = editableSupplier.Phone;
            }
        }
        private void AddNewSupplier(Supplier newSupplier)
        {
            try
            {
                supplierService.AddNewSupplier(newSupplier);
                ShowSuccessMessage("Success", "Supplier saved successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while saving the supplier. Please try again. " + ex.Message);
            }
        }

        private void UpdateSupplier(Supplier supplier)
        {
            try
            {
                supplier.Id = editableSupplier.Id;
                supplierService.UpdateSupplier(supplier);
                ShowSuccessMessage("Success", "Supplier updated successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while updating the supplier. Please try again. " + ex.Message);
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
    }
}
