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
        public int PartNR { get; set; }
        Order currentOrder;


        public UserControlSplitBill(decimal partCost, int partNR, BillSplitter billSplitter, Order order)
        {
            parentForm = billSplitter;
            currentOrder = order;

            InitializeComponent();

            SplitCost = partCost;
            labelPart.Text = $"Part {partNR+1}:";
            PartNR = partNR;
            setSplitCost(SplitCost);
  

        }
        private void setSplitCost(decimal newCost)
        {
            textBoxSplit.Text = newCost.ToString("F");
        }
        public void buttonSplitByPorion_Click(object sender, EventArgs e)
        {
            UpdateSplit split = new UpdateSplit(parentForm, PartNR, currentOrder);
            split.ShowDialog();
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
