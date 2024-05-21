using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        public int orderId;
        public int itemId;
        public string orderStatus;
        public string orderTime;
        public int count;
        public string comment;
        public MenuItem menuItem;
    }
}
