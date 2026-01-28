using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface IOrderService
    {
        Order AddNewOrder(Order order);
        List<OrderVo> GetAllOrders();
        List<OrderVo> GetAllOrdersByStatus(string status);
        List<ProductVo> GetAllLineItems(int orderId);
        Order UpdateOrder(Order order);
        Order UpdateOrderStatus(OrderVo orderVo);
        Order GetOrderById(int id);
        bool DeleteOrder(int id);

    }
}
