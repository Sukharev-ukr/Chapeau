using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.OrderView
{
    public partial class OrderSummaryForm : Form
    {
        private OrderService orderService;

        public OrderSummaryForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void OrderSummaryForm_Load(object sender, EventArgs e)
        {
            LoadOrderSummaries(10);
        }

        private void LoadOrderSummaries(int orderId)
        {
            pnlOrderSummary.Controls.Clear();

            List<OrderItem> orderItems = orderService.GetOrderItemsByOrderId(orderId);

            int verticalPosition = 5;

            foreach (OrderItem item in orderItems)
            {
                UCOrderSummary ucOrderSummary = new UCOrderSummary();
                ucOrderSummary.Item = item;
                ucOrderSummary.Location = new Point(5, verticalPosition);
                verticalPosition += ucOrderSummary.Height + 5;
                ucOrderSummary.Visible = true;

                pnlOrderSummary.Controls.Add(ucOrderSummary);
            }
        }

        private void btnOrderSummaryMenu_Click(object sender, EventArgs e)
        {
            OrderViewForm newForm = new OrderViewForm();
            Program.WindowSwitcher(this, newForm);
        }

        private void btnOrderSummarySubmit_Click(object sender, EventArgs e)
        {
            OrderSubmittedForm newForm = new OrderSubmittedForm();
            Program.WindowSwitcher(this, newForm);
        }
    }
}
