using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class InventoryControl : UserControl
    {
        private readonly ISupplierService supplierService;
        private readonly IProductCategoryService productCategoryService;
        private readonly IProductService productService;
        private readonly IStockService stockService;



        public InventoryControl()
        {
            InitializeComponent();
            supplierService = new SupplierService();
            productCategoryService = new ProductCategoryService();
            productService = new ProductService();
            stockService = new StockService();

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

        private void reloadStocks()
        {
            try
            {
                stocksGV.AutoGenerateColumns = false;
                stocksGV.DataSource = null;
                stocksGV.DataSource = stockService.GetAllStocks();
            }
            catch (Exception ex)
            {
                LogError($"Error loading products", ex);
                //ShowErrorMessage("Error", "An error occurred while loading products. Please try again. " + ex.Message);
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

        private void inventoryTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (inventoryTabs.SelectedIndex)
            {
                case 0:
                    reloadProducts();
                    break;

                case 1:
                    reloadStocks();
                    break;

                case 2:
                    reloadProductCategories();
                    break;
                case 3:
                    reloadSuppliers();
                    break;
            }
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            AddUpdateSupplierForm addUpdateSupplierForm = new AddUpdateSupplierForm();
            addUpdateSupplierForm.ShowDialog();
            reloadSuppliers();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (suppliersGV.CurrentRow?.DataBoundItem is Supplier supplier)
            {
                AddUpdateSupplierForm addUpdateSupplierForm = new AddUpdateSupplierForm(supplier);
                addUpdateSupplierForm.ShowDialog();
                reloadSuppliers();
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
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


        private void btnNewProductCategory_Click(object sender, EventArgs e)
        {
            AddUpdateProductCategoryForm addUpdateProductCategoryForm = new AddUpdateProductCategoryForm();
            addUpdateProductCategoryForm.ShowDialog();
            reloadProductCategories();
        }

        private void btnUpdateProductCategory_Click(object sender, EventArgs e)
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

        private void InventoryControl_Load(object sender, EventArgs e)
        {
                reloadProducts();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {

            AddUpdateProductForm addUpdateProductForm = new AddUpdateProductForm();
            addUpdateProductForm.ShowDialog();
            reloadProducts();
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

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
            AddUpdateStockForm stockForm = new AddUpdateStockForm();
            stockForm.ShowDialog();
            reloadStocks();
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (stocksGV.CurrentRow?.DataBoundItem is StockVo stockVo)
            {
                try
                {
                    string message = "Are you sure you want to delete this Stock?";
                    string caption = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = ShowConfirmationDialog(caption, message, buttons);

                    if (result == DialogResult.Yes)
                    {
                        int stockId = stockVo.Id;
                        stockService.DeleteStock(stockId);
                        reloadStocks();
                    }

                }
                catch (Exception ex)
                {
                    LogError($"Error deleting stock ID {stockVo.Id}", ex);
                    ShowErrorMessage("Error", "An error occurred while deleting the stock. Please try again. " + ex.Message);
                }

            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {

            if (stocksGV.CurrentRow?.DataBoundItem is StockVo stockVo)
            {
                AddUpdateStockForm addUpdateStockForm = new AddUpdateStockForm(stockVo);
                addUpdateStockForm.ShowDialog();
                reloadProductCategories();
            }
        }
    }
}
