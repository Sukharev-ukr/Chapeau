using DAL;
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
using System.Diagnostics;

namespace UI.Login
{
    public partial class TableView_Form : Form
    {
        private System.Windows.Forms.Timer pollingTimer;
        private StaffDAL staff;
        private TableDAL tableDAL; 
        private Panel popupPanel; 
        private Dictionary<TableStatus, List<Button>> statusButtons; 
        private TableService tableService; 
        private Button selectedTableButton;
        private Button closeButton;
        private int selectedTableId;
        private string employeeName;
        private Label employeeNameLabel;

        public TableView_Form(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            tableDAL = new TableDAL();
            tableService = new TableService();
            InitializePopupPanel();
            LoadTables();
            InitializePollingTimer();
            InitializeMainCloseButton();
        }

        private void InitializeMainCloseButton()
        {
            Button mainCloseButton = new Button
            {
                Text = "<",
                Width = 30,
                Height = 30,
                BackColor = Color.Black,
                ForeColor = Color.White,
                Font = new Font("Roboto", 13, FontStyle.Regular),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Location = new Point(20, 16)
            };
            mainCloseButton.Click += MainCloseButton_Click;

            employeeNameLabel = new Label
            {
                Text = employeeName,
                AutoSize = true,
                BackColor = Color.FromArgb(117, 30, 55),
                ForeColor = Color.White,
                Font = new Font("Roboto", 20, FontStyle.Regular), // Increased font size
                Location = new Point(this.ClientSize.Width - 20 - 25 - TextRenderer.MeasureText(employeeName, new Font("Roboto", 16)).Width, 20)
            };
            

            
            this.Controls.Add(mainCloseButton);
            mainCloseButton.BringToFront();
            this.Controls.Add(employeeNameLabel);
            employeeNameLabel.BringToFront();
        }


        /// <summary>
        /// Initializes the polling timer.
        /// </summary>
        private void InitializePollingTimer()
        {
            pollingTimer = new System.Windows.Forms.Timer();
            pollingTimer.Interval = 1000; // Poll every second
            pollingTimer.Tick += PollingTimer_Tick;
            pollingTimer.Start();
        }

        /// <summary>
        /// Handles the polling timer tick event to refresh table statuses.
        /// </summary>
        private void PollingTimer_Tick(object sender, EventArgs e)
        {
            RefreshTableStatuses();
        }

        /// <summary>
        /// Refreshes the table statuses by querying the database and updating the UI.
        /// </summary>
        private void RefreshTableStatuses()
        {
            List<Table> latestTables = tableDAL.GetAllTables();
            foreach (Table table in latestTables)
            {
                //Corresponding button for this table
                foreach (Control control in this.Controls)
                {
                    if (control is Button button && button.Tag is Table buttonTable && buttonTable.TableId == table.TableId)
                    {
                        // Update the table status
                        buttonTable.Status = table.Status;
                        UpdateTableButtonColor(button, table.Status);
                    }
                }
            }
        }

        /// <summary>
        /// Loads the tables and displays them in the form.
        /// </summary>
        private void LoadTables()
        {
            List<Table> tables = tableDAL.GetAllTables();

            // Spacing values
            const int tableWidth = 100;
            const int tableHeight = 100;
            const int verticalSpacing = 80; // Space between tables vertically
            const int horizontalSpacing = 240; // Space between columns

            // Calculate the total height needed for the tables in one column
            int totalTableHeight = (tables.Count / 2) * (tableHeight + verticalSpacing) - verticalSpacing;

            // Calculate the starting Y position to center the tables vertically in the form
            int startY = (this.ClientSize.Height - totalTableHeight) / 2; // Centering vertically

            // X positions for the two columns
            int column1X = 170; // Position for the first row of tables
            int column2X = column1X + tableWidth + horizontalSpacing; // X position for the second column

            // Calculate the midpoint to split tables between the two columns
            int midPoint = tables.Count / 2;

            // Split tables and place them
            SplitTablesInHalf(tables, midPoint, column1X, column2X, startY, tableHeight, verticalSpacing);
        }

        /// <summary>
        /// Splits the tables in half and places them in two columns.
        /// </summary>
        private void SplitTablesInHalf(List<Table> tables, int midPoint, int column1X, int column2X, int startY, int tableHeight, int verticalSpacing)
        {
            int currentY1 = startY;
            int currentY2 = startY;

            // Loop through each table and place it in the correct column and position
            for (int i = 0; i < tables.Count; i++)
            {
                // Create a button for each table
                Button tableButton = CreateTableButton(tables[i]);

                if (i < midPoint)
                {
                    // Place tables in the first column
                    tableButton.Location = new Point(column1X, currentY1);
                    // Update the Y position for the next table
                    currentY1 += tableHeight + verticalSpacing;
                }
                else
                {
                    // Place tables in the second column
                    tableButton.Location = new Point(column2X, currentY2);
                    // Update the Y position for the next table
                    currentY2 += tableHeight + verticalSpacing;
                }

                // Add the table button to the form
                this.Controls.Add(tableButton);
            }
        }

        /// <summary>
        /// Creates a button for a table and sets its properties.
        /// </summary>
        /// <param name="table">The table object.</param>
        /// <returns>A button representing the table.</returns>
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
                    button.BackColor = Color.FromArgb(255, 86, 86);
                    break;
                case TableStatus.Ordered:
                    button.BackColor = Color.FromArgb(255, 255, 86, 86);
                    break;
                default:
                    button.BackColor = Color.Gray;
                    break;
            }

