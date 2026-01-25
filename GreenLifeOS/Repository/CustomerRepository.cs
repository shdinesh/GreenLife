using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        public CustomerRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public CustomerRepository() : this(new GreenLifeDBContext())
        {
        }

        public Customer AddNewCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            try
            {
                this.dbContext.Customers.Add(customer);
                this.dbContext.SaveChanges();
                return customer;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", errorMessages)}", ex);
            }
        }

        public bool DeleteCustomer(int id)
        {
            var customer = GetCustomerById(id);
            if (customer == null)
                throw new ArgumentException($"Customer with ID {id} not found.", nameof(id));

            this.dbContext.Customers.Remove(customer);
            this.dbContext.SaveChanges();
            return true;
        }

        public List<Customer> GetAllCustomers()
        {
            return this.dbContext.Customers
                .AsNoTracking()
                .ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return this.dbContext.Customers
                .FirstOrDefault(s => s.Id == id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            var existingCustomer = GetCustomerById(customer.Id);
            if (existingCustomer == null)
                throw new ArgumentException($"Customer with ID {customer.Id} not found.", nameof(customer.Id));

            try
            {
                this.dbContext.Entry(existingCustomer).CurrentValues.SetValues(customer);
                this.dbContext.SaveChanges();

                this.dbContext.Entry(existingCustomer).Reload();
                return existingCustomer;
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
                throw new InvalidOperationException("Concurrency conflict occurred while updating the customer.", ex);
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
