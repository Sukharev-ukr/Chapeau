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

        Order currentOrder;
        public BillDetails(Order order)
        {
            InitializeComponent();
            currentOrder = order;
            LabelOrderNR.Text = currentOrder.OrderId.ToString();
            LoadLabels(currentOrder);
        }

        private void LoadBillListView(Order currentOrder)
        {
            foreach (OrderItem item in currentOrder.Items)
            {
                decimal sum = (item.Count * item.MenuItem.Price);

                // remove this. VAT shouldt even be nullable
                if (item.MenuItem.VAT != null)
                {
                    VAT = sum * (((decimal)item.MenuItem.VAT / 100));
                    VATTotal += VAT;
                }
                total += sum;
                ListViewItem li = new ListViewItem(item.MenuItem.Name);
                li.SubItems.Add(item.Count.ToString());
                li.SubItems.Add(item.MenuItem.Price.ToString());
                li.SubItems.Add((sum).ToString());
                li.SubItems.Add(VAT.ToString("F"));
                li.Tag = item.OrderId;

                listViewBillList.Items.Add(li);
            }
        }

        private void LoadLabels(Order currentOrder)
        {
            listViewBillList.Items.Clear();
            decimal VAT = 0;
            decimal total = 0;
            decimal VATTotal = 0;



            if (currentOrder.TotalAmount == 0)
            {
                currentOrder.TotalAmount = total + VATTotal;
            }
            
            labelTotal.Text = currentOrder.TotalAmount.ToString("F");
            labelSubtotal.Text = total.ToString("F");
            labelVAT.Text = VATTotal.ToString("F");

            if (currentOrder.TipAmount != 0)
            {
                labelTip.Visible = true;
                label8.Visible = true;
                labelTip.Text = currentOrder.TipAmount.ToString("F");
            }


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
            CurrentOrder.DestoryInstance();
            StaffService staff = new StaffService();

            TableView_Form tableView_Form = new TableView_Form(staff.LoggedUser);

            Program.WindowSwitcher(this, tableView_Form);
        }
    }
}
