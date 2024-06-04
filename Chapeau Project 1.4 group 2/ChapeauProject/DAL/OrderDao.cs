﻿using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetOrders(bool drinks, Status status)
        {
            string category = drinks ? "Category = 'Drink'" : "Category != 'Drinks'";

            string query = "SELECT O.OrderID, O.OrderTime, O.OrderStatus, O.StaffID, O.TableID, O.Feedback, O.TableNumber " +
                           "FROM Order AS O " +
                           "JOIN Table AS T ON O.TableID = T.TableID " +
                           "WHERE O.OrderStatus = @status AND" + category;

            SqlParameter[] parameters =
            {
                new SqlParameter("@status", status)
            };

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
                OrderId = (int)dr["orderId"],
                OrderTime = dr["OrderTime"] as DateTime?,
                Employee = new Employee()
                {
                    EmployeeId = (int)dr["StaffID"]
                },
                Table = new Table()
                {
                    TableId = (int)dr["TableID"],
                    TableNumber = (int)dr["number"]
                },
                Feedback = (string)dr["Feedback"],
                Items = GetOrderItems((int)dr["OrderID"])
            };
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
    }
}