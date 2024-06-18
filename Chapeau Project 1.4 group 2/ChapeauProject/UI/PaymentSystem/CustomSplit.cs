using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Drawing.Design;

namespace UI.PaymentSystem
{
    public abstract partial class CustomSplit : Form
    {
        protected BillSplitter parentForm;
        protected decimal partCost;
        protected Order currentOrder;

        //string wildcards
        //only registers fractions I.E: 1/2, 1/22, 3/10
        Regex fractionPattern = new Regex("[0-9]+/[0-9]+");

        //ony registers % symbol followed by a number 
        Regex percentagePattern = new Regex("^%[0-9]+");

        public CustomSplit(BillSplitter billSplitter)
        {
            InitializeComponent();
            parentForm = billSplitter;
            LabelDevideTotal.Text = currentOrder.TotalAmount.ToString();
        }
        protected void QuickSelection_Click(object sender, EventArgs e)
        {
            decimal devider = decimal.Parse((sender as Button).Tag.ToString()) / 100;

            decimal newCost = currentOrder.TotalAmount * devider;

            SetPartCost(newCost);
        }

        protected void SetPartCost(decimal newCost)
        {
            decimal orderTotal = currentOrder.TotalAmount;
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
            decimal orderTotal = currentOrder.TotalAmount;
            decimal newCost = 0;


            //checks if string input matches Regex pattern
            if (percentagePattern.IsMatch(input))
            {
                newCost = CustomPercentage(input);
            }
            else if (fractionPattern.IsMatch(input))
            {
                newCost = CustomFraction(input);
            }
            else
            {
                decimal.TryParse(input, out newCost);
            }
            SetPartCost(newCost);

        }
        private decimal CustomFraction(string input)
        {
            string[] split = input.Split('/');
            decimal.TryParse(split[0], out decimal devideAmount);
            decimal.TryParse((split[1]), out decimal devider);
            return currentOrder.TotalAmount * (devideAmount / devider);
        }

        private decimal CustomPercentage(string input)
        {
            decimal precentage = decimal.Parse(input.Substring(1)) / 100;
            return precentage;
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
        public UpdateSplit(BillSplitter billSplitter, int index) : base(billSplitter)
        {
            partIndex = index;
        }
        protected override void buttonConfirm_Click(object sender, EventArgs e)
        {
            parentForm.UpdateBillPart(partCost, partIndex);
            base.buttonConfirm_Click(sender, e);
        }
    }
}
