using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class OrderDAL : BaseDAL
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT OrderID, OrderTime, OrderStatus, StaffID, TableID, Feedback, TableNumber  " +
                           "FROM [Order]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
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
                OrderId = (int)dr["orderId"],
                OrderTime = (DateTime)dr["OrderTime"],
                Employee = new Employee()
                {
                    EmployeeId = (int)dr["StaffID"]
                },
                Table = new Table()
                {
                    tableId = (int)dr["TableID"],
                    tableNumber = (int)dr["TableNumber"]
                },
                Feedback = (string)dr["Feedback"],
                Items = GetOrderItems((Order)dr["OrderID"])
            };
        }

        public List<OrderItem> GetOrderItems(Order order)
        {
            string query = "SELECT OI.OrderID, OI.ItemID, OI.Count, OI.Status, OI.StatusTime, OI.comment " +
                           "FROM [OrderItem] AS OI  " +
                           "JOIN Item AS I ON OI.ItemID = I.ItemID " +
                           "WHERE OI.OrderID = @orderId; ";

            SqlParameter[] parameters =
            {
                new SqlParameter("@orderId", order.OrderId)
            };

            List<OrderItem> orderItems = CreateOrderItems(query, parameters);
            return orderItems;
        }

        private List<OrderItem> CreateOrderItems(string query, SqlParameter[] parameters)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            DataTable dataTable = ExecuteSelectQuery(query, parameters);

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = CreateOrderItem(dr);

                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        private static OrderItem CreateOrderItem(DataRow dr)
        {
            return new OrderItem()
            {
                OrderId = (int)dr["OrderID"],
                ItemId = (int)dr["ItemID"],
                OrderStatus = (Status)dr["Status"],
                Count = (int)dr["Count"],
                OrderTime = (string)dr["StatusTime"],
                Comment = (string)dr["Comment"],
                MenuItem = new MenuItem()
                {
                    Id = (int)dr["ItemID"],
                    Name = (string)dr["Name"],
                    Category = (Category)dr["Category"],
                    Card = (string)dr["Card"]
                }
            };
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
    }
}