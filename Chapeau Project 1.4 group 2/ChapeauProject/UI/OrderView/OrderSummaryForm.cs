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
        public OrderSummaryForm()
        {
            InitializeComponent();
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
