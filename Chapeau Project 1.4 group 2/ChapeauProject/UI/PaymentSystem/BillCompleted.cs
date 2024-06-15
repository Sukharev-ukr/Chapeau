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

namespace UI.PaymentSystem
{
    public partial class BillCompleted : Form
    {
        CurrentOrder currentOrder;
        public BillCompleted()
        {
            currentOrder = CurrentOrder.Getinstance();
            InitializeComponent();
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
            labelTotal.Text = currentOrder.OrderTotal.ToString("F");
            labelSubtotal.Text = total.ToString("F");
            labelVAT.Text = VATTotal.ToString("F");
            labelTip.Text = currentOrder.Tip.ToString("F");
        }
        private Dictionary<OrderItem, MenuItem> GetOrderMenuItems()
        {
            return currentOrder.orderDetail;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            StaffService staffService = new StaffService();

            TableView_Form tableView = new TableView_Form(staffService.LoggedUser);
            Program.WindowSwitcher(this,tableView);
        }
    }
}
