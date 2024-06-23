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
    public partial class EqualSplit : Form
    {
        BillSplitter parentForm;

        decimal partCost;
        Order currentOrder;

        public EqualSplit(Order order, BillSplitter parentform)
        {
            this.parentForm = parentform;
            currentOrder = order;

            parentform.flowLayoutPanelSplit.Controls.Clear();
            parentform.partCostList.Clear();

            InitializeComponent();
            UpdatePartCost();
        }

        //change projected 
        private void UpdatePartCost()
        {
            partCost = currentOrder.TotalAmount / decimal.Parse(labelEqualSplitAmount.Text);

            labelEqualSplitPart.Text = partCost.ToString("F");

        }


        // increase the amount the order bill be devided in
        private void labelIncrease_Click(object sender, EventArgs e)
        {
            labelWarning.Hide();
            labelEqualSplitAmount.Text = (int.Parse(labelEqualSplitAmount.Text) + 1).ToString();
            UpdatePartCost();
        }
        // decrease the amount the order bill be devided in
        private void labelDecrease_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(labelEqualSplitAmount.Text);

            if (amount <= 2)
            {
                labelWarning.Show();
            }
            else
            {
                labelWarning.Hide();
                labelEqualSplitAmount.Text = (int.Parse(labelEqualSplitAmount.Text) - 1).ToString();
                UpdatePartCost();   
            }

        }


        //creates the usercontrols and puts them into the flowLayout
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int partCount = int.Parse(labelEqualSplitAmount.Text);
            for (int i = 0; i < partCount; i++)
            {
                UserControlSplitBill billPart = CreateBillPart(partCost);

                parentForm.flowLayoutPanelSplit.Controls.Add(billPart);
            }

            //if total amount isnt entirly devible by the set amount, adds the remainder to the first usercontrol entrie
            if (parentForm.RemainingAmount != 0)
            {
                UserControlSplitBill billPart = parentForm.flowLayoutPanelSplit.Controls[0] as UserControlSplitBill;
                billPart.SplitCost += parentForm.RemainingAmount;
            }

            parentForm.UpdateRemainingAmount();
            this.Dispose();
        }

        private UserControlSplitBill CreateBillPart(decimal partCost)
        {
            parentForm.partCostList.Add(0);
            int partIndex = parentForm.flowLayoutPanelSplit.Controls.Count;

            UserControlSplitBill billPart = new UserControlSplitBill(currentOrder, parentForm, partIndex);
            billPart.SplitCost = Math.Round(partCost, 2);
            return billPart;
        }
    }
}
