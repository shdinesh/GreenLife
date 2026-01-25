using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        public OrderRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public OrderRepository() : this(new GreenLifeDBContext())
        {
        }

        public Order AddNewOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            try
            {
                this.dbContext.Orders.Add(order);
                this.dbContext.SaveChanges();
                return order;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", errorMessages)}", ex);
            }
        }

        public bool DeleteOrder(int id)
        {
            var Order = GetOrderById(id);
            if (Order == null)
                throw new ArgumentException($"Order with ID {id} not found.", nameof(id));

            this.dbContext.Orders.Remove(Order);
            this.dbContext.SaveChanges();
            return true;
        }

        public List<Order> GetAllOrders()
        {
            return this.dbContext.Orders
                .AsNoTracking()
                .ToList();
        }

        public Order GetOrderById(int id)
        {
            return this.dbContext.Orders
                .FirstOrDefault(s => s.Id == id);
        }

        public Order UpdateOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            var existingOrder = GetOrderById(order.Id);
            if (existingOrder == null)
                throw new ArgumentException($"Order with ID {order.Id} not found.", nameof(order.Id));

            try
            {
                this.dbContext.Entry(existingOrder).CurrentValues.SetValues(order);
                this.dbContext.SaveChanges();

                this.dbContext.Entry(existingOrder).Reload();
                return existingOrder;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", errorMessages)}", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Concurrency conflict occurred while updating the order.", ex);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                this.dbContext?.Dispose();
            }
            disposed = true;
        }
    }


}
