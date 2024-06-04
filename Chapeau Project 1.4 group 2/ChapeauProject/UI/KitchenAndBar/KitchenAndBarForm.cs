using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class KitchenAndBarForm : Form
    {
        private KitchenAndBarUserControl KitchenAndBarUserControl;

        public KitchenAndBarForm()
        {
            InitializeComponent();
        }

        // showing the current panel
        private void ShowCurrentPanel(Panel panel)
        {
            foreach (Control control in Controls)
            {
                if (control is Panel)
                {
                    control.Hide();
                }
            }
            panel.Show();
        }

        private void ShowOrdersPanel(bool drink, Status status)
        {
            // show orders
            ShowCurrentPanel(pnlRunningOrders);

            try
            {
                // get and display all food orders
                List<Order> orders = GetOrders(false, Status.placed);
                orders = GetOrders(false, Status.beingprepared);
                DisplayOrders(orders, Status.beingprepared);
            }
            catch (Exception e)
            {
                // throw exception
                MessageBox.Show("Something went wrong while loading the orders: " + e.Message);
            }
        }

        private List<Order> GetOrders(bool drink, Status status)
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.GetOrders(drink, status);
            return orders;
        }

        public void DisplayOrders(List<Order> orders, Status status)
        {
            pnlRunningOrders = (status == Status.Placed || status == Status.BeingPrepared) ? pnlRunningOrders : pnlFinishedOrders;
            pnlRunningOrders.Controls.Clear();

            foreach (Order order in orders)
            {
                KitchenAndBarUserControl orderControl = new KitchenAndBarUserControl(order);
                orderControl.UpdateOrderDetails(order);
                this.pnlRunningOrders.Controls.Add(KitchenAndBarUserControl);
            }
        }

        private void runningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetOrders(false, Status.Placed);
            GetOrders(false, Status.BeingPrepared);
            pnlRunningOrders.Controls.Add(KitchenAndBarUserControl);
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetOrders(false, Status.Ready);
            GetOrders(false, Status.Served);
        }
    }
}
