using System.Collections.Generic;

namespace GreenLifeOS.Repository
{
    internal interface IOrderRepository
    {
        Order AddNewOrder(Order order);
        Order UpdateOrder(Order order);
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        bool DeleteOrder(int id);

    }
}
