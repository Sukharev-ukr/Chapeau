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
using Model;
using Service;

namespace UI
{
    public partial class KitchenAndBarForm : Form
    {
        private KitchenAndBarUserControl KitchenAndBarUserControl;

        public KitchenAndBarForm()
        {
            InitializeComponent();
            KitchenAndBarUserControl = new KitchenAndBarUserControl();
            this.Controls.Add(KitchenAndBarUserControl);
        }

        private void LoadOrders(bool drinks, Status status)
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.GetOrders(drinks, status);
            DisplayOrders(orders);
        }

        // showing the current panel
        private void ShowCurrentPanel(Panel panel)
        {
            foreach (Control control in Controls)
            {
                if (control is Panel)
                {
                    control.Hide();
                }
            }
            panel.Show();
        }

        private void runningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOrders(false, Status.Placed);
            LoadOrders(false, Status.BeingPrepared);
            ShowCurrentPanel(pnlRunningOrders);
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOrders(false, Status.Ready);
            LoadOrders(false, Status.Served);
            ShowCurrentPanel(pnlFinishedOrders);
        }
        public void DisplayOrders(List<Order> orders)
        {
            foreach (Order order in orders)
            {
                KitchenAndBarUserControl.DisplayOrder(order);
            }
        }
    }
}
