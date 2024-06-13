using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetOrders()
        {
            string query = "SELECT OrderID, OrderTime, OrderStatus, StaffID, TableID, Feedback, TableNumber FROM [Order]";

            SqlParameter[] parameters = new SqlParameter[0];

            return ReadOrders(ExecuteSelectQuery(query, parameters));
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = CreateOrder(dr);

                orders.Add(order);
            }

            return orders;
        }

        private Order CreateOrder(DataRow dr)
        {
            return new Order()
            {
                OrderId = (int)dr["OrderID"],
                OrderTime = dr["OrderTime"] as DateTime?,
                Employee = new Employee()
                {
                    EmployeeId = (int)dr["StaffID"]
                },
                Table = new Table()
                {
                    TableId = (int)dr["TableID"],
                    TableNumber = (int)dr["TableNumber"]
                },
                Feedback = (string)dr["Feedback"],
                Items = GetOrderItems((int)dr["OrderID"])
            };
        }

        public List<OrderItem> GetOrderItems(int orderId)
        {
            string query = "SELECT OI.OrderID, OI.ItemID, OI.Count, OI.Status, OI.StatusTime, OI.comment " +
                           "FROM [OrderItem] AS OI " +
                           "WHERE OI.OrderID = @orderId";

            SqlParameter[] parameters =
            {
            new SqlParameter("@orderId", orderId)
            };

            List<OrderItem> orderItems = CreateOrderItems(query, parameters);
            return orderItems;
        }

        private List<OrderItem> CreateOrderItems(string query, SqlParameter[] parameters)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            DataTable dataTable = ExecuteSelectQuery(query, parameters);
            OrderItemDao orderItemDAL = new OrderItemDao();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = orderItemDAL.ReadDataRow(dr);

                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        //update status of Order
        public void UpdateOrderStatus(Order order, Status status)
        {
            string query = "UPDATE [Order] SET OrderStatus = @status WHERE OrderID = @order.OrderID";
           
            SqlParameter[] sqlParameters =
            {
              new SqlParameter("@order.OrderID", order),
              new SqlParameter("@status", status)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}