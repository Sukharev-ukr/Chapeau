using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Model;


namespace UI.PaymentSystem
{
    public partial class AddTip : Form
    {
        decimal tip;
        Order currentOrder;

        public AddTip(Order currentOrder)
        {
            this.currentOrder = currentOrder;

            InitializeComponent();
            
            labelTotal.Text = currentOrder.TotalAmount.ToString("F");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Program.WindowSwitcher(this, new BillDetails(currentOrder));
        }

        // adding tip through quick selection buttons
        private void AddTipButton_Click(object sender, EventArgs e)
        {
            tip = int.Parse((sender as Button).Tag.ToString());
            
            labelTipTotal.Text = (currentOrder.TotalAmount + tip).ToString("F");
            textBoxTip.Text = (currentOrder.TotalAmount + tip).ToString("F");

        }

        private void TextBoxCustomTip_TextChange(object sender, EventArgs e)
        {
            decimal.TryParse(textBoxTip.Text, out decimal totalWithTip);
            if (totalWithTip > currentOrder.TotalAmount)
            {
                labelTipTotal.Text = totalWithTip.ToString();
                buttonConfirm.Visible = true;
                tip = totalWithTip - currentOrder.TotalAmount;
            }
            
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            currentOrder.TipAmount = tip;
            Program.WindowSwitcher(this, new BillDetails(currentOrder));
        }
    }
}
