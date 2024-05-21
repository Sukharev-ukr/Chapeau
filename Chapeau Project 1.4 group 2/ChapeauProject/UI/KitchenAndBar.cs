using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class KitchenAndBar : Form
    {
        public KitchenAndBar()
        {
            InitializeComponent();
        }

        public void ShowKitchen(List<Order> orders)
        {
            //clear existing list view
            listViewKitchenOrders.Items.Clear();

            foreach(Order order in orders)
            {
                ListViewItem item = new ListViewItem(order.orderId.ToString());
                item.SubItems.Add(order.table.tableNumber.ToString());
                item.SubItems.Add(order.orderTime.ToString());
                item.SubItems.Add(order.orderStatus.ToString());

                item.Tag = order;

                listViewKitchenOrders.Items.Add(item);
            }
        }

        public void ShowBar(List<Order> orders)
        {
            //clear existing list view
            listViewBarOrders.Items.Clear();

            foreach (Order order in orders)
            {
                ListViewItem item = new ListViewItem(order.orderId.ToString());
                item.SubItems.Add(order.table.tableNumber.ToString());
                item.SubItems.Add(order.orderTime.ToString());
                item.SubItems.Add(order.orderStatus.ToString());

                item.Tag = order;

                listViewKitchenOrders.Items.Add(item);
            }
        }
    }
}