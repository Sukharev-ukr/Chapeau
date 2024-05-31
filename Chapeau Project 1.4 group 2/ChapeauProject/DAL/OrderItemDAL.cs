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
            string query = "SELECT * FROM Item " +
                           "JOIN OrderItem ON OrderItem.ItemID = Item.ItemID " +
                           "Where OrderItem.OrderID = @orderID";
            SqlParameter[] sp = new SqlParameter[1] { new SqlParameter("@orderID", orderId) };

            return ReadOrderMenuItems(ExecuteSelectQuery(query, sp));
        }

        public Dictionary<OrderItem,MenuItem> ReadOrderMenuItems (DataTable dr)
        {

            Dictionary<OrderItem, MenuItem> orderDetails = new Dictionary<OrderItem, MenuItem>();

            MenuDAL menuDAL = new MenuDAL();
            OrderItemDAL orderItemDAL = new OrderItemDAL();

            foreach (DataRow drRow in dr.Rows)
            {
                orderDetails.Add(orderItemDAL.ReadDataRow(drRow), menuDAL.ReadDataRow(drRow));
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
                OrderTime = dr["StatusTime"].ToString(),
                Comment = (string)dr["Comment"],
            };
        }
    }
}
