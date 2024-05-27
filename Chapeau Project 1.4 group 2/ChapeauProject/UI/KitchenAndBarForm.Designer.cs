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
            pnlFinishedOrders = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { runningToolStripMenuItem, finishedToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1328, 33);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // runningToolStripMenuItem
            // 
            runningToolStripMenuItem.Name = "runningToolStripMenuItem";
            runningToolStripMenuItem.Size = new Size(94, 29);
            runningToolStripMenuItem.Text = "Running";
            // 
            // finishedToolStripMenuItem
            // 
            finishedToolStripMenuItem.Name = "finishedToolStripMenuItem";
            finishedToolStripMenuItem.Size = new Size(93, 29);
            finishedToolStripMenuItem.Text = "Finished";
            // 
            // pnlRunningOrders
            // 
            pnlRunningOrders.Location = new Point(29, 57);
            pnlRunningOrders.Name = "pnlRunningOrders";
            pnlRunningOrders.Size = new Size(1077, 397);
            pnlRunningOrders.TabIndex = 8;
            // 
            // pnlFinishedOrders
            // 
            pnlFinishedOrders.Location = new Point(29, 57);
            pnlFinishedOrders.Name = "pnlFinishedOrders";
            pnlFinishedOrders.Size = new Size(1077, 397);
            pnlFinishedOrders.TabIndex = 0;
            // 
            // KitchenAndBarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 532);
            Controls.Add(pnlFinishedOrders);
            Controls.Add(pnlRunningOrders);
            Controls.Add(menuStrip1);
            Name = "KitchenAndBarForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem runningToolStripMenuItem;
        private ToolStripMenuItem finishedToolStripMenuItem;
        private Panel pnlRunningOrders;
        private Panel pnlFinishedOrders;
    }
}