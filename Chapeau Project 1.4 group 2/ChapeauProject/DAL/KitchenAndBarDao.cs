using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KitchenAndBarDao : BaseDao
    {
        public void ChangeStatus(int id, string OrderStatus)
        {
            string query = "UPDATE [OrderItem] SET OrderStatus = @OrderStatus " +
                           "WHERE OrderID = @id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@id", id),
                new SqlParameter("@OrderStatus", OrderStatus)
            };

            ExecuteEditQuery(query, parameters);
        }
    }
}
