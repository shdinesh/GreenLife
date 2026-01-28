using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        public AdminRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public AdminRepository() : this(new GreenLifeDBContext())
        {
        }

        public Admin AddNewAdmin(Admin admin)
        {
            if (admin == null)
                throw new ArgumentNullException(nameof(admin));

            try
            {
                this.dbContext.Admins.Add(admin);
                this.dbContext.SaveChanges();
                return admin;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", errorMessages)}", ex);
            }
        }

        public bool DeleteAdmin(int id)
        {
            var admin = GetAdminById(id);
            if (admin == null)
                throw new ArgumentException($"Admin with ID {id} not found.", nameof(id));

            this.dbContext.Admins.Remove(admin);
            this.dbContext.SaveChanges();
            return true;
        }

        public List<Admin> GetAllAdmins()
        {
            return this.dbContext.Admins
                .AsNoTracking()
                .ToList();
        }

        public Admin GetAdminById(int id)
        {
            return this.dbContext.Admins
                .FirstOrDefault(s => s.Id == id);
        }

        public Admin UpdateAdmin(Admin admin)
        {
            if (admin == null)
                throw new ArgumentNullException(nameof(admin));

            var existingAdmin = GetAdminById(admin.Id);
            if (existingAdmin == null)
                throw new ArgumentException($"Admin with ID {admin.Id} not found.", nameof(admin.Id));

            try
            {
                this.dbContext.Entry(existingAdmin).CurrentValues.SetValues(admin);
                this.dbContext.SaveChanges();

                this.dbContext.Entry(existingAdmin).Reload();
                return existingAdmin;
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
                throw new InvalidOperationException("Concurrency conflict occurred while updating the Admin.", ex);
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
