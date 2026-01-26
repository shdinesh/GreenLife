using GreenLifeOS.Service;
using GreenLifeOS.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class AdminUserControl : UserControl
    {
        private BindingList<ProductVo> orderProducts;
        private IProductService productService;

        public AdminUserControl()
        {
            orderProducts = new BindingList<ProductVo>();
            productService = new ProductService();
            orderProducts.ListChanged += OrderItems_ListChanged;
            InitializeComponent();
        }

        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
            var child = new ProductsForm();

            child.ProductSelected += product =>
            {
                bool exists = orderProducts.Any(p => p.Id == product.Id);

                if (exists)
                {
                    MessageBox.Show("Product already exists.");
                    return;
                }
                orderProducts.Add(product);
                loadOrderItems();
            };

            child.Show();

        }

        private void loadOrderItems()
        {
            //orderItemsGV.AutoGenerateColumns = false;
            //orderItemsGV.DataSource = orderProducts;

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

        private void OrderItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            //btnPlaceOrder.Enabled = orderProducts.Count > 0;
            /*double discount = 0.00;
            if (!double.TryParse(txtDiscount.Text.Trim(), out discount))
            {
                MessageBox.Show("Please enter a valid discount percentage.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            double finalAmount = CalculateFinalAmount(orderProducts, discount);*/
            //lblOrderTotalAmount.Text = finalAmount.ToString("N2");
        }

        private double CalculateFinalAmount(IEnumerable<ProductVo> products, double discountPercent)
        {
            if (products == null) return 0;

            double total = products.Sum(p => p.LineItemTotal);
            double finalAmount = total - (total * discountPercent / 100);
            return finalAmount;
        }

        

        private void AddNewOrder(Order order)
        {
            try
            {
                List<OrderItem> orderItems = mapOrderItems();
                order.OrderItems = orderItems;
                //orderService.AddNewOrder(order);
                productService.decreaseAvailableStock(orderItems);

                ShowSuccessMessage("Success", "Order placed successfully");
            }
            catch (Exception ex)
            {
                LogError($"Error saving order", ex);
                ShowErrorMessage("Error", "An error occurred while placing the order. Please try again. " + ex.Message);
            }
        }

        private void customerOrderTabs_TabIndexChanged(object sender, EventArgs e)
        {
            //switch (customerOrderTabs.SelectedIndex)
            //{
            //    case 0:
            //        break;
            //    case 1:
            //        reloadOrders();
            //        break;
            //}
        }

        private void reloadOrders()
        {
            try
            {
                //ordersListGV.AutoGenerateColumns = false;
                //ordersListGV.DataSource = null;
                //ordersListGV.DataSource = orderService.GetAllOrders();
            }
            catch (Exception ex)
            {
                LogError($"Error loading orders", ex);
                ShowErrorMessage("Error", "An error occurred while loading orders. Please try again. " + ex.Message);
            }

        }
        private void reloadOrderItems(int OrderId)
        {
            try
            {
                //orderLineItemsGV.AutoGenerateColumns = false;
                //orderLineItemsGV.DataSource = null;
                //orderLineItemsGV.DataSource = orderService.GetAllLineItems(OrderId);
            }
            catch (Exception ex)
            {
                LogError($"Error loading orders", ex);
                ShowErrorMessage("Error", "An error occurred while loading orders. Please try again. " + ex.Message);
            }

        }

        private void ShowSuccessMessage(string title, string message)
        {
            MessageBox.Show(this, message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetOrderForm()
        {
            orderProducts.Clear();
            loadOrderItems();
            //lblOrderTotalAmount.Text = "0.00";
        }

        private List<OrderItem> mapOrderItems()
        {
            return orderProducts
             .Select(p => new OrderItem
             {
                 ProductId = p.Id,
                 OrderQty = p.PurchaseQuantity,
                 SellingPrice = p.SellingPrice,
                 Discount = p.Discount ?? 0.00,
             })
             .ToList();
        }

        private void ordersListGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (ordersListGV.CurrentRow?.DataBoundItem is OrderVo orderVo)
            //{
            //    reloadOrderItems(orderVo.OrderId);
            //}

        }
    }
}
