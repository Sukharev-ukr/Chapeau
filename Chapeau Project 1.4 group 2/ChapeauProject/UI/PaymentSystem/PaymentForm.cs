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


namespace UI.PaymentSystem
{

    public partial class PaymentForm : Form
    {
        int partNumber;

        PaymentMethod paymentMethod;

        Order currentOrder;
        List<Bill> billParts;

        public PaymentForm(List<Bill> parts, Order order)
        {
            billParts = parts;
            currentOrder = order;

            partNumber = 0;
            Bill part = billParts[partNumber];
            InitializeComponent();

            labelOrderNr.Text = currentOrder.OrderId.ToString();
            //magic value?
            labelPart.Text = (partNumber + 1).ToString();
            labelPartCost.Text = part.TotalAmount.ToString();
        }

        private void radioButtonCredit_CheckedChanged(object sender, EventArgs e)
        {
            paymentMethod = PaymentMethod.Credit;
        }

        private void radioButtonDebit_CheckedChanged(object sender, EventArgs e)
        {
            paymentMethod = PaymentMethod.Debit;
        }

        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            paymentMethod = PaymentMethod.Cash;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            BillSplitter billSplitter = new BillSplitter(currentOrder);
            Program.WindowSwitcher(this, billSplitter);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            billParts[partNumber].PaymentMethod = paymentMethod;
            Checkout checkout = new Checkout(billParts,partNumber,currentOrder);
            Program.WindowSwitcher(this, checkout);
        }
    }
}
