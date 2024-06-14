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
using static Service.PaymentService;

namespace UI.PaymentSystem
{
    public partial class AddComment : Form
    {
        public AddComment()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            CurrentOrder currentOrder = CurrentOrder.Getinstance();

            currentOrder.Comment = richTextComment.Text;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
