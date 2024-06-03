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

namespace UI.PaymentSystem
{
    public partial class EqualSplit : Form
    {

        BillSplitter parentForm;
        decimal partCost;

        public EqualSplit(BillSplitter billSplitter)
        {
            InitializeComponent();
            parentForm = billSplitter;
            UpdatePartCost();
        }

        private void UpdatePartCost()
        {
            PaymentService.CurrentOrder currentOrder = PaymentService.CurrentOrder.Getinstance();
            partCost = currentOrder.OrderTotal / decimal.Parse(labelEqualSplitAmount.Text);

            labelEqualSplitPart.Text = partCost.ToString("F");

        }

        private void labelIncrease_Click(object sender, EventArgs e)
        {
            labelWarning.Hide();
            labelEqualSplitAmount.Text = (int.Parse(labelEqualSplitAmount.Text) + 1).ToString();
            UpdatePartCost();
        }

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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int partCount = int.Parse(labelEqualSplitAmount.Text);
            for (int i = 0; i < partCount; i++)
            {
                parentForm.NewBillPart(partCost);
            }

            this.Dispose();
        }
    }
}
