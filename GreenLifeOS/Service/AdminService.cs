using GreenLifeOS.Repository;
using System;
using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal class AdminService : IAdminService
    {
        private readonly IAdminRepository adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository ?? throw new ArgumentNullException(nameof(adminRepository));
        }

        public AdminService() : this(new AdminRepository())
        {
        }

        public Admin AddNewAdmin(Admin admin)
        {
            if (admin == null)
                throw new ArgumentNullException(nameof(admin));

            var validationResult = ValidateAdmin(admin);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var result = adminRepository.AddNewAdmin(admin);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while adding the product category. Please try again.", ex);
            }
        }


        public bool DeleteAdmin(int id)
        {
            try
            {
                var existingAdmin = GetAdminById(id);
                if (existingAdmin == null)
                    throw new ArgumentException($"Admin with ID {id} not found.", nameof(id));

                var result = adminRepository.DeleteAdmin(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the Admin. Please try again.", ex);
            }
        }

        public List<Admin> GetAllAdmins()
        {
            try
            {
                var admins = adminRepository.GetAllAdmins();

                return admins ?? new List<Admin>();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving Admins. Please try again.", ex);
            }
        }


        public Admin GetAdminById(int id)
        {
            try
            {
                var admin = adminRepository.GetAdminById(id);

                if (admin == null)
                    throw new ArgumentException($"Admin with ID {id} not found.", nameof(id));

                return admin;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving the Admin. Please try again.", ex);
            }
        }

        public Admin UpdateAdmin(Admin admin)
        {

            var validationResult = ValidateAdmin(admin);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var existingCategory = GetAdminById(admin.Id);
                if (existingCategory == null)
                    throw new ArgumentException($"Admin with ID {admin.Id} not found.", nameof(admin.Id));


                var result = adminRepository.UpdateAdmin(admin);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while updating the admin. Please try again.", ex);
            }
        }


        private ValidationResult ValidateAdmin(Admin Admin)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }
    }


}
