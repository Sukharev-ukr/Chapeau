using DAL;
using Model;
using System.Collections.Generic;

public class OrderService
{
    private OrderItemDao orderItemDao;
    private OrderDao orderDao;

    public OrderService()
    {
        orderItemDao = new OrderItemDao();
        orderDao = new OrderDao();
    }
    public List<Order> GetOrders()
    {
        OrderDao orderDao = new OrderDao();
        List<Order> orders = orderDao.GetOrders();
        return orders;
    }

    public List<OrderItem> GetOrderItems(int orderId)
    {
        Dictionary<OrderItem, MenuItem> itemOrders = orderItemDao.GetOrderDetails(orderId);
        return new List<OrderItem>(itemOrders.Keys);
    }
}