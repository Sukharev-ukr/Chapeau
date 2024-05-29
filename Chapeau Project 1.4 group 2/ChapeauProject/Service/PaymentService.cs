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
            OrderItemDAL orderItemDal = new OrderItemDAL();

            return orderItemDal.GetOrderDetails(order);
        }

        //create new object that will be passed to the db

        public class CurrentOrder
        {
            private static CurrentOrder instance;



            public int orderId { get; private set; }
            public decimal OrderTotal;
            public Dictionary<OrderItem, MenuItem> orderDetail { get; private set; }

            private CurrentOrder(int currentorder) 
            {
                OrderItemDAL orderItemDal = new OrderItemDAL();
                orderId = currentorder;
                orderDetail = orderItemDal.GetOrderDetails(orderId);
            }


           
            public static CurrentOrder Getinstance(int newOrder)
            {
                if (instance == null)
                {
                    instance = new CurrentOrder(newOrder);
                }
                return instance;
            }

            //might be a bit redundant
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
