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
using UI.Login;
using UI.PaymentSystem;

namespace UI
{
    public partial class BillDetails : Form
    {

        OrderItemService orderItemService;
        Order currentOrder;
        decimal sum;

        public BillDetails(Order order)
        {
            currentOrder = order;
            orderItemService = new OrderItemService();

            InitializeComponent();

            LabelOrderNR.Text = currentOrder.OrderId.ToString();

            GetOrderItems(currentOrder);

            LoadBillListView(currentOrder);
            LoadLabels(currentOrder);
        }

        private void LoadBillListView(Order currentOrder)
        {
            listViewBillList.Items.Clear();
            currentOrder.TotalAmount = 0;
            currentOrder.VAT = 0;

            foreach (OrderItem item in currentOrder.Items)
            {
                sum += (item.Count * item.MenuItem.Price);

                currentOrder.VAT += (decimal)item.MenuItem.VAT;
                ListViewItem li = new ListViewItem(item.MenuItem.Name);
                li.SubItems.Add(item.Count.ToString());
                li.SubItems.Add(item.MenuItem.Price.ToString());
                li.SubItems.Add((sum).ToString());
                li.SubItems.Add(((decimal)item.MenuItem.VAT * item.Count).ToString("F"));
                li.Tag = item.OrderId;

                listViewBillList.Items.Add(li);
            }
            currentOrder.TotalAmount += currentOrder.VAT + currentOrder.TipAmount + sum;
        }

        private void LoadLabels(Order currentOrder)
        {
            labelTotal.Text = currentOrder.TotalAmount.ToString("F");
            labelSubtotal.Text = sum.ToString("F");
            labelVAT.Text = currentOrder.VAT.ToString("F");

            //if a tip has been added, show the tip label and tip value.
            if (currentOrder.TipAmount != 0)
            {
                labelTip.Visible = true;
                label8.Visible = true;
                labelTip.Text = currentOrder.TipAmount.ToString("F");
            }
        }

        private void GetOrderItems(Order currentOrder)
        {
           currentOrder.Items = orderItemService.GetOrderDetials(currentOrder.OrderId);
        }

        //opens the bill spliter form.
        private void button1_Click(object sender, EventArgs e)
        {
            BillSplitter newForm = new BillSplitter(currentOrder);

            Program.WindowSwitcher(this, newForm);

        }
        //opens add tip form
        private void buttonAddTip_Click(object sender, EventArgs e)
        {
            Program.WindowSwitcher(this, new AddTip(currentOrder));
        }
        //opens the add comment form
        private void buttonComment_Click(object sender, EventArgs e)
        {
            AddComment addComment = new AddComment(currentOrder);
            addComment.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Bill> bill = new List<Bill> { new Bill { OrderId = currentOrder.OrderId, TotalAmount = currentOrder.TotalAmount } };
            PaymentForm paymentform = new PaymentForm(bill,currentOrder);

            Program.WindowSwitcher(this, paymentform);
        }

        //returns to the tableview. gets a the logged user name from staff service
        // might need rework
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            TableView_Form tableView_Form = new TableView_Form(currentOrder.Employee.Name);

            Program.WindowSwitcher(this, tableView_Form);
        }
    }
}
