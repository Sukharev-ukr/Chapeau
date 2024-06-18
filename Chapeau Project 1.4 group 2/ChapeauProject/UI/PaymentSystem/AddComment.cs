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

namespace UI.PaymentSystem
{
    public partial class AddComment : Form
    {
        Order currentOrder;
        public AddComment(Order order)
        {
            currentOrder = order;
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            currentOrder.Feedback = richTextComment.Text;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
