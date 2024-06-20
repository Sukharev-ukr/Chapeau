
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
        List<Bill> billParts;


        public BillSplitter(Order order)
        {
            billParts = new List<Bill>();
            currentOrder = order;

            InitializeComponent();
            labelTotal.Text = currentOrder.TotalAmount.ToString("F");

            remainingAmount = currentOrder.TotalAmount;
            labelRemainingTotal.Text = remainingAmount.ToString("F");

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            Form newForm = new BillDetails(currentOrder);
            Program.WindowSwitcher(this, newForm);
        }

        public void UpdateRemainingAmount()
        {
            remainingAmount = currentOrder.TotalAmount;

            foreach (UserControlSplitBill userControl in this.flowLayoutPanelSplit.Controls)
            {
                remainingAmount -= userControl.SplitCost;
            }
            labelRemainingTotal.Text = remainingAmount.ToString("F");
        }

        //adding user controll items
        public void NewBillPart()
        {
            int partNR = flowLayoutPanelSplit.Controls.Count;
            UserControlSplitBill billPart = new UserControlSplitBill(this, currentOrder);

            billPart.Tag = partNR;
            flowLayoutPanelSplit.Controls.Add(billPart);

            UpdateRemainingAmount();
        }

        // instead of this method directly update from the instance of the object. and change updateRemainng amount
        public void UpdateBillPart(decimal partAmount, int part)
        {
            UpdateRemainingAmount();
        }

        private void buttonCustomSplit_Click(object sender, EventArgs e)
        {
            UserControlSplitBill billPart = new UserControlSplitBill(this,currentOrder);
            CustomSplit newBillPart = new CustomSplit(currentOrder,billPart);
            newBillPart.ShowDialog();

        }

        private void buttonEqualSplit_Click(object sender, EventArgs e)
        {

            EqualSplit equalSplit = new EqualSplit(this,currentOrder);

            this.flowLayoutPanelSplit.Controls.Clear();
            remainingAmount = currentOrder.TotalAmount;
            equalSplit.ShowDialog();

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if (remainingAmount == 0)
            {
                foreach(UserControlSplitBill userControl in this.flowLayoutPanelSplit.Controls)
                {
                    Bill bill = new Bill { OrderId = currentOrder.OrderId, TotalAmount = userControl.SplitCost };

                    billParts.Add(bill);
                }
                PaymentForm paymentForm = new PaymentForm(billParts,currentOrder);
                Program.WindowSwitcher(this,paymentForm);

            }
            else
            {
                labelNotification.Text = "make sure the entire order is split into parts";
                labelNotification.Visible = true;
            }
        }
    }
}
