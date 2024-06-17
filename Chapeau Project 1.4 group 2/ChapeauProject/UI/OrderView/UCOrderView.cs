﻿using DAL;
using Model;
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

namespace UI.OrderView
{
    public partial class UCOrderView : UserControl
    {
        private OrderDAL orderDal;
        private OrderService orderService; 
        private int currentOrderId;
        private MenuItem _item;
        private Dictionary<int, int> _quantityDict = new Dictionary<int, int>();

        public UCOrderView()
        {
            InitializeComponent();
            orderService = new OrderService(); 
        }

        public int Quantity
        {
            get { return _quantityDict.ContainsKey(_item.Id) ? _quantityDict[_item.Id] : 0; }
        }

        public MenuItem Item
        {
            get { return _item; }
            set
            {
                _item = value;
                if (_item != null)
                {
                    lblItemName.Text = _item.Name;

                    int orderId = orderService.GetCurrentOrderId();
                    OrderItemDAL orderItemDal = new OrderItemDAL();
                    int quantity = orderItemDal.GetQuantityByItemId(orderId, _item.Id);

                    _quantityDict[_item.Id] = quantity;

                    lblItemAmount.Text = _quantityDict[_item.Id].ToString();

                    if (_item.Stock == 0)
                    {
                        btnMinus.Enabled = false;
                        btnPlus.Enabled = false;

                        this.BackColor = Color.Gray;
                    }
                    else
                    {
                        btnMinus.Enabled = true;
                        btnPlus.Enabled = true;

                        this.BackColor = SystemColors.Control;
                    }
                }
            }
        }




        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (_quantityDict[_item.Id] > 0)
            {
                _quantityDict[_item.Id]--;
                lblItemAmount.Text = _quantityDict[_item.Id].ToString();
                (this.ParentForm as OrderViewForm)?.UpdateTotalPrice();

                int orderId = orderService.GetCurrentOrderId();

                OrderItemDAL orderItemDal = new OrderItemDAL();
                if (_quantityDict[_item.Id] == 0)
                {
                    orderItemDal.DeleteOrderItem(orderId, _item.Id);
                }
                else
                {
                    orderItemDal.UpdateQuantity(orderId, _item.Id, _quantityDict[_item.Id]);
                }

                _item.Stock++;

                btnMinus.Enabled = true;
                btnPlus.Enabled = true;

                this.BackColor = SystemColors.Control;
            }
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (_item.Stock > 0)
            {
                _quantityDict[_item.Id]++;
                lblItemAmount.Text = _quantityDict[_item.Id].ToString();
                (this.ParentForm as OrderViewForm)?.UpdateTotalPrice();

                int orderId = orderService.GetCurrentOrderId();

                string status = "placed";
                DateTime statusTime = DateTime.Now;

                OrderItemDAL orderItemDal = new OrderItemDAL();
                orderItemDal.AddOrUpdateOrderItem(orderId, _item.Id, _quantityDict[_item.Id], status, statusTime);

                _item.Stock--;

                if (_item.Stock == 0)
                {
                    btnMinus.Enabled = false;
                    btnPlus.Enabled = false;

                    this.BackColor = Color.Gray;
                }
            }
        }

        private void btnEditItemDetails_Click(object sender, EventArgs e)
        {
            OrderItemEditDetails editForm = new OrderItemEditDetails();
            editForm.Item = this._item; 
            editForm.Show(); 
        }
    }
}