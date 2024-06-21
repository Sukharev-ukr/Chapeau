
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
using System.Diagnostics.Eventing.Reader;


namespace UI.PaymentSystem
{
    public partial class BillSplitter : Form
    {
        private decimal remainingAmount;
        Order currentOrder;


        // holds individual cost of each part.
        public List<decimal> billPartCost;


        public decimal RemainingAmount { get { return currentOrder.TotalAmount - billPartCost.Sum(); } }

        public BillSplitter(Order order)
        {
            currentOrder = order;
            billPartCost = new List<decimal>();

            InitializeComponent();
            labelTotal.Text = currentOrder.TotalAmount.ToString("F");
            labelRemainingTotal.Text = labelTotal.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            Form newForm = new BillDetails(currentOrder);
            Program.WindowSwitcher(this, newForm);
        }

        private void buttonCustomSplit_Click(object sender, EventArgs e)
        {
            billPartCost.Add(0);
            UserControlSplitBill billPart = new UserControlSplitBill(currentOrder,this,flowLayoutPanelSplit.Controls.Count);
            CustomSplit newBillPart = new CustomSplit(currentOrder, billPart,this);

            
            flowLayoutPanelSplit.Controls.Add(billPart);


            newBillPart.ShowDialog();
        }

        private void buttonEqualSplit_Click(object sender, EventArgs e)
        {

            EqualSplit equalSplit = new EqualSplit(currentOrder, this);

            equalSplit.ShowDialog();

        }


        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            List<Bill> billParts = new List<Bill>();
            if (remainingAmount == 0)
            {
                foreach (decimal splitCost in billPartCost)
                {
                    Bill bill = new Bill { OrderId = currentOrder.OrderId, TotalAmount = splitCost };

                    billParts.Add(bill);
                }
                PaymentForm paymentForm = new PaymentForm(billParts, currentOrder);
                Program.WindowSwitcher(this, paymentForm);

            }
            else
            {
                labelNotification.Text = "make sure the entire order is split into parts";
                labelNotification.Visible = true;
            }
        }

        public void UpdateRemainingAmount()
        {
            labelRemainingTotal.Text = RemainingAmount.ToString("F");
        }
    }
}
