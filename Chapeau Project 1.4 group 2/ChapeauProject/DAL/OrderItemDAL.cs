using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    // BillID,[TotalAmount],[VAT],[PaymentMethod],[OrderID]
    public class OrderItemDAL : BaseDAL
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
            MenuDAL menuDao = new MenuDAL();

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
                OrderStatus = Enum.Parse<Status>((string)dr["Status"], true),
                Count = (int)dr["Count"],
                OrderTime = dr["StatusTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["StatusTime"]),
                Comment = dr["Comment"]?.ToString(),
                MenuItem = new MenuItem()
            };
        }

        public Dictionary<OrderItem, MenuItem> GetOrderItemsByCategory(int orderId, string category)
        {
            string query = "SELECT O.*, I.*, OK.* " +
                           "FROM OrderItem AS O " +
                           "JOIN Item AS I ON O.ItemID = I.ItemID " +
                           "JOIN [Order] AS OK ON OK.OrderID = O.OrderID " +
                           "WHERE I.Category = @category AND OK.OrderID = @orderId";

            SqlParameter[] sp = new SqlParameter[]
            {
               new SqlParameter("@category", category),
               new SqlParameter("@orderId", orderId)
            };
            return ReadOrderMenuItems(ExecuteSelectQuery(query, sp));
        }


        public Dictionary<OrderItem, MenuItem> GetAllOrdersItems()
        {
            string query = "SELECT O.*, OI.*, I.* \r\nFROM [Order] AS O \r\n   JOIN [OrderItem] AS OI ON OI.OrderID = O.OrderID\r\n   JOIN [Item] AS I ON I.ItemID = OI.ItemID\r\n ";
            SqlParameter[] parameters = new SqlParameter[0];
            return ReadOrderMenuItems(ExecuteSelectQuery(query, parameters));
        }

        public void UpdateOrderItemStatus(OrderItem orderItem, string status)
        {

            string query = "UPDATE OrderItem SET [Status] = @status WHERE OrderID = @orderID AND ItemID = @ItemID";

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@status", status),
                new SqlParameter("@orderID", orderItem.OrderId),
                new SqlParameter("@ItemID", orderItem.ItemId)
            };

            ExecuteEditQuery(query, parameter);
        }

        public void UpdateQuantity(int orderId, int itemId, int quantity)
        {
            string query = "UPDATE OrderItem SET Count = @quantity WHERE OrderID = @orderId AND ItemID = @itemId";
            SqlParameter[] sqlParameters = new SqlParameter[3]
            {
                new SqlParameter("@quantity", quantity),
                new SqlParameter("@orderId", orderId),
                new SqlParameter("@itemId", itemId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
