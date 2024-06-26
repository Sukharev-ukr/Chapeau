﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Service;
using UI.Login;
using UI.PaymentSystem;
using static Service.PaymentService;

namespace UI.PaymentSystem
{
    public partial class BillCompleted : Form
    {
        Order currentOrder;
        public BillCompleted(Order currentOrder)
        {
            this.currentOrder = currentOrder;

            InitializeComponent();
            LabelOrderNR.Text = currentOrder.OrderId.ToString();
            LoadBillListView(currentOrder);
            LoadLabels(currentOrder);
        }

        private void LoadBillListView(Order currentOrder)
        {
            listViewBillList.Items.Clear();
            foreach (OrderItem item in currentOrder.Items)
            {
                decimal sum = (item.Count * item.MenuItem.Price);


                ListViewItem li = new ListViewItem(item.MenuItem.Name);
                li.SubItems.Add(item.Count.ToString());
                li.SubItems.Add(item.MenuItem.Price.ToString());
                li.SubItems.Add((sum).ToString());
                li.SubItems.Add(((decimal)item.MenuItem.VAT * item.Count).ToString("F"));
                li.Tag = item.OrderId;

                listViewBillList.Items.Add(li);
            }
        }

        private void LoadLabels(Order currentOrder)
        {
            decimal subtotal = currentOrder.TotalAmount - currentOrder.TipAmount - currentOrder.VAT;
            labelTotal.Text = currentOrder.TotalAmount.ToString("F");
            labelSubtotal.Text = subtotal.ToString("F");
            labelVAT.Text = currentOrder.VAT.ToString("F");


                labelTip.Visible = true;
                label8.Visible = true;
                labelTip.Text = currentOrder.TipAmount.ToString("F");  
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            TableView_Form tableView = new TableView_Form(currentOrder.Employee.Name);
            Program.WindowSwitcher(this, tableView);
        }
    }
}
