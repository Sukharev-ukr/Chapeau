using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int tableId;
        public int orderId;
        public DateTime orderTime;
        public string orderStatus;
        public string feedback;
        public List<OrderItem> items;
        public Table table;
        public Employee employee;
    }
}
