using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class KitchenAndBarDAL : BaseDAL
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT OrderID, OrderTime, OrderStatus, StaffID, TableID, Feedback, TableNumber  " +
                           "FROM Order";

            System.Data.SqlClient.SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    orderId = (int)dr["orderId"],
                    orderTime = (DateTime)dr["OrderTime"],
                    orderStatus = (string)dr["OrderStatus"],
                    employee = new Employee()
                    {
                        employeeId = (int)dr["StaffID"]
                    },
                    table = new Table()
                    {
                        tableId = (int)dr["TableID"],
                        tableNumber = (int)dr["TableNumber"]
                    },
                    feedback = (string)dr["Feedback"],
                    items = GetOrderItems((int)dr["OrderID"])
                };

                orders.Add(order);
            }

            return orders;
        }

        public List<OrderItem> GetOrderItems(int orderId)
        {
            string query = "SELECT OI.OrderID, OI.ItemID, OI.Count, OI.Status, OI.StatusTime, OI.comment " +
                "FROM [OrderItem] AS OI  " +
                "JOIN Item AS I ON OI.ItemID = I.ItemID " +
                "WHERE OI.OrderID = @orderId; ";

            SqlParameter[] parameters =
            {
                new SqlParameter("@orderId", orderId)
            };

            List<OrderItem> orderItems = new List<OrderItem>();
            DataTable dataTable = ExecuteSelectQuery(query, parameters);

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    orderId = (int)dr["OrderID"],
                    itemId = (int)dr["ItemID"],
                    orderStatus = (string)dr["Status"],
                    count = (int)dr["Count"],
                    orderTime = (string)dr["StatusTime"],
                    comment = (string)dr["Comment"],
                    menuItem = new MenuItem()
                    {
                        id = (int)dr["ItemID"],
                        name = (string)dr["Name"],
                        category = (string)dr["Category"],
                        card = (string)dr["Card"]
                    }
                };

                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        public void ChangeStatus(int id, string OrderStatus)
        {
            string query = "UPDATE [Order] SET OrderStatus = @OrderStatus " +
                           "WHERE OrderID = @id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@OrderStatus", OrderStatus)
            };

            ExecuteEditQuery(query, parameters);
        }

        public List<Order> GetRunningFoodOrders()
        {
            string query = "SELECT O.OrderID, O.OrderTime, O.OrderStatus, O.StaffID, O.TableID, O.Feedback, O.TableNumber " +
                           "FROM Order AS O " +
                           "JOIN Table AS T ON O.TableID = T.TableID " +
                           "WHERE O.OrderStatus IN ('prepared', 'placed') AND O.OrderID IN (SELECT OI.OrderID FROM OrderItem AS OI JOIN Item AS I ON OI.ItemID = I.ItemID WHERE I.Category IS NOT 'Drinks')";

            SqlParameter[] parameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, parameters));
        }

        public List<Order> GetRunningDrinkOrders()
        {
            string query = "SELECT O.OrderID, O.OrderTime, O.OrderStatus, O.StaffID, O.TableID, O.Feedback, O.TableNumber " +
                           "FROM Order AS O " +
                           "JOIN Table AS T ON O.TableID = T.TableID " +
                           "WHERE O.OrderStatus IN ('prepared', 'placed') AND O.OrderID IN (SELECT OI.OrderID FROM OrderItem AS OI JOIN Item AS I ON OI.ItemID = I.ItemID WHERE I.Category = 'Drinks')";

            SqlParameter[] parameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, parameters));
        }
    }
}
