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
        }

        private MenuItem _item;
        private Dictionary<int, int> _quantityDict = new Dictionary<int, int>();

        public MenuItem Item
        {
            get { return _item; }
            set
            {
                _item = value;
                if (_item != null)
                {
                    lblItemName.Text = _item.Name;
                    if (!_quantityDict.ContainsKey(_item.Id))
                    {
                        _quantityDict[_item.Id] = 0;
                    }
                    lblItemAmount.Text = _quantityDict[_item.Id].ToString();
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (_quantityDict[_item.Id] > 0) 
            {
                _quantityDict[_item.Id]--;
                lblItemAmount.Text = _quantityDict[_item.Id].ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _quantityDict[_item.Id]++;
            lblItemAmount.Text = _quantityDict[_item.Id].ToString();
        }
    }

}