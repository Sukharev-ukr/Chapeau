using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public Status OrderStatus { get; set; }
        public DateTime? OrderTime { get; set; }
        public int Count { get; set; }
        public string? Comment { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
