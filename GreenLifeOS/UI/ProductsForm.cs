using Google.Protobuf.WellKnownTypes;
using GreenLifeOS.Service;
using GreenLifeOS.Utils;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class ProductsForm : Form
    {
        public event Action<ProductVo> ProductSelected;
        private readonly IProductService productService;
        private readonly IProductCategoryService productCategoryService;


        public ProductsForm()
        {
            InitializeComponent();
            productService = new ProductService();
            productCategoryService = new ProductCategoryService();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            reloadProducts();
            loadProductCategories();
            this.cmbProductCategory.SelectedIndex = -1;


        }

        private void reloadProducts()
        {
            try
            {
                productsGV.AutoGenerateColumns = false;
                productsGV.DataSource = null;
                productsGV.DataSource = productService.GetAllProducts();
            }
            catch (Exception ex)
            {
                LogError($"Error loading products", ex);
                ShowErrorMessage("Error", "An error occurred while loading products. Please try again. " + ex.Message);
            }

        }

        private void loadProductCategories()
        {
            try
            {
                var categories = productCategoryService.GetAllProductCategories();
                categories.Insert(0, new ProductCategory
                {
                    Id = 0,
                    Name = "All"
                });

                cmbProductCategory.DataSource = null;
                cmbProductCategory.DataSource = categories;
                cmbProductCategory.DisplayMember = "Name";
                cmbProductCategory.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                LogError($"Error loading product categories", ex);
                ShowErrorMessage("Error", "An error occurred while loading product categories. Please try again. " + ex.Message);
            }
        }

        private void searchProducts()
        {
            try
            {
                int categoryId = 0;
                double minPrice;
                double maxPrice;
                if (cmbProductCategory.SelectedValue != null &&
                    int.TryParse(cmbProductCategory.SelectedValue.ToString(), out int id))
                    categoryId = id;


                string productName = txtSearchProduct.Text ?? "";

                if (!double.TryParse(txtMinPrice.Text.Trim(), out minPrice))
                    minPrice = 0;

                if (!double.TryParse(txtMaxPrice.Text.Trim(), out maxPrice))
                    maxPrice = 0;

                productsGV.AutoGenerateColumns = false;
                productsGV.DataSource = null;
                productsGV.DataSource = productService.SearchProduct(categoryId, productName, minPrice, maxPrice);
            }
            catch (Exception ex)
            {
                LogError($"Error loading products", ex);
                ShowErrorMessage("Error", "An error occurred while loading products. Please try again. " + ex.Message);
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
            System.Diagnostics.Debug.WriteLine($"{message}: {ex.Message}");
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (productsGV.CurrentRow?.DataBoundItem is ProductVo product)
            {
                try
                {
                    string message = "Are you sure you want to delete this product?";
                    string caption = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = ShowConfirmationDialog(caption, message, buttons);

                    if (result == DialogResult.Yes)
                    {
                        int productId = product.Id;
                        productService.DeleteProduct(productId);
                        reloadProducts();
                    }
                }
                catch (Exception ex)
                {
                    LogError($"Error deleting product ID {product.Id}", ex);
                    ShowErrorMessage("Error", "An error occurred while deleting the product. Please try again. " + ex.Message);
                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (productsGV.CurrentRow?.DataBoundItem is ProductVo product)
            {
                AddUpdateProductForm addUpdateProductForm = new AddUpdateProductForm(product);
                addUpdateProductForm.ShowDialog();
                reloadProducts();
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            int orderQuantity = 0;
            if (productsGV.CurrentRow?.DataBoundItem is ProductVo product)
            {
                if (!int.TryParse(txtPurchaseQuantity.Text.Trim(), out orderQuantity))
                {
                    MessageBox.Show("Please enter a valid number.",
                                    "Invalid Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                if (product.AvailableStock < orderQuantity)
                {
                    MessageBox.Show("Item stock is insufficient to order. Try ordering fewer items.",
                        "Insufficient Stock",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;

                }
                product.PurchaseQuantity = orderQuantity;
                ProductSelected?.Invoke(product);
                this.Close();
            }
        }
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            searchProducts();
        }

        private void txtMinPrice_TextChanged(object sender, EventArgs e)
        {
            searchProducts();
        }

        private void txtMaxPrice_TextChanged(object sender, EventArgs e)
        {
            searchProducts();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            searchProducts();
        }
    }

}
