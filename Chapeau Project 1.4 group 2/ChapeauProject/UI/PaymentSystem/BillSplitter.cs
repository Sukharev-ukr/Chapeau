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
using System.Diagnostics.Eventing.Reader;


namespace UI.PaymentSystem
{
    public partial class BillSplitter : Form
    {
        private decimal remainingAmount;
        PaymentService.CurrentOrder currentOrder;

        public BillSplitter()
        {
            InitializeComponent();
            currentOrder = PaymentService.CurrentOrder.Getinstance();
            labelTotal.Text = currentOrder.OrderTotal.ToString();

            remainingAmount = currentOrder.OrderTotal;
            labelRemainingTotal.Text = remainingAmount.ToString();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            Form newForm = new BillDetails(currentOrder.orderId);
            Program.WindowSwitcher(this, newForm);
        }

        private void UpdateRemainingAmount()
        {
            remainingAmount = currentOrder.OrderTotal;

            foreach (UserControlSplitBill userControl in this.flowLayoutPanelSplit.Controls)
            {
                remainingAmount -= userControl.SplitCost;
            }
            labelRemainingTotal.Text = remainingAmount.ToString("F");
        }

        //adding user controll items
        public void NewBillPart(decimal partAmount)
        {
            int partNR = flowLayoutPanelSplit.Controls.Count + 1;
            UserControlSplitBill billPart = new UserControlSplitBill(partAmount, partNR, this);

            billPart.Tag = partNR;
            flowLayoutPanelSplit.Controls.Add(billPart);

            UpdateRemainingAmount();
        }
        public void UpdateBillPart(decimal partAmount, int part)
        {
            foreach (UserControlSplitBill userControl in this.flowLayoutPanelSplit.Controls)
            {
                if ((int)userControl.Tag == part)
                {
                    userControl.SplitCost = partAmount;
                    continue;
                }
            }
            UpdateRemainingAmount();
        }

        private void buttonCustomSplit_Click(object sender, EventArgs e)
        {
            CustomSplit newBillPart = new NewSplit(this);
            newBillPart.ShowDialog();

        }

        private void buttonEqualSplit_Click(object sender, EventArgs e)
        {

            EqualSplit equalSplit = new EqualSplit(this);

            this.flowLayoutPanelSplit.Controls.Clear();
            remainingAmount = currentOrder.OrderTotal;
            equalSplit.ShowDialog();

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if (remainingAmount < 0 || remainingAmount > 0)
            {
                labelNotification.Text = "make sure the entire order is split into parts";
                labelNotification.Visible = true;
            }else {
                //do
            }
        }
    }
}
