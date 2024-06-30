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
        private OrderService orderService;
        private TimeSpan waitingTime;
        private Timer orderUpdateTimer;

        public KitchenAndBarUserControl(Order order)
        {
            InitializeComponent();
            InitializeOrderUpdateTimer();
            currentOrder = order;
            orderItemService = new OrderItemService();
            orderService = new OrderService();
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged; // Subscribe to the event
        }

        private void InitializeOrderUpdateTimer()
        {
            orderUpdateTimer = new Timer();
            orderUpdateTimer.Interval = 1000; // Set the interval to 1 second (1000 milliseconds)
            orderUpdateTimer.Tick += OrderUpdateTimer_Tick; // every time the timer's interval elapses, the OrderUpdateTimer_Tick method will be called automatically.
            orderUpdateTimer.Start();
        }

        private void OrderUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Iterate through the ListView items and update UI
            foreach (ListViewItem item in listViewOrderItems.Items)
            {
                OrderItem currentOrderItem = (OrderItem)item.Tag;
                if (currentOrderItem != null)
                {
                    UpdateOrderItemUI(currentOrderItem);
                }
            }
        }

        private void UpdateOrderItemUI(OrderItem orderItem)
        {
            if (orderItem.OrderStatus == Status.ready)
            {
                lblOrderTime.Visible = false; // Hide the label when order is ready
                lblOrderItemTime.Visible = false; // Hide the label when order is ready
            }
            else
            {
                waitingTime = DateTime.Now - orderItem.OrderTime.Value;
                lblOrderTime.Visible = true; // Show the label when order is not ready
                lblOrderItemTime.Visible = true; // Show the label when order is not ready
                lblOrderTime.Text = $"Placed at: {orderItem.OrderTime?.ToString("HH:mm")}";
                lblOrderItemTime.Text = $"Waiting: {waitingTime.ToString(@"mm\:ss")}";
            }
        }

        public void UpdateOrderDetails(Order order)
        {
            currentOrder = order;
            listViewOrderItems.Items.Clear(); // Clear previous orders
            lblTableNumber.Text = $"Table {order.Table.TableNumber}"; // Add new orders
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            lblCategory.Text = orderItem.MenuItem.Category.ToString();
            comboBoxStatus.Text = orderItem.OrderStatus.ToString();

            // Fill list view
            ListViewItem listViewItem = new ListViewItem($"{orderItem.Count}x {orderItem.MenuItem.Name}");
            listViewItem.SubItems.Add(orderItem.Comment);
            listViewItem.Tag = orderItem;
            listViewOrderItems.Items.Add(listViewItem);

            SetUserControlColor(orderItem);
        }

        private void SetUserControlColor(OrderItem orderItem)
        {
            switch (orderItem.OrderStatus)
            {
                case Status.placed:
                    groupBoxOrder.BackColor = Color.WhiteSmoke;
                    break;
                case Status.BeingPrepared:
                    groupBoxOrder.BackColor = Color.LightYellow;
                    break;
                case Status.ready:
                    groupBoxOrder.BackColor = Color.LightGreen;
                    comboBoxStatus.Visible = false;
                    break;
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newStatus = comboBoxStatus.SelectedItem.ToString();
            bool ready = false;

            foreach (ListViewItem item in listViewOrderItems.Items)
            {
                OrderItem orderItem = item.Tag as OrderItem;

                if (orderItem != null)
                {
                    orderItem.OrderStatus = (Status)Enum.Parse(typeof(Status), newStatus);
                    orderItemService.UpdateOrderItemStatus(orderItem, newStatus);
                    SetUserControlColor(orderItem);

                    if (orderItem.OrderStatus == Status.ready)
                    {
                        ready = true;
                    }
                    else
                    {
                        ready = false;
                    }
                }
            }

            OrderUpdateTimer_Tick(sender, e); // Update the UI to reflect the changes 
            CheckAndUpdateOrderStatus();

            if (ready)
            {
                NotifyOrderOverview();
            }
        }

        public void CheckAndUpdateOrderStatus()
        {
            bool allItemsReady = currentOrder.Items.All(item => item.OrderStatus == Status.ready);
            if (currentOrder.OrderStatus == Status.running)
            {
                if (allItemsReady)
                {
                    orderService.UpdateOrderStatus(currentOrder.OrderId, Status.ready);
                    currentOrder.OrderStatus = Status.ready;
                }
                else if (currentOrder.OrderStatus != Status.ready)
                {
                    orderService.UpdateOrderStatus(currentOrder.OrderId, Status.running);
                }
            }
            
        }

        private void NotifyOrderOverview()
        {
            // Notify the parent form to update the status
            OrderOverview orderOverview = this.FindForm() as OrderOverview;
            if (orderOverview != null)
            {
                orderOverview.UpdateStatus(this);
            }
        }
    }

}