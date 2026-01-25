using GreenLifeOS.Repository;
using System;
using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository productCategoryRepository;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository)
        {
            this.productCategoryRepository = productCategoryRepository ?? throw new ArgumentNullException(nameof(productCategoryRepository));
        }

        public ProductCategoryService() : this(new ProductCategoryRepository())
        {
        }

        public ProductCategory AddNewProductCategory(ProductCategory productCategory)
        {
            if (productCategory == null)
                throw new ArgumentNullException(nameof(productCategory));

            var validationResult = ValidateProductCategory(productCategory);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var result = productCategoryRepository.AddNewProductCategory(productCategory);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while adding the product category. Please try again.", ex);
            }
        }


        public bool DeleteProductCategory(int id)
        {
            try
            {
                var existingproductCategory = GetProductCategoryById(id);
                if (existingproductCategory == null)
                    throw new ArgumentException($"product category with ID {id} not found.", nameof(id));

                var result = productCategoryRepository.DeleteProductCategory(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the product category. Please try again.", ex);
            }
        }

        public List<ProductCategory> GetAllProductCategories()
        {
            try
            {
                var categories = productCategoryRepository.GetAllProductCategories();

                return categories ?? new List<ProductCategory>();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving product categorys. Please try again.", ex);
            }
        }


        public ProductCategory GetProductCategoryById(int id)
        {
            try
            {
                var category = productCategoryRepository.GetProductCategoryById(id);

                if (category == null)
                    throw new ArgumentException($"product category with ID {id} not found.", nameof(id));

                return category;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving the product category. Please try again.", ex);
            }
        }

        public ProductCategory UpdateProductCategory(ProductCategory productCategory)
        {

            var validationResult = ValidateProductCategory(productCategory);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var existingCategory = GetProductCategoryById(productCategory.Id);
                if (existingCategory == null)
                    throw new ArgumentException($"product category with ID {productCategory.Id} not found.", nameof(productCategory.Id));


                var result = productCategoryRepository.UpdateProductCategory(productCategory);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while updating the product category. Please try again.", ex);
            }
        }


        private ValidationResult ValidateProductCategory(ProductCategory productCategory)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }
    }


}
