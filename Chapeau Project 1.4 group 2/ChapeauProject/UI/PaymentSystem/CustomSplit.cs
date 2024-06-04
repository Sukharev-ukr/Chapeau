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

        public CustomSplit(BillSplitter billSplitter)
        {
            InitializeComponent();
            parentForm = billSplitter;

        }
        protected void QuickSelection_Click(object sender, EventArgs e)
        {
            PaymentService.CurrentOrder currentOrder = PaymentService.CurrentOrder.Getinstance();

            decimal newCost = currentOrder.OrderTotal * decimal.Parse((sender as Button).Tag.ToString());


            SetPartCost(newCost);
        }

        protected void SetPartCost(decimal newCost)
        {
            
            partCost = Math.Abs(newCost);
            labelDevidePartCost.Text = partCost.ToString("F");
        }

        protected void TextBoxCustomAmount_OnTextChange(object sender, EventArgs e)
        {
            string input = textBoxCustomAmount.Text;
            decimal orderTotal = PaymentService.CurrentOrder.Getinstance().OrderTotal;
            decimal newCost = 0;

            try 
            {
                if (input.Contains('/'))
                {
                    string[] split = input.Split('/');
                    newCost = orderTotal*(decimal.Parse(split[0]) / decimal.Parse(split[1]));
                }else if (input.Contains('%'))
                {
                    decimal precentage = decimal.Parse(input.Substring(1)) / 100;
                    newCost = orderTotal * precentage;
                }else 
                {
                    newCost =  int.Parse(input);
                }

                SetPartCost(newCost);
            }
            catch
            {

            }
            
        }

        protected virtual void  buttonConfirm_Click(object sender, EventArgs e)
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
