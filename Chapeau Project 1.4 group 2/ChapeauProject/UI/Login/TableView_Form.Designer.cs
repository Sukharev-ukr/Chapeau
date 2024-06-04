namespace UI.Login
{
    partial class TableView_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Top_TV_panel = new Panel();
            Bottom_TV_panel = new Panel();
            panel1 = new Panel();
            Nav_barOccupied = new Label();
            Nav_barReserved = new Label();
            Nav_barFree = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Top_TV_panel
            // 
            Top_TV_panel.BackColor = Color.FromArgb(117, 30, 55);
            Top_TV_panel.Location = new Point(0, 0);
            Top_TV_panel.Margin = new Padding(2, 3, 2, 3);
            Top_TV_panel.Name = "Top_TV_panel";
            Top_TV_panel.Size = new Size(819, 65);
            Top_TV_panel.TabIndex = 1;
            // 
            // Bottom_TV_panel
            // 
            Bottom_TV_panel.BackColor = Color.FromArgb(117, 30, 55);
            Bottom_TV_panel.Location = new Point(0, 1091);
            Bottom_TV_panel.Margin = new Padding(2, 3, 2, 3);
            Bottom_TV_panel.Name = "Bottom_TV_panel";
            Bottom_TV_panel.Size = new Size(819, 65);
            Bottom_TV_panel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(122, 0, 0, 0);
            panel1.Controls.Add(Nav_barOccupied);
            panel1.Controls.Add(Nav_barReserved);
            panel1.Controls.Add(Nav_barFree);
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 45);
            panel1.TabIndex = 2;
            // 
            // Nav_barOccupied
            // 
            Nav_barOccupied.AutoSize = true;
            Nav_barOccupied.BackColor = Color.Transparent;
            Nav_barOccupied.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Nav_barOccupied.ForeColor = Color.Black;
            Nav_barOccupied.Location = new Point(676, 3);
            Nav_barOccupied.Name = "Nav_barOccupied";
            Nav_barOccupied.Size = new Size(129, 37);
            Nav_barOccupied.TabIndex = 2;
            Nav_barOccupied.Text = "Occupied";
            // 
            // Nav_barReserved
            // 
            Nav_barReserved.AutoSize = true;
            Nav_barReserved.BackColor = Color.Transparent;
            Nav_barReserved.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Nav_barReserved.ForeColor = Color.Black;
            Nav_barReserved.Location = new Point(366, 3);
            Nav_barReserved.Name = "Nav_barReserved";
            Nav_barReserved.Size = new Size(123, 37);
            Nav_barReserved.TabIndex = 1;
            Nav_barReserved.Text = "Reserved";
            // 
            // Nav_barFree
            // 
            Nav_barFree.AutoSize = true;
            Nav_barFree.BackColor = Color.Transparent;
            Nav_barFree.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Nav_barFree.ForeColor = Color.Black;
            Nav_barFree.Location = new Point(42, 3);
            Nav_barFree.Name = "Nav_barFree";
            Nav_barFree.Size = new Size(67, 37);
            Nav_barFree.TabIndex = 0;
            Nav_barFree.Text = "Free";
            // 
            // TableView_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(817, 1155);
            Controls.Add(panel1);
            Controls.Add(Bottom_TV_panel);
            Controls.Add(Top_TV_panel);
            Name = "TableView_Form";
            Text = "TableView_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Top_TV_panel;
        private Panel Bottom_TV_panel;
        private Panel panel1;
        private Label Nav_barReserved;
        private Label Nav_barFree;
        private Label Nav_barOccupied;
    }
}