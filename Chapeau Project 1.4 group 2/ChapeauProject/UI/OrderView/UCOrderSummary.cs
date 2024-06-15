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
    public partial class UCOrderSummary : UserControl
    {
        private OrderItem _item;
        private Dictionary<int, int> _quantityDict = new Dictionary<int, int>();

        public UCOrderSummary()
        {
            InitializeComponent();
        }

        public OrderItem Item
        {
            get { return _item; }
            set
            {
                _item = value;
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            if (_item != null)
            {
                lblItemNameOrderSummary.Text = _item.MenuItem.Name;
                if (!_quantityDict.ContainsKey(_item.ItemId))
                {
                    _quantityDict[_item.ItemId] = _item.Count;
                }
                lblItemAmountOrderSummary.Text = _quantityDict[_item.ItemId].ToString();
            }
        }

        private void btnMinusOrderSummary_Click(object sender, EventArgs e)
        {
            if (_quantityDict[_item.ItemId] > 0)
            {
                _quantityDict[_item.ItemId]--;
                lblItemAmountOrderSummary.Text = _quantityDict[_item.ItemId].ToString();

                int orderId = _item.OrderId;

                OrderItemDAL orderItemDal = new OrderItemDAL();
                if (_quantityDict[_item.ItemId] == 0)
                {
                    orderItemDal.DeleteOrderItem(orderId, _item.ItemId);
                }
                else
                {
                    orderItemDal.UpdateQuantity(orderId, _item.ItemId, _quantityDict[_item.ItemId]);
                }
            }
        }

        private void btnPlusOrderSummary_Click(object sender, EventArgs e)
        {
            _quantityDict[_item.ItemId]++;
            lblItemAmountOrderSummary.Text = _quantityDict[_item.ItemId].ToString();

            int orderId = _item.OrderId;
            string status = "placed";
            DateTime statusTime = DateTime.Now;

            OrderItemDAL orderItemDal = new OrderItemDAL();
            orderItemDal.AddOrUpdateOrderItem(orderId, _item.ItemId, _quantityDict[_item.ItemId], status, statusTime);
        }

        private void UCOrderSummary_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
