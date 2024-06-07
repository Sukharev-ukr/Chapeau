using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    // BillID,[TotalAmount],[VAT],[PaymentMethod],[OrderID]
    public class OrderItemDao : BaseDao
    {
        public Dictionary<OrderItem, MenuItem> GetOrderDetails(int orderId)
        {
            string query = "SELECT Item.*, OrderItem.OrderID, OrderItem.ItemID, OrderItem.Count, OrderItem.[Status], OrderItem.StatusTime, OrderItem.Comment " +
                        "FROM Item " +
                        "JOIN OrderItem ON OrderItem.ItemID = Item.ItemID " +
                        "WHERE OrderItem.OrderID = @orderID";

            SqlParameter[] sp = new SqlParameter[1] { new SqlParameter("@orderID", orderId) };

            return ReadOrderMenuItems(ExecuteSelectQuery(query, sp));
        }

        public Dictionary<OrderItem, MenuItem> ReadOrderMenuItems(DataTable dataTable)
        {
            Dictionary<OrderItem, MenuItem> orderDetails = new Dictionary<OrderItem, MenuItem>();
            MenuDao menuDao = new MenuDao();

            foreach (DataRow row in dataTable.Rows)
            {
                OrderItem orderItem = ReadDataRow(row);
                MenuItem menuItem = menuDao.ReadDataRow(row);
                if (orderItem != null && menuItem != null)
                {
                    orderItem.MenuItem = menuItem;
                    orderDetails.Add(orderItem, menuItem);
                }
            }

            return orderDetails;
        }

        public OrderItem ReadDataRow(DataRow dr)
        {
            return new OrderItem()
            {
                OrderId = (int)dr["OrderID"],
                ItemId = (int)dr["ItemID"],
                OrderStatus = Enum.Parse<Status>((string)dr["Status"]),
                Count = (int)dr["Count"],
                OrderTime = dr["StatusTime"]?.ToString(),
                Comment = (string)dr["Comment"],
                MenuItem = new MenuItem()
            };
        }
    }
}
