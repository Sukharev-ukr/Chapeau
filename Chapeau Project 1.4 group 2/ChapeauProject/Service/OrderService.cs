using DAL;
using Model;
using System.Collections.Generic;

public class OrderService
{
    private OrderDAL orderDao;


    public OrderService()
    {
        orderDao = new OrderDAL();
    }

 Payment_sietse
        public List<MenuItem> GetMenuItemsByCard(string card)
        {
            return allMenuItems.Where(item => item.Card == card).ToList();
        }

        public void UpdateTipById(decimal input ,int id)
        {
            OrderDAL orderDAL = new OrderDAL();
            orderDAL.UpdateTipById(input ,id);
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
main
    }
}