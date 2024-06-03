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
    public abstract partial class CustomSplit : Form
    {
        protected BillSplitter parentForm;
        protected decimal partCost;
        protected PaymentService.CurrentOrder currentOrder;

        public CustomSplit(BillSplitter billSplitter)
        {
            InitializeComponent();
            parentForm = billSplitter;
            LabelDevideTotal.Text = currentOrder.OrderTotal.ToString();

        }
        protected void QuickSelection_Click(object sender, EventArgs e)
        {
            decimal devider = decimal.Parse((sender as Button).Tag.ToString());

            decimal newCost = currentOrder.OrderTotal * devider;

            SetPartCost(newCost);
        }

        protected void SetPartCost(decimal newCost)
        {
            decimal orderTotal = currentOrder.OrderTotal;
            partCost = Math.Abs(newCost);
            if (partCost <= orderTotal)
            {
                buttonConfirm.Visible = true;
            }
            else
            {
                buttonConfirm.Visible = false;
            }


            labelDevidePartCost.Text = partCost.ToString("F");
        }

        protected void TextBoxCustomAmount_OnTextChange(object sender, EventArgs e)
        {
            string input = textBoxCustomAmount.Text;
            decimal orderTotal = currentOrder.OrderTotal;
            decimal newCost = 0;

            try
            {
                if (input.Contains('/'))
                {
                    string[] split = input.Split('/');
                    decimal.TryParse(split[0], out decimal devideAmount);
                    decimal.TryParse((split[1]), out decimal devider);
                    newCost = orderTotal * (devideAmount);
                }
                else if (input.Contains('%'))
                {
                    decimal precentage = decimal.Parse(input.Substring(1)) / 100;
                    newCost = orderTotal * precentage;
                }
                else
                {
                    newCost = decimal.Parse(input);
                }

                SetPartCost(newCost);
            }
            catch
            {

            }

        }

        protected virtual void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
    public class NewSplit : CustomSplit
    {
        public NewSplit(BillSplitter billSplitter) : base(billSplitter)
        {

        }
        protected override void buttonConfirm_Click(object sender, EventArgs e)
        {
            parentForm.NewBillPart(partCost);
            base.buttonConfirm_Click(sender, e);
        }
    }
    public class UpdateSplit : CustomSplit
    {
        int partIndex;
        public UpdateSplit(BillSplitter billSplitter,int index) : base(billSplitter)
        {
            partIndex = index;
        }
        protected override void buttonConfirm_Click(object sender, EventArgs e)
        {
            parentForm.UpdateBillPart(partCost,partIndex);
            base.buttonConfirm_Click(sender, e);
        }
    }
}
