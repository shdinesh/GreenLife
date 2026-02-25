using GreenLifeOS.Repository;
using System;

namespace GreenLifeOS.Service
{
    internal class CustomerDashboardService : ICustomerDashboardService
    {
        private readonly ICustomerDashboardRepository customerDashboardRepository;

        public CustomerDashboardService(ICustomerDashboardRepository customerDashboardRepository)
        {
            this.customerDashboardRepository = customerDashboardRepository ?? throw new ArgumentNullException(nameof(customerDashboardRepository));
        }

        public CustomerDashboardService() : this(new CustomerDashboardRepository())
        {
        }

        public CustomerDashboardVo GenerateCustomerboardStats(int customerId)
        {
            try
            {
                var customerDashboard = customerDashboardRepository.GenerateCustomerboardStats(customerId);

                if (customerDashboard == null)
                    throw new ArgumentException($"Customer dashboard information not found.");

                return customerDashboard;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving customer dashboard info. Please try again.", ex);
            }
        }




        private ValidationResult ValidateAdmin(Admin Admin)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }
    }


}
