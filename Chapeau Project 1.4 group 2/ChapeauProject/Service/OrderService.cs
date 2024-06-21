using DAL;
using Model;
using System.Collections.Generic;

public class OrderService
{
    private OrderDAL orderDao;
    private OrderItemDAL orderItemDao;

    MenuDAL menuDAL;
    public List<MenuItem> allMenuItems;

    public OrderService()
    {
        menuDAL = new MenuDAL();
        orderDao = new OrderDAL();
        orderItemDao = new OrderItemDAL();
        allMenuItems = menuDAL.GetMenuItems();
    }


    public List<MenuItem> GetMenuItemsByCard(string card)
    {
        return allMenuItems.Where(item => item.Card == card).ToList();
    }



    public Order GetRunningOrderFromTable(int tableNr, int employeeId)
    {
        return orderDao.GetOrderFromTableNr(tableNr, employeeId);
}

    public Order GetStatusOrderByTableId(int tableNr,Status status)
    {
        return orderDao.GetStatusOrderByTableId(tableNr, Status.served);
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
        orderDao.UpdateOrderStatus(orderId, Status.served);
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

    public void DeleteOrder(int orderId)
    {
        orderDao.DeleteOrder(orderId);
    }
}

