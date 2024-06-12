﻿using Model;
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
    public partial class OrderView : Form
    {
        private OrderService orderService;
        private OrderItemService orderItemService;
        private Employee employee;
        private bool isChef;
        private Timer clockTimer;

        public OrderView(/*Employee employee*/)
        {
            this.employee = employee;
            orderService = new OrderService();
            orderItemService = new OrderItemService();
            //lblEmployee.Text =employee.Name;
           
            InitializeComponent();
            InitializeFlowLayoutPanel();
            InitializeClockTimer();
        }

        private void InitializeClockTimer()
        {
            clockTimer = new Timer();
            clockTimer.Interval = 1000; // interval set to 1 second (1000 milliseconds)
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm");
           // lblEmployee.Text = employee.Name;
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
            // Determine the role of the logged-in user
            isChef = true;
            List<Order> orders = orderService.GetAllOrders();
            Dictionary<Order, Dictionary<Category, List<OrderItem>>> ordersItems = new Dictionary<Order, Dictionary<Category, List<OrderItem>>>();
            GetItemsByCategory(ordersItems);

            return ordersItems;
        }

        private void GetItemsByCategory(Dictionary<Order, Dictionary<Category, List<OrderItem>>> ordersItems)
        {
            List<Order> orders = orderService.GetAllOrders();
            foreach (Order order in orders)
            {
                Dictionary<Category, List<OrderItem>> itemsByCategory = new Dictionary<Category, List<OrderItem>>();

                CategorizeOrdersByRole(order, itemsByCategory);

                // Add the categorized items to the ordersItems dictionary
                ordersItems.Add(order, itemsByCategory);
            }
        }

        private void CategorizeOrdersByRole(Order order, Dictionary<Category, List<OrderItem>> itemsByCategory)
        {
            if (isChef)
            {
                // Show kitchen orders 
                foreach (Category category in Enum.GetValues(typeof(Category)))
                {
                    if (category != Category.Drinks) // Exclude drinks if the user is a chef
                    {
                        List<OrderItem> items = orderItemService.GetOrderItemsByCategory(order.OrderId, category.ToString());
                        itemsByCategory[category] = items;
                    }
                }
            }
            else
            {
                // Show bar orders 
                List<OrderItem> drinkItems = orderItemService.GetOrderItemsByCategory(order.OrderId, Category.Drinks.ToString());
                itemsByCategory[Category.Drinks] = drinkItems;
            }
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

                CreateOrders(orders);
            }
            catch (Exception e)
            {
                // Handle exception
                MessageBox.Show("Something went wrong while loading the orders: " + e.Message);
            }
        }

        private void CreateOrders(Dictionary<Order, Dictionary<Category, List<OrderItem>>> orders)
        {
            foreach (var orderPair in orders)
            {
                var order = orderPair.Key;
                var itemsByCategory = orderPair.Value;

                foreach (var categoryPair in itemsByCategory)
                {
                    var category = categoryPair.Key;
                    var orderItems = categoryPair.Value;

                    CreateUserControl(order, orderItems);
                }
            }
        }

        private void CreateUserControl(Order order, List<OrderItem> orderItems)
        {
            if (orderItems.Count > 0)
            {
                // Create a new KitchenAndBarUserControl for each order category
                KitchenAndBarUserControl orderControl = new KitchenAndBarUserControl(order);
                orderControl.UpdateOrderDetails(order);

                foreach (OrderItem orderItem in orderItems)
                {
                    orderControl.AddOrderItem(orderItem);
                    FlowLayoutPanel targetPanel = (orderItem.OrderStatus == Status.ready || orderItem.OrderStatus == Status.served) ? flowLayoutPanelFinished : flowLayoutPanelRunning;
                    targetPanel.Controls.Add(orderControl);
                }
            }
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