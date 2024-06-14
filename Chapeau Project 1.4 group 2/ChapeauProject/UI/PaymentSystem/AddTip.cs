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
using static Service.PaymentService;


namespace UI.PaymentSystem
{
    public partial class AddTip : Form
    {
        decimal orderTotal;
        decimal tip;
        CurrentOrder currentOrder;

        public AddTip()
        {
            InitializeComponent();


            currentOrder = CurrentOrder.Getinstance();
            orderTotal = currentOrder.OrderTotal;

            labelTotal.Text = orderTotal.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Program.WindowSwitcher(this, new BillDetails(currentOrder.orderId));
        }

        private void AddTipButton_Click(object sender, EventArgs e)
        {
            tip = int.Parse((sender as Button).Tag.ToString());
            
            labelTipTotal.Text = (orderTotal + tip).ToString();
            textBoxTip.Text = (orderTotal + tip).ToString();

        }

        private void TextBoxCustomTip_TextChange(object sender, EventArgs e)
        {
            decimal.TryParse(textBoxTip.Text, out decimal totalWithTip);
            if (totalWithTip > orderTotal)
            {
                labelTipTotal.Text = totalWithTip.ToString();
                buttonConfirm.Visible = true;
                tip = totalWithTip - orderTotal;
            }
            
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            currentOrder.AddTip(tip);
            Program.WindowSwitcher(this, new BillSplitter());
        }
    }
}
