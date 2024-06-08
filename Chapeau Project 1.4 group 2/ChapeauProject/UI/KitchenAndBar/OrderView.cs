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
        private OrderService orderService = new OrderService();
        private OrderItemService orderItemService = new OrderItemService();
        private List<Order> orders = new List<Order>();
        private Employee employee;
        private bool isChef;

        public OrderView()
        {
            employee = new Employee(); // Initialize your employee object
            InitializeComponent();
            InitializeFlowLayoutPanel();
        }

        private void InitializeFlowLayoutPanel()
        {
            // Initialize and configure the FlowLayoutPanels
            flowLayoutPanelRunning = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };
            flowLayoutPanelFinished = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };

            this.Controls.Add(flowLayoutPanelRunning); // Add the running orders panel to the form
            this.Controls.Add(flowLayoutPanelFinished); // Add the finished orders panel to the form
        }

        // Show the current panel
        private void ShowCurrentPanel(FlowLayoutPanel panel)
        {
            foreach (Control control in Controls)
            {
                if (control is FlowLayoutPanel)
                {
                    control.Hide();
                }
            }
            panel.Show();
        }

        private bool PersonLoggedIn()       
        {
            return employee.Role == Role.Chef;
        }

        private Dictionary<Order, Dictionary<Category, List<OrderItem>>> GetOrders()
        {
            isChef=PersonLoggedIn();
            orders = orderService.GetAllOrders();
            Dictionary<Order, Dictionary<Category, List<OrderItem>>> ordersItems = new Dictionary<Order, Dictionary<Category, List<OrderItem>>>();

            foreach (Order order in orders)
            {
                Dictionary<Category, List<OrderItem>> itemsByCategory = new Dictionary<Category, List<OrderItem>>();

                foreach (Category category in Enum.GetValues(typeof(Category)))
                {
                    List<OrderItem> items = orderItemService.GetOrderItemsByCategory(order.OrderId, category.ToString());
                    itemsByCategory[category] = items;
                }

                ordersItems.Add(order, itemsByCategory);
            }

            return ordersItems;
        }



        private void ShowOrdersPanel(FlowLayoutPanel panel)
        {
            // Show orders
            ShowCurrentPanel(panel);

            try
            {
                // Get and display all orders
                var orders = GetOrders();
                panel.Controls.Clear(); // Clear existing controls in the specified panel

                foreach (var orderPair in orders)
                {
                    var order = orderPair.Key;
                    var itemsByCategory = orderPair.Value;

                    foreach (var categoryPair in itemsByCategory)
                    {
                        var category = categoryPair.Key;
                        var orderItems = categoryPair.Value;

                        if (orderItems.Count > 0)
                        {
                            // Create a new KitchenAndBarUserControl for each order category
                            KitchenAndBarUserControl orderControl = new KitchenAndBarUserControl(order);
                            orderControl.UpdateOrderDetails(order);

                            foreach (OrderItem orderItem in orderItems)
                            {
                                orderControl.AddOrderItem(orderItem);
                                if (orderItem.OrderStatus == Status.ready || orderItem.OrderStatus == Status.served)
                                {
                                    flowLayoutPanelFinished.Controls.Add(orderControl);
                                }
                                else
                                {
                                    flowLayoutPanelRunning.Controls.Add(orderControl);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Handle exception
                MessageBox.Show("Something went wrong while loading the orders: " + e.Message);
            }
        }
    

        // method to change order status 


        private void runningToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowOrdersPanel(flowLayoutPanelRunning);
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrdersPanel(flowLayoutPanelFinished);
        }
    }
}