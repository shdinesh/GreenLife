using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AddUpdateProductForm : Form
    {
        private readonly IProductCategoryService productCategoryService;
        private readonly IProductService productService;
        private readonly ProductVo editableProduct = null;


        public AddUpdateProductForm(ProductVo editableProduct)
        {
            InitializeComponent();
            productCategoryService = new ProductCategoryService();
            productService = new ProductService();
            this.editableProduct = editableProduct;

        }

        public AddUpdateProductForm()
        {
            InitializeComponent();
            productCategoryService = new ProductCategoryService();
            productService = new ProductService();

        }

        private void btnSupSave_Click(object sender, EventArgs e)
        {
            try
            {
                double sellingPrice = 0.00;
                if (!double.TryParse(txtProductSellingPrice.Text.Trim(), out sellingPrice))
                {
                    MessageBox.Show("Please enter a valid selling price.",
                                    "Invalid Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                var newProduct = new Product()
                {
                    Name = txtProductName.Text.Trim(),
                    Code = txtProductCode.Text.Trim(),
                    CategoryId = (int)cmbProductCategory.SelectedValue,
                    Description = txtProductDescription.Text.Trim(),
                    SellingPrice = sellingPrice,
                };

                if (editableProduct == null)
                {
                   AddNewProduct(newProduct);
                }
                else
                {
                   UpdateProduct(newProduct);
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

        private void AddNewProduct(Product newProduct)
        {
            try
            {
                productService.AddNewProduct(newProduct);
                ShowSuccessMessage("Success", "Product saved successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while saving the product. Please try again. " + ex.Message);
            }
        }

        private void UpdateProduct(Product product)
        {
            try
            {
                product.Id = editableProduct.Id;
                productService.UpdateProduct(product);
                ShowSuccessMessage("Success", "Product updated successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while updating the product. Please try again. " + ex.Message);
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

        private void AddUpdateProductForm_Load(object sender, EventArgs e)
        {
            loadProductCategories();
            if (editableProduct != null)
            {
                txtProductName.Text = editableProduct.Name;
                txtProductCode.Text = editableProduct.Code;
                txtProductDescription.Text = editableProduct.Description;
                cmbProductCategory.SelectedValue = editableProduct.CategoryId;

            }
        }

        private void loadProductCategories()
        {
            var categories = productCategoryService.GetAllProductCategories();

            cmbProductCategory.DataSource = categories;
            cmbProductCategory.DisplayMember = "Name";   // property shown to user
            cmbProductCategory.ValueMember = "Id";
        }
    }
}
