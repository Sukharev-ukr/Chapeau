using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderTime { get; set; }
        public string? Feedback { get; set; }
        public List<OrderItem> Items { get; set; }
        public Status OrderStatus { get; set; }  // running or finished
        public Table Table { get; set; }
        public Employee Employee { get; set; }
    }
}
