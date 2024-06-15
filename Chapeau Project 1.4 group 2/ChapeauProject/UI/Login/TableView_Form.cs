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
                Font = new Font("Roboto", 20, FontStyle.Regular),
                Location = new Point(this.ClientSize.Width - 20 - 100 - TextRenderer.MeasureText(employeeName, new Font("Roboto", 16)).Width, 20)
            };

            Button logoutButton = new Button
            {
                Text = "Logout",
                Width = 70,
                Height = 30,
                BackColor = Color.Black,
                ForeColor = Color.White,
                Font = new Font("Roboto", 12, FontStyle.Regular),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Location = new Point(this.ClientSize.Width - 90, 20)
            };
            logoutButton.Click += LogoutButton_Click;

            this.Controls.Add(mainCloseButton);
            mainCloseButton.BringToFront();
            this.Controls.Add(employeeNameLabel);
            employeeNameLabel.BringToFront();
            this.Controls.Add(logoutButton);
            logoutButton.BringToFront();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                var message = MessageBox.Show("Are you sure you would like to logout?", "Confirmation", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    this.Hide();
                    LoginForm loginForm = new LoginForm(); // Create a new login form
                    loginForm.ShowDialog(); // Display the login form
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during logout: " + ex.Message, "Error");
            }
        }



        /// <summary>
        /// Initializes the polling timer.
        /// </summary>
        private void InitializePollingTimer()
        {
            try
            {
                pollingTimer = new System.Windows.Forms.Timer();
                pollingTimer.Interval = 5000; // Poll every second
                pollingTimer.Tick += PollingTimer_Tick;
                pollingTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while initializing the polling timer: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Handles the polling timer tick event to refresh table statuses.
        /// </summary>
        private void PollingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                RefreshTableStatuses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during polling: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Refreshes the table statuses by querying the database and updating the UI.
        /// </summary>
        /// <summary>
        /// Refreshes the table statuses by querying the database and updating the UI.
        /// </summary>
        private void RefreshTableStatuses()
        {
            try
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

                            // Update the order status label
                            UpdateOrderStatusLabelForTable(button);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing table statuses: " + ex.Message, "Error");
            }
        }

        private void LoadTables()
        {
            try
            {
                List<Table> tables = tableDAL.GetAllTables();

                const int tableWidth = 100;
                const int tableHeight = 100;
                const int verticalSpacing = 80;
                const int horizontalSpacing = 240;
                int totalTableHeight = (tables.Count / 2) * (tableHeight + verticalSpacing) - verticalSpacing;
                int startY = (this.ClientSize.Height - totalTableHeight) / 2;
                int column1X = 170;
                int column2X = column1X + tableWidth + horizontalSpacing;
                int midPoint = tables.Count / 2;

                SplitTablesInHalf(tables, midPoint, column1X, column2X, startY, tableHeight, verticalSpacing);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading tables: " + ex.Message, "Error");
            }
        }

        private void SplitTablesInHalf(List<Table> tables, int midPoint, int column1X, int column2X, int startY, int tableHeight, int verticalSpacing)
        {
            try
            {
                int currentY1 = startY;
                int currentY2 = startY;

                for (int i = 0; i < tables.Count; i++)
                {
                    Button tableButton = CreateTableButton(tables[i]);
                    Label orderStatusLabel = new Label
                    {
                        AutoSize = true,
                        Font = new Font("Roboto", 14, FontStyle.Regular),
                        ForeColor = Color.Black,
                        Tag = tables[i]
                    };

                    if (i < midPoint)
                    {
                        tableButton.Location = new Point(column1X, currentY1);
                        orderStatusLabel.Location = new Point(column1X, currentY1 + tableHeight + 5);
                        currentY1 += tableHeight + verticalSpacing;
                    }
                    else
                    {
                        tableButton.Location = new Point(column2X, currentY2);
                        orderStatusLabel.Location = new Point(column2X, currentY2 + tableHeight + 5);
                        currentY2 += tableHeight + verticalSpacing;
                    }

                    this.Controls.Add(tableButton);
                    this.Controls.Add(orderStatusLabel);

                    UpdateOrderStatusLabel(orderStatusLabel, tables[i].TableId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while splitting tables: " + ex.Message, "Error");
            }
        }


        private void UpdateOrderStatusLabel(Label label, int tableId)
        {
            try
            {
                var orderService = new OrderService();
                var runningOrder = orderService.GetRunningOrder(tableId);
                if (runningOrder != null)
                {
                    var waitingTime = DateTime.Now - runningOrder.OrderTime.Value;
                    string waitingTimeText = $"{waitingTime.Hours:D2}:{waitingTime.Minutes:D2}:{waitingTime.Seconds:D2}";

                    if (runningOrder.Items.Any(item => item.MenuItem.Category == Category.Drinks))
                    {
                        label.Text = $"🍾🍽️ Running ({waitingTimeText})";
                    }
                    else
                    {
                        label.Text = $"🍽️ Running ({waitingTimeText})";
                    }
                }
                else
                {
                    label.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating order status label: " + ex.Message, "Error");
            }
        }

        private void UpdateOrderStatusLabelForTable(Button tableButton)
        {
            try
            {
                var table = tableButton.Tag as Table;
                if (table != null)
                {
                    foreach (Control control in this.Controls)
                    {
                        if (control is Label label && label.Tag is Table labelTable && labelTable.TableId == table.TableId)
                        {
                            UpdateOrderStatusLabel(label, table.TableId);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating order status label for table: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Creates a button for a table and sets its properties.
        /// </summary>
        /// <param name="table">The table object.</param>
        /// <returns>A button representing the table.</returns>
        private Button CreateTableButton(Table table)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating table button: " + ex.Message, "Error");
                return null;
            }
        }

        /// <summary>
        /// Handles the table button click event to show the popup.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">The event data.</param>
        private void TableButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while handling table button click: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Shows the popup panel for table actions.
        /// </summary>
        /// <param name="table">The table object.</param>
        private void ShowPopup(Table table)
        {
            try
            {
                // Set the label text to display the table ID and status
                Label lblStatus = popupPanel.Controls["lblStatus"] as Label;
                lblStatus.Text = $"Table - {table.TableId} ({table.Status})";

                // Center the popup panel in the form
                popupPanel.Location = new Point(
                    this.ClientSize.Width / 2 - popupPanel.Width / 2,   // Horizontal center
                    this.ClientSize.Height / 2 - popupPanel.Height / 2  // Vertical center
                );

                // Make the popup panel visible and bring it to the front
                popupPanel.Visible = true;
                popupPanel.BringToFront();

                // Hide all buttons initially
                foreach (Control control in popupPanel.Controls)
                {
                    if (control is Button)
                    {
                        control.Visible = false;
                    }
                }

                // Get the list of buttons to show based on the table status
                List<Button> buttonsToShow = statusButtons[table.Status];

                // Calculate the starting X position to center two columns of buttons horizontally within the popup panel
                int startX = (popupPanel.Width - buttonsToShow[0].Width * 2 - 60) / 2;
                // Calculate the starting Y position with a 60-pixel gap below the bottom of the lblStatus label
                int startY = lblStatus.Bottom + 60;

                // Iterate through the buttons to show
                for (int i = 0; i < buttonsToShow.Count; i++)
                {
                    // Calculate and set the button location
                    buttonsToShow[i].Location = new Point(
                        startX + (i % 2) * (buttonsToShow[i].Width + 60),  // X position: alternate between two columns
                        startY + (i / 2) * (buttonsToShow[i].Height + 60)  // Y position: stack buttons vertically
                    );

                    // Make the button visible
                    buttonsToShow[i].Visible = true;

                    // Retrieve the running order for the table
                    var orderService = new OrderService();
                    var runningOrder = orderService.GetRunningOrder(table.TableId);

                    // Adjust the appearance and enabled state of the "Mark as Served" button
                    if (buttonsToShow[i].Text == "Mark as Served")
                    {
                        if (runningOrder != null && runningOrder.OrderStatus == Status.running)
                        {
                            buttonsToShow[i].Enabled = true;
                            buttonsToShow[i].BackColor = Color.Black;
                            buttonsToShow[i].ForeColor = Color.White;
                        }
                        else
                        {
                            buttonsToShow[i].Enabled = false;
                            buttonsToShow[i].BackColor = Color.FromArgb(200, 255, 255, 255); // Slightly white background
                            buttonsToShow[i].ForeColor = Color.Black; // Text color
                        }
                    }

                    // Adjust the appearance and enabled state of the "Free table" button
                    if (buttonsToShow[i].Text == "Free table")
                    {
                        if (runningOrder == null || runningOrder.OrderStatus == Status.finished)
                        {
                            buttonsToShow[i].Enabled = true;
                            buttonsToShow[i].BackColor = Color.Black;
                            buttonsToShow[i].ForeColor = Color.White;
                        }
                        else
                        {
                            buttonsToShow[i].Enabled = false;
                            buttonsToShow[i].BackColor = Color.FromArgb(200, 255, 255, 255); // Slightly white background
                            buttonsToShow[i].ForeColor = Color.Black; // Text color
                        }
                    }
                }
                if (buttonsToShow[i].Text == "Pay the Bill")
                {
                    if (runningOrder == null || runningOrder.OrderStatus == Status.running)
                    {
                        buttonsToShow[i].Enabled = false;
                        buttonsToShow[i].BackColor = Color.FromArgb(200, 255, 255, 255); // Slightly white background
                        buttonsToShow[i].ForeColor = Color.Black; // Text color
                    }
                    else
                    {
                        buttonsToShow[i].Enabled = true;
                        buttonsToShow[i].BackColor = Color.Black;
                        buttonsToShow[i].ForeColor = Color.White;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while showing the popup: " + ex.Message, "Error");
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
            try
            {
                popupPanel = new Panel
                {
                    Width = 636,
                    Height = 325,
                    BorderStyle = BorderStyle.FixedSingle,
                    Visible = false,
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

                Button btnSwitch = CreatePopupButton("Switch to another table");
                Button btnFree = CreatePopupButton("Free table");
                btnFree.Click += BtnFree_Click;
                Button btnTakeOrder = CreatePopupButton("Take Order");
                Button btnPayBill = CreatePopupButton("Pay the Bill");
                btnPayBill.Click += BtnPayBill_Click;
                Button btnReserve = CreatePopupButton("Reserve");
                btnReserve.Click += BtnReserve_Click;
                Button btnSeatCustomer = CreatePopupButton("Seat customer");
                btnSeatCustomer.Click += BtnSeatCustomer_Click;
                Button btnViewReservationDetails = CreatePopupButton("View reservation details");
                Button btnCancelReservation = CreatePopupButton("Cancel reservation");
                btnCancelReservation.Click += BtnCancelReservation_Click;
                Button btnMarkAsServed = CreatePopupButton("Mark as Served");
                btnMarkAsServed.Click += BtnMarkAsServed_Click;

                statusButtons = new Dictionary<TableStatus, List<Button>>
                {
                    { TableStatus.free, new List<Button> { btnSeatCustomer, btnReserve } },
                    { TableStatus.occupied, new List<Button> { btnFree, btnTakeOrder, btnPayBill, btnSwitch } },
                    { TableStatus.reserved, new List<Button> { btnFree, btnSeatCustomer, btnViewReservationDetails, btnCancelReservation } }
                };

                popupPanel.Paint += PopupPanel_Paint;
                popupPanel.Controls.Add(lblStatus);
                popupPanel.Controls.Add(btnSwitch);
                popupPanel.Controls.Add(btnFree);
                popupPanel.Controls.Add(btnTakeOrder);
                popupPanel.Controls.Add(btnPayBill);
                popupPanel.Controls.Add(btnReserve);
                popupPanel.Controls.Add(btnSeatCustomer);
                popupPanel.Controls.Add(btnViewReservationDetails);
                popupPanel.Controls.Add(btnCancelReservation);
                popupPanel.Controls.Add(btnMarkAsServed);

                this.Controls.Add(popupPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while initializing the popup panel: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Creates a button for the popup panel.
        /// </summary>
        /// <param name="text">The text to display on the button.</param>
        /// <returns>A button with the specified text.</returns>
        private Button CreatePopupButton(string text)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating popup button: " + ex.Message, "Error");
                return null;
            }
        }

        private void BtnMarkAsServed_Click(object sender, EventArgs e)
        {
            try
            {
                var orderService = new OrderService();
                var runningOrder = orderService.GetRunningOrder(selectedTableId);

                if (runningOrder != null)
                {
                    orderService.MarkOrderAsServed(runningOrder.OrderId);
                    RefreshTableStatuses();
                    UpdateOrderStatusLabelForTable(selectedTableButton);
                }
                else
                {
                    var button = sender as Button;
                    if (button != null)
                    {
                        button.Enabled = false;
                        //button.BackColor = Color.FromArgb(150, 255, 255, 255); change colours, too bright
                    }
                }
                ClosePopup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while marking the order as served: " + ex.Message, "Error");
            }
        }

        private void BtnFree_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTableStatusAndColor(TableStatus.free);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while freeing the table: " + ex.Message, "Error");
            }
        }



        //<summary>
        //Handles the "Pay the Bill" button click event
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnPayBill_Click(object sender, EventArgs e)
        {
            try
            {
                // moves on to the PaymentSystem.BillDetails form
                OrderService order = new OrderService();
                BillDetails billDetails = new BillDetails(order.GetRunningOrderFromTable(selectedTableId).OrderId);
                Program.WindowSwitcher(this, billDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while handling the payment: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Handles the "Reserve Table" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTableStatusAndColor(TableStatus.reserved);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reserving the table: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Handles the "Seat Customer" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnSeatCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTableStatusAndColor(TableStatus.occupied);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while seating the customer: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Handles the "Cancel Reservation" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void BtnCancelReservation_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateTableStatusAndColor(TableStatus.free);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while canceling the reservation: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Updates the table status in the database and changes the button color.
        /// </summary>
        /// <param name="status">The new status of the table.</param>
        private void UpdateTableStatusAndColor(TableStatus status)
        {
            try
            {
                tableService.UpdateTableStatus(selectedTableId, status);
                UpdateTableButtonColor(selectedTableButton, status);
                ClosePopup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the table status: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Updates the color of the table button based on its status.
        /// </summary>
        /// <param name="button">The table button to update.</param>
        /// <param name="status">The new status of the table.</param>
        private void UpdateTableButtonColor(Button button, TableStatus status)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the table button color: " + ex.Message, "Error");
            }
        }

        private void MainCloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClosePopup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while closing the popup: " + ex.Message, "Error");
            }
        }

        // <summary>
        /// Closes the popup panel.
        /// </summary>
        private void ClosePopup()
        {
            try
            {
                this.popupPanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while hiding the popup panel: " + ex.Message, "Error");
            }
        }


    }
}