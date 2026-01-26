using GreenLifeOS.Repository;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeOS.Service
{
    internal class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        }

        public OrderService() : this(new OrderRepository())
        {
        }

        public Order AddNewOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            var validationResult = ValidateOrder(order);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var result = orderRepository.AddNewOrder(order);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while adding the order. Please try again.", ex);
            }
        }


        public bool DeleteOrder(int id)
        {
            try
            {
                var existingOrder = GetOrderById(id);
                if (existingOrder == null)
                    throw new ArgumentException($"order with ID {id} not found.", nameof(id));

                var result = orderRepository.DeleteOrder(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the order. Please try again.", ex);
            }
        }

        public List<OrderVo> GetAllOrders()
        {
            try
            {
                var orders = orderRepository.GetAllOrders() ??
                    Enumerable.Empty<Order>();

                return orders.Select(MapToOrderVo).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving orders. Please try again.", ex);
            }
        }

        public List<OrderVo> GetAllOrdersByStatus(string status)
        {
            try
            {
                var orders = (orderRepository.GetAllOrders() ?? Enumerable.Empty<Order>())
             .Where(o => o.Status == status)
             .ToList();


                return orders.Select(MapToOrderVo).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving orders. Please try again.", ex);
            }
        }

        public List<ProductVo> GetAllLineItems(int orderId)
        {
            try
            {
                Order order = GetOrderById(orderId);
                return order.OrderItems.Select(MapToProductVo).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving orders. Please try again." + ex.Message, ex);
            }
        }


        public Order GetOrderById(int id)
        {
            try
            {
                var category = orderRepository.GetOrderById(id);

                if (category == null)
                    throw new ArgumentException($"order with ID {id} not found.", nameof(id));

                return category;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving the order22. Please try again.", ex);
            }
        }

        public Order UpdateOrder(Order order)
        {

            var validationResult = ValidateOrder(order);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var existingCategory = GetOrderById(order.Id);
                if (existingCategory == null)
                    throw new ArgumentException($"Order with ID {order.Id} not found.", nameof(order.Id));


                var result = orderRepository.UpdateOrder(order);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while updating the order. Please try again.", ex);
            }
        }


        private ValidationResult ValidateOrder(Order order)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }

        private static OrderVo MapToOrderVo(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            return new OrderVo
            {
                OrderId = order.Id,
                OrderDate = order.Date.ToString(),
                Customer = order.Customer.FirstName,
                Amount = order.Amount,
                Status = order.Status
            };
        }
        private static ProductVo MapToProductVo(OrderItem orderItem)
        {
            if (orderItem == null)
                throw new ArgumentNullException(nameof(orderItem));

            return new ProductVo
            {
                Id = orderItem.OrderId,
                LineItemId = orderItem.Id,
                Name = orderItem.Product.Name,
                Code = orderItem.Product.Code,
                SellingPrice = orderItem.SellingPrice,
                PurchaseQuantity = orderItem.OrderQty,
                Discount = orderItem.Discount
            };
        }
    }


}
