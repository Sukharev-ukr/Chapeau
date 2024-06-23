using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        private decimal _totalAmount;

        public int OrderId { get; set; }
        public DateTime? OrderTime { get; set; }
        public decimal TotalAmount { get { return _totalAmount; } set { _totalAmount = Math.Round(value, 2); } }
        public decimal TipAmount { get; set; }
        public decimal VAT { get; set; }
        public string? Feedback { get; set; }
        public List<OrderItem> Items { get; set; }
        public Status OrderStatus { get; set; }  // running or finished
        public Table Table { get; set; }
        public Employee Employee { get; set; }
        public int TableNumber { get; set; }
    }
}
