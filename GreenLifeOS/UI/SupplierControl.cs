using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class SupplierControl : UserControl
    {
        private readonly ISupplierService supplierService;

        public SupplierControl()
        {
            InitializeComponent();
            supplierService = new SupplierService();

        }

        private void SupplierControl_Load(object sender, EventArgs e)
        {
            reloadSuppliers();

        }

        private void reloadSuppliers()
        {
            try
            {
                suppliersGV.DataSource = null;
                suppliersGV.DataSource = supplierService.GetAllSuppliers();
            }
            catch (Exception ex)
            {
                LogError($"Error loading suppliers", ex);
                ShowErrorMessage("Error", "An error occurred while loading suppliers. Please try again. " + ex.Message);
            }

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
            // In a real application, use a proper logging framework
            // For now, we'll write to debug output
            System.Diagnostics.Debug.WriteLine($"{message}: {ex.Message}");

            // Could also write to a log file or use a logging service
            // Logger.LogError(message, ex);
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            AddUpdateSupplierForm addUpdateSupplierForm = new AddUpdateSupplierForm();
            addUpdateSupplierForm.ShowDialog();
            reloadSuppliers();
        }

        private void btnUpdateSup_Click(object sender, EventArgs e)
        {
            if (suppliersGV.CurrentRow?.DataBoundItem is Supplier supplier)
            {
                AddUpdateSupplierForm addUpdateSupplierForm = new AddUpdateSupplierForm(supplier);
                addUpdateSupplierForm.ShowDialog();
                reloadSuppliers();
            }
        }

        private void btnSupDelete_Click(object sender, EventArgs e)
        {
            if (suppliersGV.CurrentRow?.DataBoundItem is Supplier supplier)
            {
                try
                {
                    string message = "Are you sure you want to delete this Supplier?";
                    string caption = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = ShowConfirmationDialog(caption, message, buttons);

                    if (result == DialogResult.Yes)
                    {

                        int supId = supplier.Id;
                        supplierService.DeleteSupplier(supId);
                        reloadSuppliers();
                    }

                }
                catch (Exception ex)
                {
                    LogError($"Error deleting supplier ID {supplier.Id}", ex);
                    ShowErrorMessage("Error", "An error occurred while deleting the supplier. Please try again. " + ex.Message);
                }
            }
        }
    }
}
