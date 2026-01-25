using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        // Dependency injection-friendly constructor
        public SupplierRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        // Parameterless constructor for backward compatibility
        public SupplierRepository() : this(new GreenLifeDBContext())
        {
        }

        public Supplier AddNewSupplier(Supplier supplier)
        {
            if (supplier == null)
                throw new ArgumentNullException(nameof(supplier));

            try
            {
                this.dbContext.Supplier.Add(supplier);
                this.dbContext.SaveChanges();
                return supplier;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", errorMessages)}", ex);
            }
        }

        public bool DeleteSupplier(int id)
        {
            var supplier = GetSupplierById(id);
            if (supplier == null)
                throw new ArgumentException($"Supplier with ID {id} not found.", nameof(id));

            this.dbContext.Supplier.Remove(supplier);
            this.dbContext.SaveChanges();
            return true;
        }

        public List<Supplier> GetAllSuppliers()
        {
            return this.dbContext.Supplier
                .AsNoTracking()
                .ToList();
        }

        public Supplier GetSupplierById(int id)
        {
            return this.dbContext.Supplier
                .FirstOrDefault(s => s.Id == id);
        }

        public Supplier UpdateSupplier(Supplier supplier)
        {
            if (supplier == null)
                throw new ArgumentNullException(nameof(supplier));

            var existingSupplier = GetSupplierById(supplier.Id);
            if (existingSupplier == null)
                throw new ArgumentException($"Supplier with ID {supplier.Id} not found.", nameof(supplier.Id));

            try
            {
                // Only update properties that should be changed
                this.dbContext.Entry(existingSupplier).CurrentValues.SetValues(supplier);
                this.dbContext.SaveChanges();

                // Reload to get any database-computed values
                this.dbContext.Entry(existingSupplier).Reload();
                return existingSupplier;
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
                throw new InvalidOperationException("Concurrency conflict occurred while updating the supplier.", ex);
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
