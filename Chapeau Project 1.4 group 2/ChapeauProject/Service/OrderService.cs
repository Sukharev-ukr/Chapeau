using DAL;
using Model;
using System.Collections.Generic;

public class OrderService
{
    private OrderDao orderDao;

    public OrderService()
    {
        orderDao = new OrderDao();
    }

    public List<Order> GetAllOrders()
    {
        List<Order> orders = orderDao.GetOrders();
        return orders;
    }
}