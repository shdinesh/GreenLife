using System.Collections.Generic;

namespace GreenLifeOS.Repository
{
    internal interface IProductCategoryRepository
    {
        ProductCategory AddNewProductCategory(ProductCategory productCategory);
        ProductCategory UpdateProductCategory(ProductCategory productCategory);
        List<ProductCategory> GetAllProductCategories();
        ProductCategory GetProductCategoryById(int id);
        bool DeleteProductCategory(int id);


    }
}
