using GreenLifeOS.Repository;
using System;

namespace GreenLifeOS.Service
{
    internal class AdminDashboardService : IAdminDashboardService
    {
        private readonly IAdminDashboardRepository adminDashboardRepository;

        public AdminDashboardService(IAdminDashboardRepository adminDashboardRepository)
        {
            this.adminDashboardRepository = adminDashboardRepository ?? throw new ArgumentNullException(nameof(adminDashboardRepository));
        }

        public AdminDashboardService() : this(new AdminDashboardRepository())
        {
        }



        public AdminDashboardVo GenerateAdminDashboardStats()
        {
            try
            {
                var adminDashboard = adminDashboardRepository.GenerateAdminDashboardStats();

                if (adminDashboard == null)
                    throw new ArgumentException($"Admin dashboard information not found.");

                return adminDashboard;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving admin dashboard info. Please try again.", ex);
            }
        }




        private ValidationResult ValidateAdmin(Admin Admin)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }
    }


}
