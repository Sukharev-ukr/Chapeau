using DAL;
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
    public partial class KitchenAndBarUserControl : UserControl
    {
        public Order currentOrder;
        private OrderItemService orderItemService;

        public KitchenAndBarUserControl(Order order)
        {
            InitializeComponent();
            currentOrder = order;
            orderItemService = new OrderItemService();
        }

        public void UpdateOrderDetails(Order order)
        {
            currentOrder = order;
            // Clear previous orders
            listViewOrderItems.Items.Clear();

            // Add new orders
            lblTableNumber.Text = $"Table {order.Table.TableNumber}";
            lblOrderTime.Text += order.OrderTime?.ToString("HH:mm");
            // Disable the comboBoxStatus if the order is ready
            if (order.OrderStatus == Status.ready)
            {
                comboBoxStatus.Enabled = false;
            }
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            lblCategory.Text = orderItem.MenuItem.Category.ToString();
            comboBoxStatus.Text=orderItem.OrderStatus.ToString();
            ListViewItem listViewItem = new ListViewItem($"{orderItem.Count}x {orderItem.MenuItem.Name}");
            listViewItem.Tag = orderItem;
            listViewOrderItems.Items.Add(listViewItem);

            // Calculate the TimeSpan if OrderTime is not null
            if (orderItem.OrderTime.HasValue)
            {
                TimeSpan timeSpan = DateTime.Now - orderItem.OrderTime.Value;
                lblOrderItemTime.Text = $"Waiting: {(int)timeSpan.TotalHours:D2}:{timeSpan.Minutes:D2}";
            }
        }


        //// Event handler for ComboBox selection change
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
            }

            //update main form
        }
    }
}
