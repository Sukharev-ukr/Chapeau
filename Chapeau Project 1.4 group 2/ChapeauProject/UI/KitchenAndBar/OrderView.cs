using Model;
using Service;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public partial class OrderView : Form
    {
        private OrderService orderService;
        private StaffService staffService;

        public OrderView()
        {
            InitializeComponent();
            orderService = new OrderService();
            staffService = new StaffService();
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
            drink = PersonLoggedIn();

            // show orders
            ShowCurrentPanel(pnlRunningOrders);

            try
            {
                // get and display all orders
                List<Order> orders = GetOrders(drink, status);
                DisplayOrders(orders, status);
            }
            catch (Exception e)
            {
                // throw exception
                MessageBox.Show("Something went wrong while loading the orders: " + e.Message);
            }
        }

        private static bool PersonLoggedIn()
        {
            bool drink;

            // check who's logged in
            Staff staff = new Staff();
            drink = staff.Username == "Pierre Dubois";

            return drink;
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
                this.pnlRunningOrders.Controls.Add(orderControl);
            }
        }

        private void runningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrdersPanel(false, Status.Served);
        }

        private void finishedToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowOrdersPanel(false, Status.Served);
        }
    }
}
