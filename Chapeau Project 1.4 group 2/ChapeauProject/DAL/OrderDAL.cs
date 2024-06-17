using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DAL
{
    public class OrderDAL : BaseDAL
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

        public Order GetOrderFromTableNr(int tableNR)
        {
            string query = "  SELECT * FROM [Order] WHERE TableID = @tableid AND OrderStatus = 'running'";

            SqlParameter[] parameters = new SqlParameter[1] { new SqlParameter("@tableid", tableNR) };
            return ReadOrders(ExecuteSelectQuery(query, parameters))[0];
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
            OrderItemDAL orderItemDAL = new OrderItemDAL();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = orderItemDAL.ReadDataRow(dr);

                orderItems.Add(orderItem);
            }

            return orderItems;
        }


        public void UpdateTipById(decimal Tip, int orderId)
        {
            string query = $"UPDATE [Order] SET [Order].TipAmount = @newvalue WHERE [Order].OrderID = @orderid";
            SqlParameter[] parameters = new SqlParameter[2] {
                new SqlParameter("@orderid", orderId),
                new SqlParameter("@newvalue",Tip)
            };
            ExecuteEditQuery(query, parameters);
        }
        public void UpdateTotalById(decimal Total, int orderId)
        {
            string query = $"UPDATE [Order] SET [Order].TotalAmount = @newvalue WHERE [Order].OrderID = @orderid";
            SqlParameter[] parameters = new SqlParameter[2] {
                new SqlParameter("@orderid", orderId),
                new SqlParameter("@newvalue",Total)
            };
            ExecuteEditQuery(query, parameters);
        }
        public List<Order> GetOrders(bool drinks, Status status)
        {
            string category = drinks ? "Category = 'Drink'" : "Category != 'Drinks'";

            string query = "SELECT O.OrderID, O.OrderTime, O.OrderStatus, O.StaffID, O.TableID, O.Feedback, O.TableNumber " +
                           "FROM Order AS O " +
                           "JOIN Table AS T ON O.TableID = T.TableID " +
                           "WHERE O.OrderStatus = @status AND @category";

            SqlParameter[] parameters =
            {
        new SqlParameter("@status", status),
        new SqlParameter("@category", category)
    };

            return ReadOrders(ExecuteSelectQuery(query, parameters));
        }


        //update status of Order
        public void UpdateOrderStatus(int orderId, Status status)
        {
            string query = "UPDATE [Order] SET OrderStatus = @status WHERE OrderID = @orderId";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@orderId", orderId),
                new SqlParameter("@status", status.ToString())
            };
            
            ExecuteEditQuery(query, sqlParameters);
        }

        public Order GetRunningOrderByTableId(int tableId) 
        {
            string query = "SELECT OrderID, OrderTime, OrderStatus, StaffID, TableID, Feedback, TableNumber " +
                           "FROM [Order] " +
                           "WHERE TableID = @tableId AND OrderStatus = @status";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tableId", tableId),
                new SqlParameter("@status", Status.running.ToString())
            };

            var orders = ReadOrders(ExecuteSelectQuery(query, parameters));
            return orders.FirstOrDefault();
        }

        public int GetCurrentOrderId()
        {
            string query = "SELECT MAX(OrderID) FROM [Order]";
            DataTable result = ExecuteSelectQuery(query, new SqlParameter[0]);
            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }
    }
}