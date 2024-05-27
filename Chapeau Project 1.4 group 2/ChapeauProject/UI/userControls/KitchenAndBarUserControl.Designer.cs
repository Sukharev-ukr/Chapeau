namespace UI
{
    partial class KitchenAndBarUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            listViewStarter = new ListView();
            listViewMain = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listViewDesert = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listViewDrinks = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            listViewStarters = new ListView();
            SuspendLayout();
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "";
            columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 312;
            // 
            // listViewStarter
            // 
            listViewStarter.BackColor = Color.White;
            listViewStarter.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            listViewStarter.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listViewStarter.FullRowSelect = true;
            listViewStarter.Location = new Point(17, 127);
            listViewStarter.Name = "listViewStarter";
            listViewStarter.Size = new Size(260, 291);
            listViewStarter.TabIndex = 7;
            listViewStarter.UseCompatibleStateImageBehavior = false;
            listViewStarter.View = System.Windows.Forms.View.Details;
            // 
            // listViewMain
            // 
            listViewMain.BackColor = Color.White;
            listViewMain.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewMain.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listViewMain.FullRowSelect = true;
            listViewMain.Location = new Point(303, 127);
            listViewMain.Name = "listViewMain";
            listViewMain.Size = new Size(261, 291);
            listViewMain.TabIndex = 8;
            listViewMain.UseCompatibleStateImageBehavior = false;
            listViewMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 312;
            // 
            // listViewDesert
            // 
            listViewDesert.BackColor = Color.White;
            listViewDesert.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader6 });
            listViewDesert.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listViewDesert.FullRowSelect = true;
            listViewDesert.Location = new Point(599, 127);
            listViewDesert.Name = "listViewDesert";
            listViewDesert.Size = new Size(252, 291);
            listViewDesert.TabIndex = 9;
            listViewDesert.UseCompatibleStateImageBehavior = false;
            listViewDesert.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "";
            columnHeader3.Width = 0;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 312;
            // 
            // listViewDrinks
            // 
            listViewDrinks.BackColor = Color.White;
            listViewDrinks.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8 });
            listViewDrinks.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listViewDrinks.FullRowSelect = true;
            listViewDrinks.Location = new Point(881, 127);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new Size(252, 291);
            listViewDrinks.TabIndex = 10;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "";
            columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 312;
            // 
            // listViewStarters
            // 
            listViewStarters.Location = new Point(71, 73);
            listViewStarters.Name = "listViewStarters";
            listViewStarters.Size = new Size(201, 208);
            listViewStarters.TabIndex = 0;
            listViewStarters.UseCompatibleStateImageBehavior = false;
            listViewStarters.View = System.Windows.Forms.View.Details;
            // 
            // KitchenAndBarUserControl
            // 
            Controls.Add(listViewStarters);
            Name = "KitchenAndBarUserControl";
            Size = new Size(1063, 541);
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView listViewStarter;
        private ListView listViewMain;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listViewDesert;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ListView listViewDrinks;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView listViewStarters;
    }
}
