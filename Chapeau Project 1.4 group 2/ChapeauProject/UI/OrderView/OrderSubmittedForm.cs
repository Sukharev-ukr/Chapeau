using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Login;

namespace UI.OrderView
{
    public partial class OrderSubmittedForm : Form
    {
        public OrderSubmittedForm()
        {
            InitializeComponent();
        }

        private void btnOrderMainScreen_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm();

            Program.WindowSwitcher(this, newForm);
        }
    }
}
