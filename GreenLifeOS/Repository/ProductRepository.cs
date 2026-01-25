using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        public ProductRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public ProductRepository() : this(new GreenLifeDBContext())
        {
        }

        public Product AddNewProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            try
            {
                this.dbContext.Products.Add(product);
                this.dbContext.SaveChanges();
                return product;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", errorMessages)}", ex);
            }
        }

        public bool DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product == null)
                throw new ArgumentException($"Product with ID {id} not found.", nameof(id));

            this.dbContext.Products.Remove(product);
            this.dbContext.SaveChanges();
            return true;
        }

        public List<Product> GetAllProducts()
        {
            return this.dbContext.Products
                .AsNoTracking()
                .ToList();
        }

        public Product GetProductById(int id)
        {
            return this.dbContext.Products
                .FirstOrDefault(s => s.Id == id);
        }

        public Product UpdateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            var existingProduct = GetProductById(product.Id);
            if (existingProduct == null)
                throw new ArgumentException($"Product with ID {product.Id} not found.", nameof(product.Id));

            try
            {
                this.dbContext.Entry(existingProduct).CurrentValues.SetValues(product);
                this.dbContext.SaveChanges();

                this.dbContext.Entry(existingProduct).Reload();
                return existingProduct;
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
                throw new InvalidOperationException("Concurrency conflict occurred while updating the Product.", ex);
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
