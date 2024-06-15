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
using static Service.PaymentService;

namespace UI
{
    public partial class BillDetails : Form
    {

        CurrentOrder currentOrder;
        public BillDetails(int order)
        {
            InitializeComponent();
            currentOrder = CurrentOrder.Getinstance(order);
            LabelOrderNR.Text = currentOrder.orderDetail.Keys.First().OrderId.ToString();
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            Dictionary<OrderItem, MenuItem> OrderDetails = GetOrderMenuItems();
            listViewBillList.Items.Clear();
            decimal sum = 0;
            decimal VAT = 0;
            decimal total = 0;
            decimal VATTotal = 0;

            foreach (KeyValuePair<OrderItem, MenuItem> item in OrderDetails)
            {
                sum = (item.Key.Count * item.Value.Price);
                if (item.Value.VAT != null)
                {
                    VAT = sum * (((decimal)item.Value.VAT / 100));
                    VATTotal += VAT;
                }
                total += sum;
                ListViewItem li = new ListViewItem(item.Value.Name);
                li.SubItems.Add(item.Key.Count.ToString());
                li.SubItems.Add(item.Value.Price.ToString());
                li.SubItems.Add((sum).ToString());
                li.SubItems.Add(VAT.ToString("F"));
                li.Tag = item.Key.OrderId;

                listViewBillList.Items.Add(li);
            }
            labelTotal.Text = (total + VATTotal).ToString("F");
            labelSubtotal.Text = total.ToString("F");
            labelVAT.Text = VATTotal.ToString("F");


            currentOrder.OrderTotal = total + VATTotal;
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

        private void button2_Click(object sender, EventArgs e)
        {
            BillParts billParts = BillParts.Getinstance();
            billParts.AddBillPart(0, currentOrder.OrderTotal);

            PaymentForm paymentform = new PaymentForm();

            Program.WindowSwitcher(this, paymentform);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            StaffService staff = new StaffService();

            TableView_Form tableView_Form = new TableView_Form(staff.LoggedUser);

            Program.WindowSwitcher(this, tableView_Form);
        }
    }
}
