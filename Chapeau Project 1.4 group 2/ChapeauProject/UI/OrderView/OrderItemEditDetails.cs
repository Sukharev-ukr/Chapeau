using DAL;
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
    public partial class OrderItemEditDetails : Form
    {
        private MenuItem _item;
        private int _orderId; 

        public OrderItemEditDetails(int orderId) 
        {
            InitializeComponent();
            _orderId = orderId; 
        }

        public MenuItem Item
        {
            get { return _item; }
            set
            {
                _item = value;
                UpdateNameLabel(_item);
                UpdatePriceLabel(_item);
            }
        }

        public void UpdateNameLabel(MenuItem item)
        {
            lblItemName.Text = item.Name;
        }

        public void UpdatePriceLabel(MenuItem item)
        {
            lblItemPrice.Text = $"€{item.Price:F2}"; 
        }

        private void btnSubmitComment_Click(object sender, EventArgs e)
        {
            string comment = tbCommentBox.Text;

            int itemId = _item.Id;

            OrderItemDAL orderItemDAL = new OrderItemDAL();
            orderItemDAL.UpdateOrderItemComment(_orderId, itemId, comment); 

            this.Close();
        }
    }
}
