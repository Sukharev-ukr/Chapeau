using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;
using Service;

namespace View
{
    public partial class KitchenAndBar : Form
    {
<<<<<<< Updated upstream:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBar.cs
        public KitchenAndBar()
        {
            InitializeComponent();
=======
        protected KitchenAndBarUserControl kitchenAndBarUserControl;
        protected Employee currentEmployee;

        public KitchenAndBarForm()
        {
            InitializeComponent();
            currentEmployee = new Employee();
            kitchenAndBarUserControl = new KitchenAndBarUserControl();
            this.Controls.Add(kitchenAndBarUserControl);
>>>>>>> Stashed changes:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBarForm.cs
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
            kitchenAndBarUserControl.GetRunningOrders(currentEmployee);
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCurrentPanel(pnlFinishedOrders);
<<<<<<< Updated upstream:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBar.cs
=======
            kitchenAndBarUserControl.GetFinishedOrders(currentEmployee);
>>>>>>> Stashed changes:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBarForm.cs
        }

        public void GetRunningOrders()
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.GetOrders(employee.Role == Role.Bartender, Status.Placed);
            orders.AddRange(orderService.GetOrders(employee.Role == Role.Bartender, Status.BeingPrepared));

<<<<<<< Updated upstream:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBar.cs
            DisplayOrders(orderService);
            
=======
            DisplayOrders(orders);
        }

        public void GetFinishedOrders()
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.GetOrders(employee.Role == Role.Bartender, Status.Ready);
            orders.AddRange(orderService.GetOrders(employee.Role == Role.Bartender, Status.Served));
>>>>>>> Stashed changes:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBarForm.cs
        }

        private void DisplayOrders(OrderService orderService)
        {
<<<<<<< Updated upstream:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBar.cs
            AddItemToGroupBox(orderService.starters, groupBoxStarter1);
            AddItemToGroupBox(orderService.mains, groupBoxMain1);
            AddItemToGroupBox(orderService.deserts, groupBoxDesert1);
=======
            OrderService orderService = new OrderService();
            orderService.CategorizeItems(orders);

            DisplayOrderItems(orderService.starters, listViewStarters);
            DisplayOrderItems(orderService.mains, listViewMain);
            DisplayOrderItems(orderService.deserts, listViewDesert);
            DisplayOrderItems(orderService.drinks, listViewDrinks);
>>>>>>> Stashed changes:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBarForm.cs
        }

        private void DisplayOrderItems(List<OrderItem> items, ListView listView)
        {
            listView.Items.Clear();

            foreach (OrderItem item in items)
            {
                ListViewItem listItem = new ListViewItem(item.OrderTime.ToString());
                listItem.SubItems.Add(item.MenuItem.Category.ToString());
                listItem.SubItems.Add($"{item.Count}x {item.MenuItem.Name}");
                listItem.SubItems.Add(item.Comment);

                listItem.Tag = item;
                listView.Items.Add(listItem);
            }
        }
    }
<<<<<<< Updated upstream:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBar.cs
}
=======
}
>>>>>>> Stashed changes:Chapeau Project 1.4 group 2/ChapeauProject/UI/KitchenAndBarForm.cs
