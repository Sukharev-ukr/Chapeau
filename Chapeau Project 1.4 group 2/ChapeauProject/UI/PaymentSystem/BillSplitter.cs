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
            labelTotal.Text = currentOrder.OrderTotal.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            PaymentService.CurrentOrder current = PaymentService.CurrentOrder.Getinstance();

            Form newForm = new BillDetails(current.orderId);
            Program.WindowSwitcher(this,newForm);
        }
    }
}
