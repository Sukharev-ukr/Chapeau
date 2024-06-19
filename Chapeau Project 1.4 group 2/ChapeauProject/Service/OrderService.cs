using DAL;
using Model;
using System.Collections.Generic;

public class OrderService
{
    private OrderDAL orderDao;

    MenuDAL menuDAL;
    public List<MenuItem> allMenuItems;

    public OrderService()
    {
        menuDAL = new MenuDAL();
        orderDao = new OrderDAL();
        allMenuItems = menuDAL.GetMenuItems();
    }


    public List<MenuItem> GetMenuItemsByCard(string card)
    {
        return allMenuItems.Where(item => item.Card == card).ToList();
    }

    public List<Order> GetAllOrders()
    {
        List<Order> orders = orderDao.GetOrders();
        return orders;
    }

    public Order GetRunningOrder(int tableId)
    {
        return orderDao.GetRunningOrderByTableId(tableId);
    }


    public Order GetStatusOrder(int tableId,Status status)
    {
        return orderDao.GetStatusOrderByTableId(tableId,status);
    }
    public void MarkOrderAsServed(int orderId)
    {
        orderDao.UpdateOrderStatus(orderId, Status.finished);
    }

    public int GetCurrentOrderId()
    {
        return orderDao.GetCurrentOrderId();
    }

    public void UpdateOrder(Order order)
    {
        orderDao.UpdateOrder(order);
    }
}
