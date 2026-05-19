using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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


        /// <summary>Adds a new supplier.</summary>
        /// <param name="supplier">The supplier.</param>
        /// <returns>Supplier</returns>
        /// <exception cref="System.ArgumentNullException">supplier</exception>
        /// <exception cref="System.InvalidOperationException">Supplier validation failed. {BuildValidationErrorMessage(ex)}
        /// or
        /// An unexpected error occurred while adding the supplier.</exception>
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
                throw new InvalidOperationException(
                   $"Supplier validation failed. {BuildValidationErrorMessage(ex)}", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    "An unexpected error occurred while adding the supplier.", ex);
            }
        }


        /// <summary>Deletes an existing supplier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>bool</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id - Supplier ID must be greater than zero.</exception>
        /// <exception cref="System.Collections.Generic.KeyNotFoundException">Supplier with ID {id} was not found.</exception>
        /// <exception cref="System.InvalidOperationException">An unexpected error occurred while deleting supplier with ID {id}.</exception>
        public bool DeleteSupplier(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Supplier ID must be greater than zero.");
            }

            try
            {
                var existingSupplier = GetSupplierById(id);
                if (existingSupplier == null)
                {
                    throw new KeyNotFoundException($"Supplier with ID {id} was not found.");
                }

                this.dbContext.Supplier.Remove(existingSupplier);
                this.dbContext.SaveChanges();
                return true;
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    $"An unexpected error occurred while deleting supplier with ID {id}.",
                    ex);
            }
        }


        /// <summary>Gets all suppliers.</summary>
        /// <returns>List<Supplier></returns>
        /// <exception cref="System.InvalidOperationException">An unexpected error occurred while retrieving suppliers.</exception>
        public List<Supplier> GetAllSuppliers()
        {
            try
            {
                return this.dbContext.Supplier
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    "An unexpected error occurred while retrieving suppliers.",
                    ex);
            }
        }


        /// <summary>Gets the supplier by identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Supplier</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id - Supplier ID must be greater than zero.</exception>
        /// <exception cref="System.InvalidOperationException">An unexpected error occurred while retrieving supplier with ID {id}.</exception>
        public Supplier GetSupplierById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Supplier ID must be greater than zero.");
            }

            try
            {
                return this.dbContext.Supplier
                    .FirstOrDefault(supplierEntity => supplierEntity.Id == id);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    $"An unexpected error occurred while retrieving supplier with ID {id}.", ex);
            }
        }


        /// <summary>Updates the supplier.</summary>
        /// <param name="supplier">The supplier.</param>
        /// <returns>Supplier</returns>
        /// <exception cref="System.ArgumentNullException">supplier - Supplier details are required.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Id - Supplier ID must be greater than zero.</exception>
        /// <exception cref="System.Collections.Generic.KeyNotFoundException">Supplier with ID {supplier.Id} was not found.</exception>
        /// <exception cref="System.InvalidOperationException">
        /// Supplier validation failed. {BuildValidationErrorMessage(ex)}
        /// or
        /// The supplier with ID {supplier.Id} could not be updated because the record was modified by another process.
        /// or
        /// An unexpected error occurred while updating supplier with ID {supplier.Id}.
        /// </exception>
        public Supplier UpdateSupplier(Supplier supplier)
        {
            if (supplier == null)
            {
                throw new ArgumentNullException(nameof(supplier), "Supplier details are required.");
            }

            if (supplier.Id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(supplier.Id), "Supplier ID must be greater than zero.");
            }

            try
            {
                var existingSupplier = GetSupplierById(supplier.Id);
                if (existingSupplier == null)
                {
                    throw new KeyNotFoundException($"Supplier with ID {supplier.Id} was not found.");
                }

                // Only update properties that should be changed
                this.dbContext.Entry(existingSupplier).CurrentValues.SetValues(supplier);
                this.dbContext.SaveChanges();

                // Reload to get any database-computed values
                this.dbContext.Entry(existingSupplier).Reload();
                return existingSupplier;
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (DbEntityValidationException ex)
            {
                throw new InvalidOperationException(
                    $"Supplier validation failed. {BuildValidationErrorMessage(ex)}", ex);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new InvalidOperationException(
                    $"The supplier with ID {supplier.Id} could not be updated because the record was modified by another process.", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    $"An unexpected error occurred while updating supplier with ID {supplier.Id}.", ex);
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


        /// <summary>Builds the validation error message.</summary>
        /// <param name="exception">The exception.</param>
        /// <returns>string</returns>
        private static string BuildValidationErrorMessage(DbEntityValidationException exception)
        {
            var validationMessages = exception.EntityValidationErrors
                .SelectMany(entityValidationResult => entityValidationResult.ValidationErrors)
                .Select(validationError => validationError.ErrorMessage)
                .ToList();

            return string.Join("; ", validationMessages);
        }
    }


}
