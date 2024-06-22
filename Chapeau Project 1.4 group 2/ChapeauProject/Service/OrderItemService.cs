using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderItemService
    {
        private OrderItemDAL orderItemDao;
        private OrderService orderService;

        public OrderItemService()
        {
            orderItemDao = new OrderItemDAL();
            orderService = new OrderService();
        }

        public List<OrderItem> GetOrderItemsByCategory(int orderId, string category)
        {
           return orderItemDao.GetOrderItemsByCategory(orderId, category);
            
        }

        public void UpdateOrderItemStatus(OrderItem orderItem, string status)
        {
            int orderId = orderService.GetCurrentOrderId();
            orderItemDao.UpdateOrderItemStatus(orderItem, status);
        }
        public List<OrderItem> GetOrderDetials(int id)
        {
            return orderItemDao.GetOrderDetails(id);
        }
    }
}
