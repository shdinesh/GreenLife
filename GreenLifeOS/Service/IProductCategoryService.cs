using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface IProductCategoryService
    {
        ProductCategory AddNewProductCategory(ProductCategory productCategory);
        List<ProductCategory> GetAllProductCategories();
        ProductCategory GetProductCategoryById(int id);
        ProductCategory UpdateProductCategory(ProductCategory productCategory);
        bool DeleteProductCategory(int id);

    }
}
