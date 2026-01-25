using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class ProductCategoryForm : Form
    {

        private readonly IProductCategoryService productCategoryService;


        public ProductCategoryForm()
        {
            InitializeComponent();
            productCategoryService = new ProductCategoryService();
        }

        private void productCategorysForm_Load(object sender, EventArgs e)
        {
            reloadProductCategories();
        }

        private void reloadProductCategories()
        {
            try
            {
                productCategoryGV.DataSource = null;
                productCategoryGV.DataSource = productCategoryService.GetAllProductCategories();
                productCategoryGV.Columns["Products"].Visible = false;
            }
            catch (Exception ex)
            {
                LogError($"Error loading product categorys", ex);
                ShowErrorMessage("Error", "An error occurred while loading product categorys. Please try again. " + ex.Message);
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

        private void btnNewProductCategory_Click(object sender, EventArgs e)
        {
            AddUpdateProductCategoryForm addUpdateProductCategoryForm = new AddUpdateProductCategoryForm();
            addUpdateProductCategoryForm.ShowDialog();
            reloadProductCategories();
        }

        private void btnUpdateroductCategory_Click(object sender, EventArgs e)
        {

            if (productCategoryGV.CurrentRow?.DataBoundItem is ProductCategory productCategory)
            {
                AddUpdateProductCategoryForm addUpdateProductCategoryForm = new AddUpdateProductCategoryForm(productCategory);
                addUpdateProductCategoryForm.ShowDialog();
                reloadProductCategories();
            }
        }

        private void btnDeleteProductCategory_Click(object sender, EventArgs e)
        {
            if (productCategoryGV.CurrentRow?.DataBoundItem is ProductCategory productCategory)
            {
                try
                {
                    string message = "Are you sure you want to delete this product category?";
                    string caption = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = ShowConfirmationDialog(caption, message, buttons);

                    if (result == DialogResult.Yes)
                    {

                        int supId = productCategory.Id;
                        productCategoryService.DeleteProductCategory(supId);
                        reloadProductCategories();
                    }

                }
                catch (Exception ex)
                {
                    LogError($"Error deleting product category ID {productCategory.Id}", ex);
                    ShowErrorMessage("Error", "An error occurred while deleting the product category. Please try again. " + ex.Message);
                }

            }
        }

        private void ProductCategoryForm_Load(object sender, EventArgs e)
        {
            reloadProductCategories() ;
        }
    }
}
