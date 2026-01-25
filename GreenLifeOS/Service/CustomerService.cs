using GreenLifeOS.Repository;
using System;
using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        public CustomerService() : this(new CustomerRepository())
        {
        }

        public Customer AddNewCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            var validationResult = ValidateCustomer(customer);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var result = customerRepository.AddNewCustomer(customer);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while adding the product category. Please try again.", ex);
            }
        }


        public bool DeleteCustomer(int id)
        {
            try
            {
                var existingCustomer = GetCustomerById(id);
                if (existingCustomer == null)
                    throw new ArgumentException($"customer with ID {id} not found.", nameof(id));

                var result = customerRepository.DeleteCustomer(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the customer. Please try again.", ex);
            }
        }

        public List<Customer> GetAllCustomers()
        {
            try
            {
                var categories = customerRepository.GetAllCustomers();

                return categories ?? new List<Customer>();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving Customers. Please try again.", ex);
            }
        }


        public Customer GetCustomerById(int id)
        {
            try
            {
                var category = customerRepository.GetCustomerById(id);

                if (category == null)
                    throw new ArgumentException($"Customer with ID {id} not found.", nameof(id));

                return category;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving the Customer. Please try again.", ex);
            }
        }

        public Customer UpdateCustomer(Customer Customer)
        {

            var validationResult = ValidateCustomer(Customer);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var existingCategory = GetCustomerById(Customer.Id);
                if (existingCategory == null)
                    throw new ArgumentException($"Customer with ID {Customer.Id} not found.", nameof(Customer.Id));


                var result = customerRepository.UpdateCustomer(Customer);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while updating the Customer. Please try again.", ex);
            }
        }


        private ValidationResult ValidateCustomer(Customer Customer)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }
    }


}
