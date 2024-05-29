using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;
using Service;

namespace UI.PaymentSystem
{
    public partial class BillSplitter : Form
    {
        public BillSplitter()
        {
            InitializeComponent();
            PaymentService.CurrentOrder currentOrder = PaymentService.CurrentOrder.Getinstance();
            LabelOrderNR.Text = currentOrder.orderDetail.Keys.First().OrderId.ToString();
        }
    }
}
