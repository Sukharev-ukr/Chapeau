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
        private Order order;
        public Order Order
        {
            get { return order; }
        }

        public KitchenAndBarUserControl(Order order)
        {
            InitializeComponent();
            this.order = order;
            UpdateOrderDetails(order);
        }

        public void UpdateOrderDetails(Order order)
        {
            this.order = order;

            // Clear previous orders
            listViewOrderItems.Items.Clear();

            // Add new orders
            lblTableNumber.Text = $"Table {order.Table.TableNumber}";
            lblOrderStatus.Text = order.Items.First().OrderStatus.ToString();
            lblOrderTime.Text = order.OrderTime?.ToString("HH:mm:ss");

            listViewOrderItems.Items.Clear();

            // Add new order items
            foreach (OrderItem item in order.Items)
            {
                ListViewItem viewItem = new ListViewItem($"{item.Count}x {item.MenuItem.Name}")
                {
                    Tag = item
                };

                listViewOrderItems.Items.Add(viewItem);
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            // Change order status logic
            string newStatus = "Completed"; // Example status change
            KitchenAndBarDao kitchenAndBarDao = new KitchenAndBarDao();
            kitchenAndBarDao.ChangeStatus(order.OrderId, newStatus);

            // Update order status in UI
            lblOrderStatus.Text = newStatus;
        }
    }
}
