using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Login
{
    public partial class TableUserControl : UserControl
    {
        public int TableNumber
        {
            get => int.Parse(lblTableNumber.Text);
            set => lblTableNumber.Text = value.ToString();
        }

        public TableUserControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        public void UpdateStatus(string status)
        {
            switch (status)
            {
                case "Free":
                    this.BackColor = ColorTranslator.FromHtml("#6CFF54");
                    break;
                case "Reserved":
                    this.BackColor = ColorTranslator.FromHtml("#FEE718");
                    break;
                case "Occupied":
                    this.BackColor = ColorTranslator.FromHtml("#FF5656");
                    break;
                default:
                    this.BackColor = Color.Gray;
                    break;
            }
        }   

    }
}
