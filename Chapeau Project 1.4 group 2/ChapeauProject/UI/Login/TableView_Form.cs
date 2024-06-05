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

            int tableWidth = 100;
            int tableHeight = 100;
            int verticalSpacing = 80;
            int horizontalSpacing = 240;

            int totalTableHeight = (tables.Count / 2) * (tableHeight + verticalSpacing) - verticalSpacing;
            int startY = (this.ClientSize.Height - totalTableHeight) / 2; // Centering vertically

            int column1X = 170;  // Increased X position for the first column to add more left space
            int column2X = column1X + tableWidth + horizontalSpacing;  // X position for the second column

            int midPoint = tables.Count / 2;
            int currentY1 = startY;
            int currentY2 = startY;

            for (int i = 0; i < tables.Count; i++)
            {
                Panel tablePanel = CreateTablePanel(tables[i]);

                if (i < midPoint)
                {
                    // First column
                    tablePanel.Location = new Point(column1X, currentY1);
                    currentY1 += tableHeight + verticalSpacing;
                }
                else
                {
                    // Second column
                    tablePanel.Location = new Point(column2X, currentY2);
                    currentY2 += tableHeight + verticalSpacing;
                }

                this.Controls.Add(tablePanel);
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
                Font = new Font("Roboto", 40, FontStyle.Regular),
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
