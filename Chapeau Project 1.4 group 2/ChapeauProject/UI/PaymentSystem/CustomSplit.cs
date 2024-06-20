
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
using Service;
using System.Drawing.Design;

namespace UI.PaymentSystem
{
    public partial class CustomSplit : Form
    {
        UserControlSplitBill part;
        protected decimal partCost;
        protected Order currentOrder;

        //string wildcards
        //only registers fractions I.E: 1/2, 1/22, 3/10
        Regex fractionPattern = new Regex("[0-9]+/+[0-9]");

        //ony registers % symbol followed by a number 
        Regex percentagePattern = new Regex("^%[0-9]+");

        public CustomSplit(Order order, UserControlSplitBill userControl)
        {
            currentOrder = order;
            part = userControl;
            InitializeComponent();
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
            decimal newCost = 0;


            //checks if string input matches Regex pattern
            if (percentagePattern.IsMatch(input))
            {
                newCost = CustomPercentage(percentagePattern.Match(input).ToString());
            }
            else if (fractionPattern.IsMatch(input))
            {
                newCost = CustomFraction(fractionPattern.Match(input).ToString());
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
            part.SplitCost = partCost;
            this.Dispose();
        }
    }
}
