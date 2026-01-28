using GreenLifeOS.Service;
using GreenLifeOS.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeOS.UI
{
    public partial class CustomerOrderControl : UserControl
    {
        private readonly IOrderService orderService;
        private BindingList<ProductVo> orderProducts;
        private IProductService productService;

        public CustomerOrderControl()
        {
            orderService = new OrderService();
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
            orderItemsGV.AutoGenerateColumns = false;
            orderItemsGV.DataSource = orderProducts;

        }

        private void btnRemoveOrderItem_Click(object sender, EventArgs e)
        {
            if (orderItemsGV.CurrentRow?.DataBoundItem is ProductVo product)
            {
                string message = "Are you sure you want to remove this item?";
                string caption = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = ShowConfirmationDialog(caption, message, buttons);

                if (result == DialogResult.Yes)
                {
                    orderProducts.Remove(product);
                    loadOrderItems();
                }
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

        private void OrderItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnPlaceOrder.Enabled = orderProducts.Count > 0;
            double discount = 0.00;
            if (!double.TryParse(txtDiscount.Text.Trim(), out discount))
            {
                MessageBox.Show("Please enter a valid discount percentage.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            double finalAmount = CalculateFinalAmount(orderProducts, discount);
            lblOrderTotalAmount.Text = finalAmount.ToString("N2");
        }

        private double CalculateFinalAmount(IEnumerable<ProductVo> products, double discountPercent)
        {
            if (products == null) return 0;

            double total = products.Sum(p => p.LineItemTotal);
            double finalAmount = total - (total * discountPercent / 100);
            return finalAmount;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double orderAmount = 0;
            try
            {
                if (!double.TryParse(lblOrderTotalAmount.Text.Trim(), out orderAmount))
                {
                    MessageBox.Show("Please enter a valid number.",
                                    "Invalid Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
                var order = new Order()
                {
                    Date = DateTime.Now,
                    Amount = orderAmount,
                    Status = OrderStatus.PENDING.ToString(),
                    CustomerId = AppSession.CurrentUser.UserId,
                    LastUpdated = DateTime.Now,

                };
                AddNewOrder(order);

            }
            catch (Exception ex)
            {
                LogError($"Error saving product category", ex);
                ShowErrorMessage("Error", "An error occurred while saving the product category. Please try again. " + ex.Message);
            }
            finally
            {
                resetOrderForm();
            }
        }

        private void AddNewOrder(Order order)
        {
            try
            {
                List<OrderItem> orderItems = mapOrderItems();
                order.OrderItems = orderItems;
                orderService.AddNewOrder(order);
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
            reloadOrders();
            switch (customerOrderTabs.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    reloadOrders();
                    break;
            }
        }

        private void reloadOrders()
        {
            try
            {
                ordersListGV.AutoGenerateColumns = false;
                ordersListGV.DataSource = null;
                ordersListGV.DataSource = orderService.GetAllOrders();
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
                orderLineItemsGV.AutoGenerateColumns = false;
                orderLineItemsGV.DataSource = null;
                orderLineItemsGV.DataSource = orderService.GetAllLineItems(OrderId);
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
            lblOrderTotalAmount.Text = "0.00";
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
            if (ordersListGV.CurrentRow?.DataBoundItem is OrderVo orderVo)
            {
                reloadOrderItems(orderVo.OrderId);
            }

        }
    }
}
