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
using static Service.PaymentService;

namespace UI.PaymentSystem
{

    public partial class PaymentForm : Form
    {
        int partNumber;

        PaymentMethod paymentMethod;

        CurrentOrder currentOrder;
        BillParts billParts;

        public PaymentForm()
        {
            billParts = BillParts.Getinstance();

            currentOrder = CurrentOrder.Getinstance();
            partNumber = billParts.currentPart.BillId;
            Bill part = billParts.ListOFParts[partNumber];
            InitializeComponent();

            labelOrderNr.Text = currentOrder.orderId.ToString();
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
            BillSplitter billSplitter = new BillSplitter();
            Program.WindowSwitcher(this, billSplitter);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            billParts.ListOFParts[partNumber].PaymentMethod = paymentMethod;
            Checkout checkout = new Checkout(paymentMethod);
            Program.WindowSwitcher(this,checkout);
        }
    }
}
