using DAL;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace UI
{
    public partial class KitchenAndBarUserControl : UserControl
    {
        public Order currentOrder;
        private OrderItemService orderItemService;
        DateTime finishedTime;
        TimeSpan waitingTime;
        private Timer orderUpdateTimer;
        public event EventHandler StatusChanged;

        public KitchenAndBarUserControl(Order order)
        {
            InitializeComponent();
            InitializeOrderUpdateTimer();
            currentOrder = order;
            orderItemService = new OrderItemService();
        }

        private void InitializeOrderUpdateTimer()
        {
            orderUpdateTimer = new Timer();
            orderUpdateTimer.Interval = 1000; // Set the interval to 1 second (1000 milliseconds)
            orderUpdateTimer.Tick += OrderUpdateTimer_Tick;
            orderUpdateTimer.Start();
        }

        private void OrderUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Iterate through the ListView items
            foreach (ListViewItem item in listViewOrderItems.Items)
            {
                OrderItem orderItem = (OrderItem)item.Tag;
                waitingTime = DateTime.Now - orderItem.OrderTime.Value;

                lblOrderItemTime.Text = $"Waiting: {waitingTime.ToString(@"mm':'ss''")}";
            }
        }

        public void UpdateOrderDetails(Order order)
        {
            currentOrder = order;
            // Clear previous orders
            listViewOrderItems.Items.Clear();

            // Add new orders
            lblTableNumber.Text = $"Table {order.Table.TableNumber}";
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            lblCategory.Text = orderItem.MenuItem.Category.ToString();
            comboBoxStatus.Text=orderItem.OrderStatus.ToString();
            waitingTime = DateTime.Now - orderItem.OrderTime.Value;
            finishedTime = DateTime.Now - waitingTime;

            ListViewItem listViewItem = new ListViewItem($"{orderItem.Count}x {orderItem.MenuItem.Name}");
            listViewItem.SubItems.Add($"   -{orderItem.Comment}");
            listViewItem.Tag = orderItem;
            listViewOrderItems.Items.Add(listViewItem);

            // hide the comboBoxStatus if the order is ready
            if (orderItem.OrderStatus == Status.ready)
            {
                comboBoxStatus.Hide();
                waitingTime = DateTime.Now - orderItem.OrderTime.Value;

                lblOrderItemTime.Hide();
                lblOrderTime.Text = $"Finished at: {finishedTime.ToString("HH:mm")}";
                lblOrderItemTime.Text += $"Waited: {waitingTime.ToString(@"mm':'ss''")}";
            }
            else
            {
                lblOrderTime.Text = $"Placed at: {orderItem.OrderTime?.ToString("HH:mm")}";
                lblOrderItemTime.Text = $"Waiting: {(int)waitingTime.TotalHours:D2}:{waitingTime.Minutes:D2}";
            }

            // Calculate the TimeSpan if OrderTime is not null
            if (orderItem.OrderTime.HasValue)
            {
                waitingTime = DateTime.Now - orderItem.OrderTime.Value;
            }
        }


        // Event handler for ComboBox selection change
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newStatus = comboBoxStatus.SelectedItem.ToString();
            foreach (ListViewItem item in listViewOrderItems.Items)
            {
                OrderItem orderItem = item.Tag as OrderItem;
                if (orderItem != null)
                {
                    orderItem.OrderStatus = (Status)Enum.Parse(typeof(Status), newStatus);
                    orderItemService.UpdateOrderItemStatus(orderItem, newStatus);
                }
                if(orderItem.OrderStatus == Status.ready)
                {
                }
            }

            //update main form
            OnStatusChanged(EventArgs.Empty);
        }

        protected virtual void OnStatusChanged(EventArgs e)
        {
            StatusChanged?.Invoke(this, e);
        }
    }
}
