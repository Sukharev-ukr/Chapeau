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
using Timer = System.Windows.Forms.Timer;

namespace UI
{
    public partial class OrderOverview : Form
    {
        private OrderService orderService;
        private OrderItemService orderItemService;
        private Employee employee;
        private bool isChef;
        private Timer clockTimer;

        public OrderOverview(Employee employee)
        {
            this.employee = employee;
            orderService = new OrderService();
            orderItemService = new OrderItemService();

            InitializeComponent();
            InitializeFlowLayoutPanel();
            InitializeClockTimer();
            lblEmployee.Text = employee.Name;
            isChef = employee.Role == Role.Chef;
        }

        private void InitializeClockTimer()
        {
            clockTimer = new Timer
            {
                Interval = 1000 // interval set to 1 second (1000 milliseconds)
            };
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm");
        }

        private void InitializeFlowLayoutPanel()
        {
            this.Controls.Add(flowLayoutPanelRunning); // Add the running orders panel to the form
            this.Controls.Add(flowLayoutPanelFinished); // Add the finished orders panel to the form
        }

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

        private Dictionary<Order, Dictionary<Category, List<OrderItem>>> GetOrders()
        {
            List<Order> orders = orderService.GetAllOrders();
            var ordersItems = new Dictionary<Order, Dictionary<Category, List<OrderItem>>>();

            foreach (Order order in orders)
            {
                var itemsByCategory = new Dictionary<Category, List<OrderItem>>();
                CategorizeOrdersByRole(order, itemsByCategory);
                ordersItems.Add(order, itemsByCategory);
            }

            return ordersItems;
        }

        private void CategorizeOrdersByRole(Order order, Dictionary<Category, List<OrderItem>> itemsByCategory)
        {
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                if (isChef && category != Category.Drinks || !isChef && category == Category.Drinks)
                {
                    List<OrderItem> items = orderItemService.GetOrderItemsByCategory(order.OrderId, category.ToString());
                    itemsByCategory[category] = items;
                }
            }
        }

        private void ShowOrdersPanel(FlowLayoutPanel panel)
        {
            ShowCurrentPanel(panel);

            try
            {
                var orders = GetOrders();
                panel.Controls.Clear(); // Clear existing controls in the specified panel
                CreateOrders(orders);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the orders: " + e.Message);
            }
        }

        private void CreateOrders(Dictionary<Order, Dictionary<Category, List<OrderItem>>> orders)
        {
            foreach (var orderPair in orders)
            {
                CreateUserControl(orderPair.Key, orderPair.Value);
            }
        }

        private void CreateUserControl(Order order, Dictionary<Category, List<OrderItem>> itemsByCategory)
        {
            foreach (var categoryPair in itemsByCategory)
            {
                var orderItems = categoryPair.Value;
                if (orderItems.Count > 0)
                {
                    var orderControl = new KitchenAndBarUserControl(order);
                    orderControl.UpdateOrderDetails(order);

                    foreach (OrderItem orderItem in orderItems)
                    {
                        orderControl.AddOrderItem(orderItem);
                    }

                    FlowLayoutPanel targetPanel = (orderItems.Any(oi => oi.OrderStatus == Status.ready || oi.OrderStatus == Status.served)) ? flowLayoutPanelFinished : flowLayoutPanelRunning;
                    targetPanel.Controls.Add(orderControl);
                }
            }
        }

        public void UpdateStatus(KitchenAndBarUserControl userControl)
        {
            flowLayoutPanelRunning.Controls.Remove(userControl);
            flowLayoutPanelFinished.Controls.Add(userControl);
            ShowCurrentPanel(flowLayoutPanelRunning);
        }

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