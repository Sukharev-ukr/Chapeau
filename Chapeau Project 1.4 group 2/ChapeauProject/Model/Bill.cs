using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    enum PaymentMethod {Cash,Debit,Card }
    public class Bill
    {
        int BillId { get; set; }
        int OrderId { get; set; } 
        decimal TotalAmount { get; set; }
        decimal VAT {  get; set; }
        PaymentMethod PaymentMethod { get; set; }

    }
}
