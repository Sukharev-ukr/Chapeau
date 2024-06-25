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
        public List<OrderItem> GetOrderDetails(int orderId)
        {
            string query = "SELECT Item.*, OrderItem.OrderID, OrderItem.ItemID, OrderItem.Count, OrderItem.[Status], OrderItem.StatusTime, OrderItem.Comment " +
                           "FROM Item " +
                           "JOIN OrderItem ON OrderItem.ItemID = Item.ItemID " +
                           "WHERE OrderItem.OrderID = @orderID";

            SqlParameter[] sp = new SqlParameter[1] { new SqlParameter("@orderID", orderId) };

            return ReadOrderMenuItems(ExecuteSelectQuery(query, sp));
        }
        /*public Dictionary<OrderItem, MenuItem> ReadOrderMenuItems(DataTable dataTable)
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
        }*/
        public List<OrderItem> ReadOrderMenuItems(DataTable dataTable)
        {
            List<OrderItem> orderDetails = new List<OrderItem>();
            MenuDAL menuDao = new MenuDAL();

            foreach (DataRow row in dataTable.Rows)
            {
                OrderItem orderItem = ReadDataRow(row);
                MenuItem menuItem = menuDao.ReadDataRow(row);
                if (orderItem != null && menuItem != null)
                {
                    orderItem.MenuItem = menuItem;
                    orderDetails.Add(orderItem);
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
                Comment = dr["Comment"] as string ?? "",
                MenuItem = new MenuItem()
            };
        }

        public List<OrderItem> GetOrderItemsByCategory(int orderId, string category)
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


        public List<OrderItem> GetAllOrdersItems()
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

        public void AddOrUpdateOrderItem(int orderId, int itemId, int quantity, string status, DateTime statusTime)
        {
            string checkQuery = "SELECT COUNT(*) FROM OrderItem WHERE OrderID = @orderId AND ItemID = @itemId";
            SqlParameter[] checkParameters = new SqlParameter[]
            {
        new SqlParameter("@orderId", orderId),
        new SqlParameter("@itemId", itemId)
            };
            DataTable result = ExecuteSelectQuery(checkQuery, checkParameters);

            if (result.Rows.Count > 0 && (int)result.Rows[0][0] == 0)
            {
                string insertQuery = "INSERT INTO OrderItem (OrderID, ItemID, Count, Status, StatusTime) VALUES (@orderId, @itemId, @quantity, @status, @statusTime)";
                SqlParameter[] insertParameters = new SqlParameter[]
                {
            new SqlParameter("@orderId", orderId),
            new SqlParameter("@itemId", itemId),
            new SqlParameter("@quantity", quantity),
            new SqlParameter("@status", status),
            new SqlParameter("@statusTime", statusTime)
                };
                ExecuteEditQuery(insertQuery, insertParameters);
            }
            else
            {
                UpdateQuantity(orderId, itemId, quantity);
            }
        }


        public void DeleteOrderItem(int orderId, int itemId)
        {
            string query = "DELETE FROM OrderItem WHERE OrderID = @orderId AND ItemID = @itemId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@orderId", orderId),
                new SqlParameter("@itemId", itemId)
            };
            ExecuteEditQuery(query, parameters);
        }

        public int GetQuantityByItemId(int orderId, int itemId)
        {
            string query = "SELECT Count FROM OrderItem WHERE OrderID = @orderId AND ItemID = @itemId";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@orderId", orderId),
        new SqlParameter("@itemId", itemId)
            };

            DataTable result = ExecuteSelectQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["Count"]);
            }
            else
            {
                return 0;
            }
        }

        public void UpdateOrderItemComment(int orderId, int itemId, string comment)
        {
            string query = "UPDATE OrderItem SET Comment = @comment WHERE OrderID = @orderId AND ItemID = @itemId";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@comment", comment),
        new SqlParameter("@orderId", orderId),
        new SqlParameter("@itemId", itemId)
            };
            ExecuteEditQuery(query, parameters);
        }

        public void DeleteOrderItems(int orderId)
        {
            string query = "DELETE FROM OrderItem WHERE OrderID = @orderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@orderId", orderId)
            };
            ExecuteEditQuery(query, parameters);
        }
    }
}