            return button;
        }

        /// <summary>
        /// Handles the table button click event to show the popup.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event data.</param>
        private void TableButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                Table clickedTable = clickedButton.Tag as Table;
                if (clickedTable != null)
                {
                    selectedTableButton = clickedButton; // Store the selected button
                    selectedTableId = clickedTable.TableId;
                    ShowPopup(clickedTable);
                }
            }
        }

        /// <summary>
        /// Shows the popup panel for table actions.
        /// </summary>
        /// <param name="table">The table object.</param>
        private void ShowPopup(Table table)
        {
            Label lblStatus = popupPanel.Controls["lblStatus"] as Label;
            lblStatus.Text = $"Table - {table.TableId} ({table.Status})";

            // Adjust popupPanel location based on where you want to show it
            popupPanel.Location = new Point(this.ClientSize.Width / 2 - popupPanel.Width / 2, this.ClientSize.Height / 2 - popupPanel.Height / 2);
            popupPanel.Visible = true;
            popupPanel.BringToFront();

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

        /// <summary>
        /// Handles the popup panel paint event to set its background.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void PopupPanel_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(115, Color.White))) 
            {
                e.Graphics.FillRectangle(brush, popupPanel.ClientRectangle);
            }
        }
        /// <summary>
        /// Initializes the popup panel and its controls.
        /// </summary>
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

            // Define buttons for the popup panel
            Button btnSwitch = CreatePopupButton("Switch to another table");
            Button btnFree = CreatePopupButton("Free table");
            btnFree.Click += BtnFree_Click;
            Button btnTakeOrder = CreatePopupButton("Take Order");
            Button btnViewOrder = CreatePopupButton("View order");
            Button btnReserve = CreatePopupButton("Reserve");
            btnReserve.Click += BtnReserve_Click;
            Button btnSeatCustomer = CreatePopupButton("Seat customer");
            btnSeatCustomer.Click += BtnSeatCustomer_Click;
            Button btnViewReservationDetails = CreatePopupButton("View reservation details");
            Button btnCancelReservation = CreatePopupButton("Cancel reservation");
            btnCancelReservation.Click += BtnCancelReservation_Click;
            // Initialize status buttons dictionary
            statusButtons = new Dictionary<TableStatus, List<Button>>
            {
                { TableStatus.free, new List<Button> { btnSeatCustomer, btnReserve } },
                { TableStatus.occupied, new List<Button> { btnFree, btnTakeOrder, btnViewOrder, btnSwitch } },
                { TableStatus.reserved, new List<Button> { btnFree, btnSeatCustomer, btnViewReservationDetails, btnCancelReservation } }
            };
            popupPanel.Paint += PopupPanel_Paint;

            // Add controls to the popup panel
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

        /// <summary>
        /// Creates a button for the popup panel.
        /// </summary>
        /// <param name="text">The text to display on the button.</param>
        /// <returns>A button with the specified text.</returns>
        private Button CreatePopupButton(string text)
        {
            return new Button
            {
                Text = text,
                Width = 250,
                Height = 60,
                Visible = false,
                BackColor = Color.Black,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
        }

        /// <summary>
        /// Handles the "Free Table" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnFree_Click(object sender, EventArgs e)
        {
            UpdateTableStatusAndColor(TableStatus.free);
        }

        /// <summary>
        /// Handles the "Reserve Table" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnReserve_Click(object sender, EventArgs e)
        {
            UpdateTableStatusAndColor(TableStatus.reserved);
        }

        /// <summary>
        /// Handles the "Seat Customer" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnSeatCustomer_Click(object sender, EventArgs e)
        {
            UpdateTableStatusAndColor(TableStatus.occupied);
        }

        /// <summary>
        /// Handles the "Cancel Reservation" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnCancelReservation_Click(object sender, EventArgs e)
        {
            UpdateTableStatusAndColor(TableStatus.free);
        }

        /// <summary>
        /// Updates the table status in the database and changes the button color.
        /// </summary>
        /// <param name="status">The new status of the table.</param>
        private void UpdateTableStatusAndColor(TableStatus status)
        {
            tableService.UpdateTableStatus(selectedTableId, status);
            UpdateTableButtonColor(selectedTableButton, status);
            ClosePopup();
        }

        /// <summary>
        /// Updates the color of the table button based on its status.
        /// </summary>
        /// <param name="button">The table button to update.</param>
        /// <param name="status">The new status of the table.</param>
        private void UpdateTableButtonColor(Button button, TableStatus status)
        {
            switch (status)
            {
                case TableStatus.free:
                    button.BackColor = Color.FromArgb(255, 108, 255, 84);
                    break;
                case TableStatus.occupied:
                    button.BackColor = Color.FromArgb(255, 255, 86, 86); 
                    break;
                case TableStatus.reserved:
                    button.BackColor = Color.FromArgb(255, 254, 231, 44);
                    break;
                default:
                    button.BackColor = Color.Gray;
                    break;
            }
        }

        private void MainCloseButton_Click(object sender, EventArgs e)
        {
            ClosePopup();
        }

        // <summary>
        /// Closes the popup panel.
        /// </summary>
        private void ClosePopup()
        {
            this.popupPanel.Visible = false;
        }
        

    }
}
