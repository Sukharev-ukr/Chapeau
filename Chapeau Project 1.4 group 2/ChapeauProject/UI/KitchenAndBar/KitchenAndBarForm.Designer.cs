namespace UI
{
    partial class KitchenAndBarForm
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
            menuStrip1 = new MenuStrip();
            runningToolStripMenuItem = new ToolStripMenuItem();
            finishedToolStripMenuItem = new ToolStripMenuItem();
            pnlRunningOrders = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblEmployee = new Label();
            pnlFinishedOrders = new Panel();
            menuStrip1.SuspendLayout();
            pnlRunningOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(117, 30, 55);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { runningToolStripMenuItem, finishedToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1328, 40);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // runningToolStripMenuItem
            // 
            runningToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            runningToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            runningToolStripMenuItem.Name = "runningToolStripMenuItem";
            runningToolStripMenuItem.Size = new Size(128, 36);
            runningToolStripMenuItem.Text = "Running";
            // 
            // finishedToolStripMenuItem
            // 
            finishedToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            finishedToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            finishedToolStripMenuItem.Name = "finishedToolStripMenuItem";
            finishedToolStripMenuItem.Size = new Size(124, 36);
            finishedToolStripMenuItem.Text = "Finished";
            // 
            // pnlRunningOrders
            // 
            pnlRunningOrders.Controls.Add(label1);
            pnlRunningOrders.Location = new Point(5, 80);
            pnlRunningOrders.Name = "pnlRunningOrders";
            pnlRunningOrders.Size = new Size(1284, 440);
            pnlRunningOrders.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 192);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(117, 30, 55);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1328, 72);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.BackColor = Color.FromArgb(117, 30, 55);
            lblEmployee.ForeColor = SystemColors.ButtonHighlight;
            lblEmployee.Location = new Point(1222, 33);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(59, 25);
            lblEmployee.TabIndex = 10;
            lblEmployee.Text = "label2";
            // 
            // pnlFinishedOrders
            // 
            pnlFinishedOrders.Location = new Point(5, 80);
            pnlFinishedOrders.Name = "pnlFinishedOrders";
            pnlFinishedOrders.Size = new Size(1284, 440);
            pnlFinishedOrders.TabIndex = 9;
            // 
            // KitchenAndBarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(1328, 532);
            Controls.Add(lblEmployee);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(pnlRunningOrders);
            Controls.Add(pnlFinishedOrders);
            Name = "KitchenAndBarForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlRunningOrders.ResumeLayout(false);
            pnlRunningOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem runningToolStripMenuItem;
        private ToolStripMenuItem finishedToolStripMenuItem;
        private Panel pnlRunningOrders;
        private PictureBox pictureBox1;
        private Label lblEmployee;
        private Panel pnlFinishedOrders;
        private Label label1;
    }
}