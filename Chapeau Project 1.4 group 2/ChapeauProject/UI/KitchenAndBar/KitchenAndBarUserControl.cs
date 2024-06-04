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
        }

        public void UpdateOrderDetails(Order order)
        {
            // Clear previous orders
            listViewOrderItems.Items.Clear();

            // Add new orders
            lblTableNumber.Text = $"Table {order.Table.tableNumber}";
            lblOrderStatus.Text = order.Items.First().OrderStatus.ToString();
            lblOrderTime.Text = order.OrderTime?.ToString("HH:mm:ss");

            listViewOrderItems.Items.Clear();
            foreach (var item in order.Items)
            {
                ListViewItem viewItem = new ListViewItem($"{item.Count}x {item.MenuItem.Name}");
                viewItem.Tag = item;
            }

            
        }
    }
}
