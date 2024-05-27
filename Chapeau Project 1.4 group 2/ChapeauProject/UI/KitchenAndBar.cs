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

namespace View
{
    public partial class KitchenAndBar : Form
    {
        public KitchenAndBar()
        {
            InitializeComponent();
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
            ShowCurrentPanel(pnlRunningOrders);
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCurrentPanel(pnlFinishedOrders);
        }

        //??
        public void GetOrders(Employee employee)
        {
            OrderService orderService = new OrderService();
            List<Order> orders = new List<Order>();

            orders.AddRange(orderService.GetOrders(employee.Role == Role.Bartender, Status.BeingPrepared));
            orders.AddRange(orderService.GetOrders(employee.Role == Role.Bartender, Status.Placed));
            orders.AddRange(orderService.GetOrders(employee.Role == Role.Bartender, Status.Ready));
            orders.AddRange(orderService.GetOrders(employee.Role == Role.Bartender, Status.Served));

            DisplayOrders(orderService);
            
        }

        private void DisplayOrders(OrderService orderService)
        {
            AddItemToGroupBox(orderService.starters, groupBoxStarter1);
            AddItemToGroupBox(orderService.mains, groupBoxMain1);
            AddItemToGroupBox(orderService.deserts, groupBoxDesert1);
        }

        private void AddItemToGroupBox(List<OrderItem> orderItems, GroupBox groupBox)
        {
            foreach (OrderItem item in orderItems)
            {
                Label label = new Label();
                label.Text = $"{item.Count}x {item.MenuItem.Name} \n{item.Comment}\n";
                groupBox.Controls.Add(label);
            }
        }

        private void btnStarter1_Click(object sender, EventArgs e)
        {
            btnStarter1.Text = "Done";
        }

        private void btnMain1_Click(object sender, EventArgs e)
        {
            btnMain1.Text = "Done";
        }

        private void btnDesert1_Click(object sender, EventArgs e)
        {
            btnDesert1.Text = "Done";
        }
    }
}