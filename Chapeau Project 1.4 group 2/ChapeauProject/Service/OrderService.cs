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

    public Order GetStatusOrderByTableId(int tableNr,Status status)
    {
        return orderDao.GetStatusOrderByTableId(tableNr, Status.served);
    }

    public void UpdateTipById(decimal input, int id)
    {
        orderDao.UpdateTipById(input, id);
    }
    public void UpdateTotalById(decimal input, int id)
    {
        orderDao.UpdateTotalById(input, id);
    }

    public List<Order> GetAllOrders()
    {
        List<Order> orders = orderDao.GetOrders();
        return orders;
    }

    public void UpdateOrderStatus(int ID, Status status)
    {
        orderDao.UpdateOrderStatus(ID, status);

    }

    public Order GetRunningOrder(int tableId)
    {
        return orderDao.GetRunningOrderByTableId(tableId);
    }

    public Order GetReadyOrder(int tableId)
    {
        return orderDao.GetReadyOrderByTableId(tableId);
    }

    public Order GetStatusOrder(int tableId,Status status)
    {
        return orderDao.GetStatusOrderByTableId(tableId,status);
    }
    public void MarkOrderAsServed(int orderId)
    {
        orderDao.UpdateOrderStatus(orderId, Status.finished);
    }
    public List<OrderItem> GetOrderItemsByOrderId(int orderId)
    {
        return orderDao.GetOrderItems(orderId);
    }

    public int GetCurrentOrderId()
    {
        return orderDao.GetCurrentOrderId();
    }
}
