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
        private Panel popupPanel;
        private Dictionary<TableStatus, List<Button>> statusButtons;

        public TableView_Form()
        {
            InitializeComponent();
            tableDAL = new TableDAL();
            InitializePopupPanel();
            LoadTables();
        }

        private void LoadTables()
        {
            List<Table> tables = tableDAL.GetAllTables();

            // Spacing values
            int tableWidth = 100;
            int tableHeight = 100;
            int verticalSpacing = 80; // Space between tables vertically
            int horizontalSpacing = 240; // Space between columns

            // Calculate the total height needed for the tables in one column
            int totalTableHeight = (tables.Count / 2) * (tableHeight + verticalSpacing) - verticalSpacing;

            // Calculate the starting Y position to center the tables vertically in the form
            int startY = (this.ClientSize.Height - totalTableHeight) / 2; // Centering vertically

            // X positions for the two columns
            int column1X = 170; // Position for the first row of tables
            int column2X = column1X + tableWidth + horizontalSpacing; // X position for the second column

            // Calculate the midpoint to split tables between the two columns
            int midPoint = tables.Count / 2;

            // Initial Y positions for both columns
            int currentY1 = startY;
            int currentY2 = startY;

            // Loop through each table and place it in the correct column and position
            for (int i = 0; i < tables.Count; i++)
            {
                // Create a button for each table
                Button tableButton = CreateTableButton(tables[i]);

                if (i < midPoint)
                {
                    // Here we are placing tables in the first column
                    tableButton.Location = new Point(column1X, currentY1);
                    // Update the Y position for the next table
                    currentY1 += tableHeight + verticalSpacing;
                }
                else
                {
                    // Here we are placing tables in the second column
                    tableButton.Location = new Point(column2X, currentY2);
                    // Update the Y position for the next table
                    currentY2 += tableHeight + verticalSpacing;
                }

                // Add the table button to the form
                this.Controls.Add(tableButton);
            }
        }

        private Button CreateTableButton(Table table)
        {
            Button button = new Button
            {
                Width = 100,
                Height = 100,
                Text = table.TableId.ToString(),
                Font = new Font("Roboto", 20, FontStyle.Regular),
                ForeColor = Color.Black,
                Tag = table,
                TextAlign = ContentAlignment.MiddleCenter,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };

            button.Click += TableButton_Click;

            switch (table.Status)
            {
                case TableStatus.free:
                    button.BackColor = Color.FromArgb(255, 108, 255, 84);
                    break;
                case TableStatus.reserved:
                    button.BackColor = Color.FromArgb(255, 254, 231, 24);
                    break;
                case TableStatus.occupied:
                case TableStatus.Ordered:
                    button.BackColor = Color.FromArgb(255, 255, 86, 86);
                    break;
                default:
                    button.BackColor = Color.Gray;
                    break;
            }

            return button;
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            // Retrieve the button that was clicked
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Retrieve the table object from the button's Tag property
                Table clickedTable = clickedButton.Tag as Table;
                if (clickedTable != null)
                {
                    // Handle the click event
                    ShowPopup(clickedTable);
                }
            }
        }

        private void ShowPopup(Table table)
        {
            Label lblStatus = popupPanel.Controls["lblStatus"] as Label;
            lblStatus.Text = $"Table - {table.TableId} ({table.Status})";

            // Adjust popupPanel location based on where you want to show it
            popupPanel.Location = new Point(this.ClientSize.Width / 2 - popupPanel.Width / 2, this.ClientSize.Height / 2 - popupPanel.Height / 2);
            popupPanel.Visible = true;

            // Clear existing buttons
            foreach (Control control in popupPanel.Controls)
            {
                if (control is Button)
                {
                    control.Visible = false;
                }
            }

            // Show buttons based on table status
            List<Button> buttonsToShow = statusButtons[table.Status];
            int startX = (popupPanel.Width - buttonsToShow[0].Width * 2 - 60) / 2;
            int startY = lblStatus.Bottom + 60;
            for (int i = 0; i < buttonsToShow.Count; i++)
            {
                buttonsToShow[i].Location = new Point(startX + (i % 2) * (buttonsToShow[i].Width + 60), startY + (i / 2) * (buttonsToShow[i].Height + 60));
                buttonsToShow[i].Visible = true;
            }
        }
        private void PopupPanel_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(115, Color.White))) 
            {
                e.Graphics.FillRectangle(brush, popupPanel.ClientRectangle);
            }
        }
        private void InitializePopupPanel()
        {
            popupPanel = new Panel
            {
                Width = 636,
                Height = 325,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false,
                //BackColor = Color.White
                BackColor = Color.Transparent
            };

            Label lblStatus = new Label
            {
                Name = "lblStatus",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Font = new Font("Roboto", 20, FontStyle.Regular),
                ForeColor = Color.Black,
                Height = 40
            };

            Button btnSwitch = new Button { Text = "Switch to another table", Width = 250, Height = 60, Visible = false,
                BackColor = Color.Black,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 2 }
            };
            Button btnFree = new Button { Text = "Free table", Width = 250, Height = 60, Visible = false,
                BackColor = Color.Black,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            Button btnTakeOrder = new Button { Text = "Take Order", Width = 250, Height = 60, Visible = false,
                BackColor = Color.Black,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                
            };
            Button btnViewOrder = new Button { Text = "View order", Width = 250, Height = 60, Visible = false,
                BackColor = Color.Black,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            Button btnReserve = new Button { Text = "Reserve", Width = 250, Height = 60, Visible = false,
                BackColor = Color.Black,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            Button btnSeatCustomer = new Button { Text = "Seat customer", Width = 250, Height = 60, Visible = false,BackColor = Color.Black,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            Button btnViewReservationDetails = new Button { Text = "View reservation details", Width = 250, Height = 60, Visible = false ,
                BackColor = Color.Black,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            Button btnCancelReservation = new Button { Text = "Cancel reservation", Width = 250, Height = 60, Visible = false ,
                BackColor = Color.Black,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };


            statusButtons = new Dictionary<TableStatus, List<Button>>
            {
                { TableStatus.free, new List<Button> { btnFree, btnReserve } },
                { TableStatus.occupied, new List<Button> { btnFree, btnTakeOrder, btnViewOrder, btnSwitch } },
                { TableStatus.reserved, new List<Button> { btnFree, btnSeatCustomer, btnViewReservationDetails, btnCancelReservation } }
            };
            popupPanel.Paint += PopupPanel_Paint;

            popupPanel.Controls.Add(lblStatus);
            popupPanel.Controls.Add(btnSwitch);
            popupPanel.Controls.Add(btnFree);
            popupPanel.Controls.Add(btnTakeOrder);
            popupPanel.Controls.Add(btnViewOrder);
            popupPanel.Controls.Add(btnReserve);
            popupPanel.Controls.Add(btnSeatCustomer);
            popupPanel.Controls.Add(btnViewReservationDetails);
            popupPanel.Controls.Add(btnCancelReservation);

            this.Controls.Add(popupPanel);
        }


    }
}
