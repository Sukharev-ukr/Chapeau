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
using DAL;

namespace UI
{
    public partial class OrderView : Form
    {
        private bool isChef;
        private FlowLayoutPanel flowLayoutPanel;
        private StaffService staffService;

        public OrderView()
        {
            InitializeComponent();
            InitializeFlowLayoutPanel();
            staffService = new StaffService();
        }

        private void InitializeFlowLayoutPanel()
        {
            // Initialize and configure the FlowLayoutPanel
            flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };
            this.Controls.Add(flowLayoutPanel); // Add the FlowLayoutPanel to the form
            this.Controls.Add(flowLayoutPanelRunning); // Add the running orders panel to the form
            this.Controls.Add(flowLayoutPanelFinished); // Add the finished orders panel to the form
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

        private static bool PersonLoggedIn()
        {
            bool drink;

            // check who's logged in
            Staff staff = new Staff();
            return drink = staff.Username == "Pierre Dubois";
        }

        private Dictionary<Order, List<OrderItem>> GetOrders()
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.GetOrders();
            Dictionary<Order, List<OrderItem>> ordersItems = new Dictionary<Order, List<OrderItem>>();

            foreach (Order order in orders)
            {
                List<OrderItem> items = orderService.GetOrderItems(order.OrderId);
                ordersItems.Add(order, items);
            }

            return ordersItems;
        }

        private void ShowOrdersPanel(Panel panel)
        {
            // Show orders
            ShowCurrentPanel(panel);

            try
            {
                // Get and display all orders
                Dictionary<Order, List<OrderItem>> orders = GetOrders();
                flowLayoutPanel.Controls.Clear(); // Clear existing controls in FlowLayoutPanel

                foreach (var orderPair in orders)
                {
                    var order = orderPair.Key;
                    var orderItems = orderPair.Value;

                    // Create a new KitchenAndBarUserControl for each order
                    KitchenAndBarUserControl orderControl = new KitchenAndBarUserControl();
                    orderControl.UpdateOrderDetails(order);

                    foreach (OrderItem orderItem in orderItems)
                    {
                        orderControl.AddOrderItem(orderItem);
                    }

                    // Add the user control to the FlowLayoutPanel
                    flowLayoutPanel.Controls.Add(orderControl);
                }
            }
            catch (Exception e)
            {
                // Handle exception
                MessageBox.Show("Something went wrong while loading the orders: " + e.Message);
            }
        }

        //not working yet
        private void OrderControl_OrderStatusChanged(Order order, Status newStatus)
        {
            // Find the control corresponding to the order
            KitchenAndBarUserControl orderControl = flowLayoutPanelRunning.Controls.OfType<KitchenAndBarUserControl>()
                .FirstOrDefault(c => c.currentOrder == order);

            if (orderControl != null)
            {
                // Move the control to the finished panel if the status is Ready
                if (newStatus == Status.ready)
                {
                    flowLayoutPanelRunning.Controls.Remove(orderControl);
                    flowLayoutPanelFinished.Controls.Add(orderControl);
                }
            }
        }

        private void runningToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowOrdersPanel(flowLayoutPanel);
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrdersPanel(flowLayoutPanel);
        }
    }
}