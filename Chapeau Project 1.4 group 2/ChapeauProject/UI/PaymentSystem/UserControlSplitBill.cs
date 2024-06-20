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
    public partial class UserControlSplitBill : UserControl
    {

        BillSplitter parentForm;
        private decimal _splitCost;
        public decimal SplitCost { get { return _splitCost; } set { _splitCost = value; setSplitCost(value); } }
        int partNR;
        Order currentOrder;


        public UserControlSplitBill(BillSplitter billSplitter, Order order)
        {
            parentForm = billSplitter;
            currentOrder = order;

            InitializeComponent();

            labelPart.Text = $"Part {Tag}:";
            this.partNR = partNR;
            setSplitCost(SplitCost);

        }
        private void setSplitCost(decimal newCost)
        {
            textBoxSplit.Text = newCost.ToString("F");
        }
        public void buttonEditPortion_Click(object sender, EventArgs e)
        {
            CustomSplit editSplit = new CustomSplit(currentOrder,this);
            editSplit.ShowDialog();
        }

        private void textBoxSplit_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(textBoxSplit.Text, out _splitCost);
            
            if (_splitCost != null)
            {
                parentForm.UpdateRemainingAmount();
            }
        }
    }
}
