using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAO : BaseDAL
    {
        public void SaveBill(Bill bill)
        {
            string query = "INSERT INTO bill VALUES ( @totalamount, @VAT, @paymentmethod, @orderid)";

            SqlParameter[] sqlParameters = new SqlParameter[4] { 
                new SqlParameter("@orderid",bill.OrderId),
                new SqlParameter("@totalamount", bill.TotalAmount),
                new SqlParameter("@VAT",bill.VAT),
                new SqlParameter("@paymentmethod", bill.PaymentMethod.ToString())
            };
            ExecuteAddQuery(query, sqlParameters);
        }

        public void SetTableStateByOrderID(int orderID,TableStatus status)
        {
            string query = "UPDATE [Table] SET [Table].status = @status " +
                "WHERE [Table].TableID = " +
                "(SELECT [Table].TableID FROM [TABLE] JOIN [Order] on [Order].TableID = [Table].TableID WHERE [Order].OrderID = @orderid)";

            SqlParameter[] sqlParameters = new SqlParameter[2] {
                new SqlParameter("@status",status.ToString()),
                new SqlParameter("@orderid",orderID)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        }
    }

