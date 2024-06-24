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

        public void AddOrUpdateOrderItem(int orderId, int itemId, int quantity, string status, DateTime statusTime)
        {
            orderItemDao.AddOrUpdateOrderItem(orderId, itemId, quantity, status, statusTime);
        }

        public void UpdateQuantity(int orderId, int itemId, int quantity)
        {
            orderItemDao.UpdateQuantity(orderId, itemId, quantity);
        }

        public void DeleteOrderItem(int orderId, int itemId)
        {
            orderItemDao.DeleteOrderItem(orderId, itemId);
        }
    }
}
