using GreenLifeOS.Service;
using System;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AddUpdateStockForm : Form
    {
        private readonly ISupplierService supplierService;
        private readonly IProductService productService;
        private readonly IStockService stockService;
        private readonly StockVo editableStock = null;


        public AddUpdateStockForm(StockVo editableStock)
        {
            InitializeComponent();
            supplierService = new SupplierService();
            productService = new ProductService();
            stockService = new StockService();
            this.editableStock = editableStock;
            txtStockQuantity.Enabled = false;

        }

        public AddUpdateStockForm()
        {
            InitializeComponent();
            supplierService = new SupplierService();
            productService = new ProductService();
            stockService = new StockService();
        }

        private void btnSupSave_Click(object sender, EventArgs e)
        {
            try
            {
                double price;
                int quantity;

                if (!double.TryParse(txtStockPrice.Text.Trim(), out price))
                {
                    MessageBox.Show("Please enter a valid price.",
                                    "Invalid Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtStockQuantity.Text.Trim(), out quantity))
                {
                    MessageBox.Show("Please enter a valid quantity.",
                                    "Invalid Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                var newStock = new Stock()
                {
                    ProductId = (int?)cmbStockProducts.SelectedValue,
                    SupplierId = (int?)cmbStockSuppliers.SelectedValue,
                    StockQty = quantity,
                    Date = stockDatePicker.Value,
                    Price = price,
                };

                if (editableStock == null)
                {
                    AddNewStock(newStock);
                }
                else
                {
                    UpdateStock(newStock);
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

        private void AddNewStock(Stock newStock)
        {
            try
            {
                stockService.AddNewStock(newStock);
                productService.increaseAvailableStock(newStock);
                ShowSuccessMessage("Success", "Stock saved successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while saving the stock. Please try again. " + ex.Message);
            }
        }

        private void UpdateStock(Stock stock)
        {
            try
            {
                stock.Id = editableStock.Id;
                stockService.UpdateStock(stock);
                ShowSuccessMessage("Success", "Stock updated successfully");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", "An error occurred while updating the stock. Please try again. " + ex.Message);
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
            loadSuppliers();
            loadProducts();
            if (editableStock != null)
            {
                txtStockQuantity.Text = editableStock.Quantity.ToString();
                txtStockPrice.Text = editableStock.Price.ToString();
                stockDatePicker.Value = editableStock.Date;
                cmbStockProducts.SelectedValue = editableStock.ProductId;
                cmbStockSuppliers.SelectedValue = editableStock.SupplierId;
            }
        }

        private void loadSuppliers()
        {
            var suppliers = supplierService.GetAllSuppliers();

            cmbStockSuppliers.DataSource = suppliers;
            cmbStockSuppliers.DisplayMember = "Name";
            cmbStockSuppliers.ValueMember = "Id";
        }

        private void loadProducts()
        {
            var products = productService.GetAllProducts();

            cmbStockProducts.DataSource = products;
            cmbStockProducts.DisplayMember = "NameAndCode";
            cmbStockProducts.ValueMember = "Id";
        }
    }
}
