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

namespace UI.Login
{
    public partial class TableView_Form : Form
    {
        private TableDAL tableDAL;

        public TableView_Form()
        {
            InitializeComponent();
            tableDAL = new TableDAL();
            LoadTables();
        }

        private void LoadTables()
        {
            List<Table> tables = tableDAL.GetAllTables();
            int x = 20, y = 80; // Starting position for placing tables

            foreach (var table in tables)
            {
                Panel tablePanel = CreateTablePanel(table);
                tablePanel.Location = new Point(x, y);

                this.Controls.Add(tablePanel);

                y += tablePanel.Height + 20; // Adjust the y-coordinate for the next table
                if (y + tablePanel.Height + 20 > this.Height)
                {
                    y = 80;
                    x += tablePanel.Width + 20;
                }
            }
        }

        private Panel CreateTablePanel(Table table)
        {
            Panel panel = new Panel
            {
                Width = 100,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblTableID = new Label
            {
                Text = table.TableId.ToString(),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Roboto", 64, FontStyle.Regular),
                ForeColor = Color.Black
            };

            panel.Controls.Add(lblTableID);

            switch (table.Status)
            {
                case TableStatus.free:
                    panel.BackColor = Color.FromArgb(255, 108, 255, 84);
                    break;
                case TableStatus.reserved:
                    panel.BackColor = Color.FromArgb(255, 254, 231, 24);
                    break;
                case TableStatus.occupied:
                case TableStatus.Ordered:
                    panel.BackColor = Color.FromArgb(255, 255, 86, 86);
                    break;
                default:
                    panel.BackColor = Color.Gray;
                    break;
            }

            return panel;
        }

    }
}
