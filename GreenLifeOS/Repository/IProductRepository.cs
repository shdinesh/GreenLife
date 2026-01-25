using System.Collections.Generic;

namespace GreenLifeOS.Repository
{
    internal interface IProductRepository
    {
        Product AddNewProduct(Product product);
        Product UpdateProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        bool DeleteProduct(int id);

    }
}
