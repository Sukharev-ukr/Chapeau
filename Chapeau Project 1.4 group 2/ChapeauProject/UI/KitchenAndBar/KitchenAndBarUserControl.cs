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
        public KitchenAndBarUserControl()
        {
            InitializeComponent();
        }

        public void DisplayOrder(Order order)
        {
            listViewOrder.Items.Clear(); // Clear existing items

            foreach (OrderItem orderItem in order.Items)
            {
                ListViewItem item = new ListViewItem(order.Table.ToString());
                item.SubItems.Add(order.OrderTime.ToString());
                item.SubItems.Add(orderItem.MenuItem.Category.ToString());
                item.SubItems.Add($"{orderItem.Count.ToString()}x {orderItem.MenuItem.Name.ToString()}");
                item.SubItems.Add(orderItem.OrderStatus.ToString());

                // Add a tag to store the order object
                item.Tag = order;

                listViewOrder.Items.Add(item);
            }
        }
    }
}
