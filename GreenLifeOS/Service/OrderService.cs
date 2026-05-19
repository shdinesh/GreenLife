using GreenLifeOS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<OrderVo> GetAllOrdersByCustomer(int customerId)
        {
            try
            {
                var orders = (orderRepository.GetAllOrders() ?? Enumerable.Empty<Order>())
             .Where(o => o.CustomerId == customerId)
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
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            var order = orderRepository.GetOrderById(id);

            if (order == null)
                throw new KeyNotFoundException($"Order with ID {id} was not found.");

            return order;
        }
        public Order GetOrderByNumber(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentException("Order number cannot be null or empty");
            }

            var order = orderRepository.GetOrderByNumber(number.Trim());

            if (order == null)
            {
                throw new KeyNotFoundException($"Order with number '{number}' was not found.");
            }

            return order;
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

        public Order UpdateOrderStatus(OrderVo orderVo)
        {
            try
            {
                var existingOrder = GetOrderById(orderVo.OrderId);
                if (existingOrder == null)
                    throw new ArgumentException($"Order with ID {orderVo.OrderId} not found.", nameof(orderVo.OrderId));

                existingOrder.Status = orderVo.Status;
                existingOrder.LastUpdated = DateTime.Now;

                var result = orderRepository.UpdateOrder(existingOrder);
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
                Customer = order.Customer?.FirstName,
                Amount = order.Amount,
                Status = order.Status,
                OrderNumber = order.OrderNumber,
                LastUpdated = order.LastUpdated.ToString(),
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
                Name = orderItem.Product?.Name,
                Code = orderItem.Product?.Code,
                SellingPrice = orderItem.SellingPrice,
                PurchaseQuantity = orderItem.OrderQty,
                Discount = orderItem.Discount
            };
        }
    }


}
