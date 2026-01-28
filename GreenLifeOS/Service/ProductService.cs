using GreenLifeOS.Model;
using GreenLifeOS.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GreenLifeOS.Service
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public ProductService() : this(new ProductRepository())
        {
        }

        public Product AddNewProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            var validationResult = ValidateProduct(product);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var result = productRepository.AddNewProduct(product);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while adding the product. Please try again.", ex);
            }
        }


        public bool DeleteProduct(int id)
        {
            try
            {
                var existingProduct = GetProductById(id);
                if (existingProduct == null)
                    throw new ArgumentException($"product with ID {id} not found.", nameof(id));

                var result = productRepository.DeleteProduct(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the product. Please try again.", ex);
            }
        }

        public List<ProductVo> GetAllProducts()
        {
            try
            {
                var products = productRepository.GetAllProducts()
                               ?? Enumerable.Empty<Product>();

                return products.Select(MapToProductVo).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving products. Please try again.", ex);
            }
        }

        public List<ProductVo> SearchProduct(int categoryId, string name, double minPrice, double maxPrice)
        {
            try
            {
                var products = productRepository.SearchProduct(categoryId, name, minPrice,maxPrice)
                               ?? Enumerable.Empty<Product>();

                return products.Select(MapToProductVo).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving products. Please try again.", ex);
            }
        }

        private static ProductVo MapToProductVo(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            return new ProductVo
            {
                Id = product.Id,
                Name = product.Name,
                Code = product.Code,
                Category = product.Category?.Name ?? string.Empty,
                SellingPrice = product.SellingPrice,
                CategoryId = product.Category?.Id ?? 0,
                Description = product.Description,
                AvailableStock = product.AvailableStock?.Quantity ?? 0
            };
        }


        public Product GetProductById(int id)
        {
            try
            {
                var product = productRepository.GetProductById(id);

                if (product == null)
                    throw new ArgumentException($"product with ID {id} not found.", nameof(id));

                return product;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving the product. Please try again.", ex);
            }
        }

        public Product UpdateProduct(Product Product)
        {

            var validationResult = ValidateProduct(Product);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var existingProduct = GetProductById(Product.Id);
                if (existingProduct == null)
                    throw new ArgumentException($"product with ID {Product.Id} not found.", nameof(Product.Id));

                var result = productRepository.UpdateProduct(Product);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while updating the product. Please try again.", ex);
            }
        }


        private ValidationResult ValidateProduct(Product Product)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }

        public void increaseAvailableStock(Stock stock)
        {
            if (stock == null)
                throw new ArgumentNullException(nameof(stock));

            var product = GetProductById((int)stock.ProductId)
                          ?? throw new InvalidOperationException("Product not found.");

            var availableStock = product.AvailableStock
                                 ?? new ProductAvailableStock
                                 {
                                     ProductId = product.Id
                                 };

            availableStock.Quantity += stock.StockQty;
            availableStock.LastUpdated = DateTime.Now;

            product.AvailableStock = availableStock;

            UpdateProduct(product);
        }

        public void decreaseAvailableStock(List<OrderItem> orderItems)
        {
            foreach (var item in orderItems)
            {
                if (item == null)
                    throw new ArgumentNullException(nameof(item));

                var product = GetProductById((int)item.ProductId)
                              ?? throw new InvalidOperationException("Product not found.");

                var availableStock = product.AvailableStock
                                     ?? new ProductAvailableStock
                                     {
                                         ProductId = product.Id
                                     };

                availableStock.Quantity -= item.OrderQty;
                availableStock.LastUpdated = DateTime.Now;

                product.AvailableStock = availableStock;

                UpdateProduct(product);


            }
        }
    }


}
