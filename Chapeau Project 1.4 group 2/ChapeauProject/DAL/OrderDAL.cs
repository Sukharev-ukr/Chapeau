﻿using System;
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
            string query = "SELECT OrderID, OrderTime, OrderStatus, StaffID, TableID, Feedback, TableNumber, TotalAmount, VAT, TipAmount FROM [Order] WHERE CAST(OrderTime AS DATE) = CAST(GETDATE() AS DATE) AND OrderStatus != 'finished' AND OrderStatus != 'served';";

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
                    EmployeeId = (int)dr["StaffID"],
                },
                Table = new Table()
                {
                    TableId = (int)dr["TableID"],
                    TableNumber = (int)dr["TableNumber"]
                },
                Feedback = (string)dr["Feedback"],
                // Null-coalesce. if dr[""] as decimal? = null, using ?? sets its to value 0
                TotalAmount = dr["TotalAmount"] as decimal? ?? 0,
                TipAmount = dr["TipAmount"] as decimal? ?? 0,
                VAT = dr["VAT"] as decimal? ?? 0,
                OrderStatus = (Status)Enum.Parse(typeof(Status), (string)dr["OrderStatus"]),
                Items = GetOrderItems((int)dr["OrderID"])
            };
        }


        public Order GetOrderFromTableNr(int tableNR, int employeeId)
        {
            string query = "SELECT * FROM [Order] WHERE TableID = @tableid AND OrderStatus = 'running'";
            SqlParameter[] parameters = new SqlParameter[1] { new SqlParameter("@tableid", tableNR) };
            var orders = ReadOrders(ExecuteSelectQuery(query, parameters));

            if (orders.Count == 0)
            {
                return CreateNewOrderForTable(tableNR, employeeId);
            }
            else
            {
                return orders[0];
            }
        }



        public Order CreateNewOrderForTable(int tableNR, int employeeId)
        {
            DateTime orderTime = DateTime.Now;

            string idQuery = "SELECT ISNULL(MAX(OrderID), 0) FROM [Order]";
            int maxOrderId = (int)ExecuteScalarQuery(idQuery);
            int newOrderId = maxOrderId + 1;

            string insertQuery = "INSERT INTO [Order] (OrderID, OrderTime, TableID, StaffID, OrderStatus, Feedback, TableNumber) VALUES (@orderId, @orderTime, @tableid, @staffId, @orderStatus, @feedback, @tableNumber)";
            SqlParameter[] insertParameters = new SqlParameter[]
            {
        new SqlParameter("@orderId", newOrderId),
        new SqlParameter("@orderTime", orderTime),
        new SqlParameter("@tableid", tableNR),
        new SqlParameter("@staffId", employeeId),
        new SqlParameter("@orderStatus", "running"),
        new SqlParameter("@feedback", "..."),
        new SqlParameter("@tableNumber", tableNR)
            };

            ExecuteInsertQuery(insertQuery, insertParameters);

            Order newOrder = new Order()
            {
                OrderId = newOrderId,
                OrderTime = orderTime,
                Employee = new Employee() { EmployeeId = employeeId },
                Table = new Table() { TableId = tableNR },
                Items = new List<OrderItem>(),
                OrderStatus = Status.running,
                Feedback = "...",
                TableNumber = tableNR
            };

            return newOrder;
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

        public void UpdateOrder(Order order)
        {
            string query = "UPDATE [Order] SET OrderStatus = 'finished'  ,TotalAmount = @totalamount, TipAmount = @tipamount, Feedback = @feedback, VAT = @vat " +
                " WHERE OrderID = @orderId";

            SqlParameter[] sqlParameters = {
                new SqlParameter("@totalamount" , order.TotalAmount),
                new SqlParameter("@tipamount",order.TipAmount),
                new SqlParameter("@feedback", order.Feedback),
                new SqlParameter("@vat", order.VAT),
                new SqlParameter("@orderId", order.OrderId)
                                            };
            ExecuteEditQuery(query, sqlParameters);
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
            string query = "SELECT OrderID, OrderTime, OrderStatus, StaffID, TableID, Feedback, TableNumber, TotalAmount, VAT, TipAmount " +
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

        public Order GetStatusOrderByTableId(int tableId,Status status)
        {
            string query = "SELECT OrderID, OrderTime, OrderStatus, StaffID, TableID, Feedback, TableNumber, TotalAmount, VAT, TipAmount " +
                           "FROM [Order] " +
                           "WHERE TableID = @tableId AND OrderStatus = @status";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tableId", tableId),
                new SqlParameter("@status", status.ToString())
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

            
        public void DeleteOrder(int orderId)
        {
            string query = "DELETE FROM [Order] WHERE OrderID = @orderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@orderId", orderId)
            };
            ExecuteEditQuery(query, parameters);
        }

        public Order GetReadyOrderByTableId(int tableId)
        {
            string query = "SELECT OrderID, OrderTime, OrderStatus, StaffID, TableID, Feedback, TableNumber , TotalAmount, TipAmount, VAT " +
                           "FROM [Order] " +
                           "WHERE TableID = @tableId AND OrderStatus = @status";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tableId", tableId),
                new SqlParameter("@status", Status.ready.ToString())
            };

            var orders = ReadOrders(ExecuteSelectQuery(query, parameters));
            return orders.FirstOrDefault();

        }

        
    }
}