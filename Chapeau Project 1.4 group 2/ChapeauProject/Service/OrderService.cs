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
    public List<MenuItem> GetAllMenuItems()
    {
        return allMenuItems;
    }

    public List<MenuItem> GetMenuItemsByCard(string card)
    {
        return allMenuItems.Where(item => item.Card == card).ToList();
    }

    public void UpdateTipById(decimal input, int id)
    {
        OrderDAL orderDAL = new OrderDAL();
        orderDAL.UpdateTipById(input, id);
    }
    public void UpdateTotalById(decimal input, int id)
    {
        OrderDAL orderDAL = new OrderDAL();
        orderDAL.UpdateTotalById(input, id);
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

    public void MarkOrderAsServed(int orderId)
    {
        orderDao.UpdateOrderStatus(orderId, Status.finished);
    }
}