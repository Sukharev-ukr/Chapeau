using DAL;
using Model;
using System.Collections.Generic;

public class OrderService
{
    private OrderDao orderDao;
    OrderItemDao orderItemDao;

    public OrderService()
    {
        orderDao = new OrderDao();
        orderItemDao = new OrderItemDao();
    }
    //public List<Order> GetOrders()
    //{
    //    List<Order> orders = orderDao.GetOrders();
    //    return orders;
    //}

    public List<Order> GetAllOrders()
    {
        List<Order> orders = orderDao.GetOrders();
        return orders;
    }

    //public List<Order> GetFilteredOrders()
    //{
    //    List<Order> orders = orderDao.GetFilteredOrders();
    //    foreach (var order in orders)
    //    {
    //        Dictionary<OrderItem, MenuItem> orderItems = orderItemDao.GetFilteredOrderItems(order.OrderId);
    //        order.Items = new List<OrderItem>(orderItems.Keys);
    //    }
    //    return orders;
    //}
}