using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface IOrderService
    {
        Order AddNewOrder(Order order);
        List<OrderVo> GetAllOrders();
        List<ProductVo> GetAllLineItems(int orderId);
        Order GetOrderById(int id);
        Order UpdateOrder(Order order);
        bool DeleteOrder(int id);

    }
}
