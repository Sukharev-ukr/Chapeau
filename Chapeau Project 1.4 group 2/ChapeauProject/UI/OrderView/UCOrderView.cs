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
        public UCOrderView()
        {
            InitializeComponent();
            //lblItemName = new Label();
            //lblItemName.AutoSize = true;
            //this.Controls.Add(lblItemName);
        }

        private MenuItem _item;

        public MenuItem Item
        {
            get { return _item; }
            set
            {
                _item = value;
                if (_item != null)
                {
                    lblItemName.Text = _item.Name; // Set the label text to the item name
                }
                else
                {
                    lblItemName.Text = "Item Not Available"; // Handle the case when _item is null
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblItemName.Text = "Minus Clicked";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // item.quan++
            // change lbl of tetx
            // update select items
        }
    }
}