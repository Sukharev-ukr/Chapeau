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
using Service;
using UI.PaymentSystem;

namespace UI
{
    public partial class BillDetails : Form
    {

        PaymentService.CurrentOrder currentOrder;
        public BillDetails(int order)
        {
            InitializeComponent();
            currentOrder = PaymentService.CurrentOrder.NewInstance(order);
            LabelOrderNR.Text = currentOrder.orderDetail.Keys.First().OrderId.ToString();
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {

            Dictionary<OrderItem, MenuItem> OrderDetails = GetOrderMenuItems();

            listViewBillList.Items.Clear();
            decimal sum = 0;
            decimal total = 0;

            foreach (KeyValuePair<OrderItem, MenuItem> item in OrderDetails)
            {
                sum = item.Key.Count * item.Value.Price;
                total += sum;

                ListViewItem li = new ListViewItem(item.Value.Name);
                li.SubItems.Add(item.Key.Count.ToString());
                li.SubItems.Add(item.Value.Price.ToString());
                li.SubItems.Add((sum).ToString());
                li.SubItems.Add("%" + item.Value.VAT.ToString());
                li.Tag = item.Key.OrderId;

                listViewBillList.Items.Add(li);
            }
            labelTotal.Text = total.ToString();
            currentOrder.OrderTotal = total;
        }
        private Dictionary<OrderItem, MenuItem> GetOrderMenuItems()
        {
            return currentOrder.orderDetail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillSplitter newForm = new BillSplitter();

            Program.WindowSwitcher(this, newForm);

        }

        private void buttonAddTip_Click(object sender, EventArgs e)
        {
            Program.WindowSwitcher(this, new AddTip());
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            AddComment addComment = new AddComment();
            addComment.ShowDialog();
        }
    }
}
