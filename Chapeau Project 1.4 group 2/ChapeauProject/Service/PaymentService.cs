using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

namespace Service
{
    public class PaymentService
    {

        public Dictionary<OrderItem, MenuItem> GetOrderDetails(int order)
        {
            OrderItemDao orderItemDal = new OrderItemDao();

            return orderItemDal.GetOrderDetails(order);
        }

        public class NewBill
        {


            public NewBill(List<decimal> billParts) 
            {
            }
        }

        public class CurrentOrder
        {
            private static CurrentOrder instance;

            public int orderId { get; private set; }
            public decimal OrderTotal;
            public Dictionary<OrderItem, MenuItem> orderDetail { get; private set; }

            private CurrentOrder(int currentorder) 
            {
                OrderItemDao orderItemDal = new OrderItemDao();
                orderId = currentorder;
                orderDetail = orderItemDal.GetOrderDetails(orderId);
            }
            public static CurrentOrder NewInstance(int newOrder)
            {
                instance = new CurrentOrder(newOrder);
                return instance;
            }
            public static CurrentOrder Getinstance()
            {
                if (instance == null)
                {
                    throw new Exception("PaymentSystem: No instance of currentOrder object");
                }
                return instance;
            }

        }

    }
}
