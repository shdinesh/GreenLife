using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        public ProductCategoryRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public ProductCategoryRepository() : this(new GreenLifeDBContext())
        {
        }

        public ProductCategory AddNewProductCategory(ProductCategory productCategory)
        {
            if (productCategory == null)
                throw new ArgumentNullException(nameof(productCategory));

            try
            {
                this.dbContext.ProductCategories.Add(productCategory);
                this.dbContext.SaveChanges();
                return productCategory;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", errorMessages)}", ex);
            }
        }

        public bool DeleteProductCategory(int id)
        {
            var productCategory = GetProductCategoryById(id);
            if (productCategory == null)
                throw new ArgumentException($"Product Category with ID {id} not found.", nameof(id));

            this.dbContext.ProductCategories.Remove(productCategory);
            this.dbContext.SaveChanges();
            return true;
        }

        public List<ProductCategory> GetAllProductCategories()
        {
            return this.dbContext.ProductCategories
                .AsNoTracking()
                .ToList();
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            return this.dbContext.ProductCategories
                .FirstOrDefault(s => s.Id == id);
        }

        public ProductCategory UpdateProductCategory(ProductCategory productCategory)
        {
            if (productCategory == null)
                throw new ArgumentNullException(nameof(productCategory));

            var existingCategory = GetProductCategoryById(productCategory.Id);
            if (existingCategory == null)
                throw new ArgumentException($"Product Category with ID {productCategory.Id} not found.", nameof(productCategory.Id));

            try
            {
                // Only update properties that should be changed
                this.dbContext.Entry(existingCategory).CurrentValues.SetValues(productCategory);
                this.dbContext.SaveChanges();

                // Reload to get any database-computed values
                this.dbContext.Entry(existingCategory).Reload();
                return existingCategory;
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
                throw new InvalidOperationException("Concurrency conflict occurred while updating the Product Category.", ex);
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
