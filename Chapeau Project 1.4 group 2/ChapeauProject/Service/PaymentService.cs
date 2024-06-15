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

        OrderDAL OrderDAL;
        OrderItemDAL orderItemDal;

        public PaymentService()
        {
            OrderDAL = new OrderDAL();
            orderItemDal = new OrderItemDAL();
        }

        public Dictionary<OrderItem, MenuItem> GetOrderDetails(int order)
        {
            return orderItemDal.GetOrderDetails(order);
        }

        public void UploadBill(List<Bill> billParts)
        {
            BillDAO billDAO = new BillDAO();
            foreach (Bill bill in billParts)
            {
                billDAO.UploadBill(bill);
            }
            billDAO.SetTableStateByOrderID(billParts[0].OrderId,TableStatus.free);
        }



        public class BillParts
        {
            public List<Bill> ListOFParts;
            int OrderId;
            public Bill currentPart;

            private static BillParts instance;

            private BillParts()
            {
                OrderId = CurrentOrder.Getinstance().orderId;
                ListOFParts = new List<Bill>();
            }
            public void AddBillPart(int partId, decimal partCost)
            {
                Bill part = new Bill();
                part.OrderId = OrderId;
                part.BillId = partId;
                part.TotalAmount = partCost;

                ListOFParts.Add(part);

                if (currentPart == null) { currentPart = part; }
            }
            public void IncrementParts()
            {
               if (currentPart.BillId != ListOFParts.Last().BillId)
                {
                    currentPart = ListOFParts[currentPart.BillId+1];
                } 
            }

            public static BillParts Getinstance()
            {
                if (instance == null)
                {
                    instance = new BillParts();
                }
                return instance;
            }

        }

        public class CurrentOrder
        {
            private static CurrentOrder instance;

            public int orderId { get; private set; }
            public decimal OrderTotal;
            public string Comment {  get; set; }
            public decimal Tip { get; private set; }

            public Dictionary<OrderItem, MenuItem> orderDetail { get; private set; }

            private CurrentOrder(int currentorder) 
            {
                OrderItemDAL orderItemDal = new OrderItemDAL();
                orderId = currentorder;
                orderDetail = orderItemDal.GetOrderDetails(orderId);
            }
            public void AddTip(decimal tip)
            {
                Tip += tip;
                OrderTotal += tip;
            }
            
            public static CurrentOrder Getinstance(int newOrder)
            {
                if (instance == null)
                {
                    instance = new CurrentOrder(newOrder);
                }
                return instance;
            }
            public static CurrentOrder Getinstance()
            {
                return instance;
            }
            public static void DestoryInstance()
            {
                instance = null;
            }

        }

    }
}
