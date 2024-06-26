﻿using DAL;
using Model;
using Service;
using System.Windows.Forms;
using UI.Login;
using UI.PaymentSystem;


namespace UI.OrderView
{
    public partial class OrderViewForm : Form
    {
        OrderService orderService;
        Dictionary<string, UCOrderView> ucOrderViews = new Dictionary<string, UCOrderView>();
        private StaffService staffService;

        private int tableNr;
        private int employeeId;
        private string employeeName;

        public OrderViewForm(int tableNr, int employeeId)
        {
            InitializeComponent();
            orderService = new OrderService();
            this.tableNr = tableNr;
            this.employeeId = employeeId;

            DisplayOrderInfo(tableNr, employeeId);
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Lunch");
        }

        private void btnDiner_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Diner");
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Drinks");
        }

        private void LoadMenuItems(string card)
        {
            pnlOrderView.Controls.Clear();

            List<MenuItem> menuItems = orderService.GetMenuItemsByCard(card);

            int verticalPosition = 5;

            foreach (MenuItem item in menuItems)
            {
                UCOrderView ucOrderView;
                if (!ucOrderViews.TryGetValue(item.Name, out ucOrderView))
                {
                    Order runningOrder = orderService.GetRunningOrderFromTable(this.tableNr, this.employeeId);
                    int orderId = runningOrder.OrderId;
                    ucOrderView = new UCOrderView(orderId);
                    ucOrderView.Item = item;
                    ucOrderViews[item.Name] = ucOrderView;
                }

                ucOrderView.Location = new Point(5, verticalPosition);
                verticalPosition += ucOrderView.Height + 5;
                ucOrderView.Visible = true;

                pnlOrderView.Controls.Add(ucOrderView);
            }
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            LoadMenuItems("Lunch");
        }

        public void UpdateTotalPrice()
        {
            decimal totalPrice = 0m;
            foreach (var ucOrderView in ucOrderViews.Values)
            {
                int quantity = ucOrderView.Quantity;
                decimal price = ucOrderView.Item.Price;
                totalPrice += quantity * price;
            }
            lblOrderViewTotalPrice.Text = $"€{totalPrice:F2}";
        }

        private void DisplayOrderInfo(int tableNr, int employeeId)
        {
            Order runningOrder = orderService.GetRunningOrderFromTable(tableNr, employeeId);
            lblTableNr.Text = $"Table: {tableNr}";
            lblOrderId.Text = $"({runningOrder.OrderId})";
        }

        private void btnOrderViewSubmit_Click(object sender, EventArgs e)
        {
            OrderSubmittedForm newForm = new OrderSubmittedForm();

            Program.WindowSwitcher(this, newForm);
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

            Order runningOrder = orderService.GetRunningOrderFromTable(this.tableNr, this.employeeId);
            int orderId = runningOrder.OrderId;

            orderService.DeleteOrder(orderId);

            pnlOrderView.Controls.Clear();

            TableView_Form newForm = new TableView_Form(employeeName);

            Program.WindowSwitcher(this, newForm);
        }
    }
}
