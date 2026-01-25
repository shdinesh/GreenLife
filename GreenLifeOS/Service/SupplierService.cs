using GreenLifeOS.Repository;
using System;
using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository ?? throw new ArgumentNullException(nameof(supplierRepository));
        }

        public SupplierService() : this(new SupplierRepository())
        {
        }

        public Supplier AddNewSupplier(Supplier supplier)
        {
            if (supplier == null)
                throw new ArgumentNullException(nameof(supplier));

            // Business logic validation
            var validationResult = ValidateSupplier(supplier);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var result = supplierRepository.AddNewSupplier(supplier);
                return result;
            }
            catch (Exception ex)
            {
                // Log the exception (in a real application, use proper logging)
                // LogError($"Error adding new supplier: {ex.Message}", ex);
                throw new InvalidOperationException("An error occurred while adding the supplier. Please try again.", ex);
            }
        }


        public bool DeleteSupplier(int id)
        {
            try
            {
                // Business rule: Check if supplier exists before deletion
                var existingSupplier = GetSupplierById(id);
                if (existingSupplier == null)
                    throw new ArgumentException($"Supplier with ID {id} not found.", nameof(id));

                var result = supplierRepository.DeleteSupplier(id);
                return result;
            }
            catch (Exception ex)
            {
                // Log the exception
                // LogError($"Error deleting supplier with ID {id}: {ex.Message}", ex);

                throw new InvalidOperationException("An error occurred while deleting the supplier. Please try again.", ex);
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            try
            {
                var suppliers = supplierRepository.GetAllSuppliers();

                // Business logic: Filter out inactive suppliers if needed
                // return suppliers.Where(s => s.IsActive).ToList();

                return suppliers ?? new List<Supplier>();
            }
            catch (Exception ex)
            {
                // Log the exception
                // LogError($"Error retrieving all suppliers: {ex.Message}", ex);

                throw new InvalidOperationException("An error occurred while retrieving suppliers. Please try again.", ex);
            }
        }


        public Supplier GetSupplierById(int id)
        {
            try
            {
                var supplier = supplierRepository.GetSupplierById(id);

                // Business logic: Check if supplier is active
                if (supplier == null)
                    throw new ArgumentException($"Supplier with ID {id} not found.", nameof(id));

                return supplier;
            }
            catch (Exception ex)
            {
                // Log the exception
                // LogError($"Error retrieving supplier with ID {id}: {ex.Message}", ex);

                throw new InvalidOperationException("An error occurred while retrieving the supplier. Please try again.", ex);
            }
        }

        public Supplier UpdateSupplier(Supplier supplier)
        {

            // Business logic validation
            var validationResult = ValidateSupplier(supplier);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                // Business rule: Check if supplier exists
                var existingSupplier = GetSupplierById(supplier.Id);
                if (existingSupplier == null)
                    throw new ArgumentException($"Supplier with ID {supplier.Id} not found.", nameof(supplier.Id));


                var result = supplierRepository.UpdateSupplier(supplier);
                return result;
            }
            catch (Exception ex)
            {
                // Log the exception
                // LogError($"Error updating supplier with ID {supplier.Id}: {ex.Message}", ex);

                throw new InvalidOperationException("An error occurred while updating the supplier. Please try again.", ex);
            }
        }


        private ValidationResult ValidateSupplier(Supplier supplier)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }
    }

    internal class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; private set; } = new List<string>();

        public void AddError(string error)
        {
            Errors.Add(error);
            IsValid = false;
        }
    }

}
