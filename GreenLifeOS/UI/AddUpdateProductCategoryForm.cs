using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AddUpdateProductCategoryForm : Form
    {
        private readonly IProductCategoryService productCategoryService;
        private readonly ProductCategory editableProductCategory = null;


        public AddUpdateProductCategoryForm(ProductCategory editableProductCategory)
        {
            InitializeComponent();
            productCategoryService = new ProductCategoryService();
            this.editableProductCategory = editableProductCategory;

        }

        public AddUpdateProductCategoryForm()
        {
            InitializeComponent();
            productCategoryService = new ProductCategoryService();

        }

        private void btnSupSave_Click(object sender, EventArgs e)

        {
            try
            {
                var newProductCategory = new ProductCategory()
                {
                    Name = txtCategoryName.Text.Trim(),
                    Description = txtCategoryDescription.Text.Trim(),
                };

                if (editableProductCategory == null)
                {
                    AddNewProductCategory(newProductCategory);
                }
                else
                {
                    UpdateProductCategory(newProductCategory);
                }
            }
            catch (Exception ex)
            {
                LogError($"Error saving product category", ex);
                ShowErrorMessage("Error", "An error occurred while saving the product category. Please try again. " + ex.Message);
            }
            finally
            {
                this.Close();
            }

        }

        private void btnSupClear_Click(object sender, EventArgs e)
        {
            txtCategoryName.Clear();
            txtCategoryDescription.Clear();
        }


        private void AddNewProductCategory(ProductCategory newProductCategory)
        {
            try
            {
                productCategoryService.AddNewProductCategory(newProductCategory);
                ShowSuccessMessage("Success", "Product category saved successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while saving the product category. Please try again. " + ex.Message);
            }
        }

        private void UpdateProductCategory(ProductCategory productCategory)
        {
            try
            {
                productCategory.Id = editableProductCategory.Id;
                productCategoryService.UpdateProductCategory(productCategory);
                ShowSuccessMessage("Success", "Product category updated successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while updating the product category. Please try again. " + ex.Message);
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

        private void AddUpdateProductCategoryForm_Load(object sender, EventArgs e)
        {
            if (editableProductCategory != null)
            {
                txtCategoryName.Text = editableProductCategory.Name;
                txtCategoryDescription.Text = editableProductCategory.Description;

            }
        }
    }
}
