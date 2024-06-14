using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum PaymentMethod {Cash,Debit,Credit }
    public class Bill
    {
        public int BillId { get; set; }
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal VAT {  get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
