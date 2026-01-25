using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface IProductService
    {
        Product AddNewProduct(Product Product);
        List<ProductVo> GetAllProducts();
        Product GetProductById(int id);
        Product UpdateProduct(Product Product);
        bool DeleteProduct(int id);
        void increaseAvailableStock(Stock stock);
        void decreaseAvailableStock(List<OrderItem> orderItems);


    }
}
