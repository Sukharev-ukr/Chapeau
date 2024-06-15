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
                        label.Text = $"🍾 Running ({waitingTimeText})";
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

                SetButtonColor(button, table.Status);

                return button;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating table button: " + ex.Message, "Error");
                return null;
            }
        }

        private void SetButtonColor(Button button, TableStatus status)
        {
            switch (status)
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
        }

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

        private void ShowPopup(Table table)
        {
            try
            {
                SetPopupStatusLabel(table);
                CenterPopupPanel();
                HidePopupButtons();
                ShowRelevantButtons(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while showing the popup: " + ex.Message, "Error");
            }
        }

        private void SetPopupStatusLabel(Table table)
        {
            Label lblStatus = popupPanel.Controls["lblStatus"] as Label;
            lblStatus.Text = $"Table - {table.TableId} ({table.Status})";
        }

        private void CenterPopupPanel()
        {
            popupPanel.Location = new Point(
                this.ClientSize.Width / 2 - popupPanel.Width / 2,   // Horizontal center
                this.ClientSize.Height / 2 - popupPanel.Height / 2  // Vertical center
            );
            popupPanel.Visible = true;
            popupPanel.BringToFront();
        }

        private void HidePopupButtons()
        {
            foreach (Control control in popupPanel.Controls)
            {
                if (control is Button)
                {
                    control.Visible = false;
                }
            }
        }

        private void ShowRelevantButtons(Table table)
        {
            List<Button> buttonsToShow = statusButtons[table.Status];
            int startX = (popupPanel.Width - buttonsToShow[0].Width * 2 - 60) / 2;
            int startY = popupPanel.Controls["lblStatus"].Bottom + 60;

            for (int i = 0; i < buttonsToShow.Count; i++)
            {
                buttonsToShow[i].Location = new Point(
                    startX + (i % 2) * (buttonsToShow[i].Width + 60),
                    startY + (i / 2) * (buttonsToShow[i].Height + 60)
                );

                buttonsToShow[i].Visible = true;
                ConfigurePopupButton(buttonsToShow[i], table);
            }
        }

        private void ConfigurePopupButton(Button button, Table table)
        {
            var orderService = new OrderService();
            var runningOrder = orderService.GetRunningOrder(table.TableId);

            if (button.Text == "Mark as Served")
            {
                ConfigureMarkAsServedButton(button, runningOrder);
            }

            if (button.Text == "Free table")
            {
                ConfigureFreeTableButton(button, runningOrder);
            }
        }

        private void ConfigureMarkAsServedButton(Button button, Order runningOrder)
        {
            if (runningOrder != null && runningOrder.OrderStatus == Status.running)
            {
                button.Enabled = true;
                button.BackColor = Color.Black;
                button.ForeColor = Color.White;
            }
            else
            {
                button.Enabled = false;
                button.BackColor = Color.FromArgb(200, 255, 255, 255);
                button.ForeColor = Color.Black;
            }
        }

        private void ConfigureFreeTableButton(Button button, Order runningOrder)
        {
            if (runningOrder == null || runningOrder.OrderStatus == Status.finished)
            {
                button.Enabled = true;
                button.BackColor = Color.Black;
                button.ForeColor = Color.White;
            }
            else
            {
                button.Enabled = false;
                button.BackColor = Color.FromArgb(200, 255, 255, 255);
                button.ForeColor = Color.Black;
            }
        }

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

                
                Button btnFree = CreatePopupButton("Free table", BtnFree_Click);
                Button btnTakeOrder = CreatePopupButton("Take Order", BtnTakeOrder_Click);
                Button btnReserve = CreatePopupButton("Reserve", BtnReserve_Click);
                Button btnSeatCustomer = CreatePopupButton("Seat customer", BtnSeatCustomer_Click);
                Button btnViewReservationDetails = CreatePopupButton("View reservation details", BtnViewReservationDetails_Click);
                Button btnCancelReservation = CreatePopupButton("Cancel reservation", BtnCancelReservation_Click);
                Button btnMarkAsServed = CreatePopupButton("Mark as Served", BtnMarkAsServed_Click);

                statusButtons = new Dictionary<TableStatus, List<Button>>
                {
                    { TableStatus.free, new List<Button> { btnSeatCustomer, btnReserve } },
                    { TableStatus.occupied, new List<Button> { btnFree, btnTakeOrder, btnMarkAsServed } },
                    { TableStatus.reserved, new List<Button> { btnFree, btnSeatCustomer, btnViewReservationDetails, btnCancelReservation } }
                };

                //popupPanel.Paint += PopupPanel_Paint;
                popupPanel.Controls.Add(lblStatus);
                popupPanel.Controls.Add(btnFree);
                popupPanel.Controls.Add(btnTakeOrder);
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

        private Button CreatePopupButton(string text, EventHandler onClick = null)
        {
            try
            {
                var button = new Button
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

                if (onClick != null)
                {
                    button.Click += onClick;
                }

                return button;
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

        private void UpdateTableButtonColor(Button button, TableStatus status)
        {
            try
            {
                SetButtonColor(button, status);
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

        

        private void BtnTakeOrder_Click(object sender, EventArgs e)
        {
            // Implementation for taking order
        }

        private void BtnViewReservationDetails_Click(object sender, EventArgs e)
        {
            // Implementation for viewing reservation details
        }
    }
}
