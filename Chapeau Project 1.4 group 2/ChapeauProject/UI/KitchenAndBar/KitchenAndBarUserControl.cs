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

        public KitchenAndBarUserControl()
        {
            InitializeComponent();
            comboBoxStatus.SelectedIndex = 0; // Set default to 'Start'
        }

        public void UpdateOrderDetails(Order order)
        {
            currentOrder = order;
            // Clear previous orders
            listViewOrderItems.Items.Clear();

            // Add new orders
            lblTableNumber.Text = $"Table {order.Table.TableNumber}";
            lblOrderTime.Text = order.OrderTime?.ToString("HH:mm:ss");
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            lblCategory.Text = orderItem.MenuItem.Category.ToString();
            ListViewItem listViewItem = new ListViewItem($"{orderItem.Count}x {orderItem.MenuItem.Name}");
            listViewItem.Tag = orderItem;
            listViewOrderItems.Items.Add(listViewItem);
        }

      
        //// Event handler for ComboBox selection change
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if (currentOrder != null)
        //    {
        //        // Update the order status for all items in the order
        //        Status newStatus = (Status)Enum.Parse(typeof(Status), comboBoxStatus.SelectedItem.ToString());

        //        foreach (ListViewItem item in listViewOrderItems.Items)
        //        {
        //            OrderItem orderItem = item.Tag as OrderItem;
        //            orderItem.OrderStatus = newStatus;
        //            SaveOrderItemStatus(orderItem);
        //        }

        //        // Update the order's overall status
        //        currentOrder.OrderStatus = newStatus;

        //        // Notify the parent form about the status change
        //        OnOrderStatusChanged(newStatus);
        //    }
        }
    }
}
