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

        private decimal _splitCost;
        public decimal SplitCost { get { return _splitCost; } set { _splitCost = value; setSplitCost(value); } }
        Order currentOrder;
        BillSplitter parentform;


        public UserControlSplitBill(Order order, BillSplitter parentform, int index)
        {
            this.parentform = parentform;
            currentOrder = order;
            this.Tag = index;

            InitializeComponent();

            labelPart.Text = $"Part {this.Tag}:";
            setSplitCost(SplitCost);

        }
        private void setSplitCost(decimal newCost)
        {
            textBoxSplit.Text = newCost.ToString("F");
        }
        public void buttonEditPortion_Click(object sender, EventArgs e)
        {
            CustomSplit editSplit = new CustomSplit(currentOrder, this, parentform);
            editSplit.ShowDialog();
        }

        private void textBoxSplit_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(textBoxSplit.Text, out _splitCost);
            parentform.billPartCost[(int)Tag] = _splitCost;
            parentform.UpdateRemainingAmount();
        }
    }
}
