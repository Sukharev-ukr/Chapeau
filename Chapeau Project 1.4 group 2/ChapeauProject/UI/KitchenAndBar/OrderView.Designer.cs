namespace UI
{
    partial class OrderView
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
            flowLayoutPanelRunning = new FlowLayoutPanel();
            flowLayoutPanelFinished = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            flowLayoutPanelRunning.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { runningToolStripMenuItem, finishedToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // runningToolStripMenuItem
            // 
            runningToolStripMenuItem.Name = "runningToolStripMenuItem";
            runningToolStripMenuItem.Size = new Size(94, 29);
            runningToolStripMenuItem.Text = "Running";
            runningToolStripMenuItem.Click += runningToolStripMenuItem_Click_1;
            // 
            // finishedToolStripMenuItem
            // 
            finishedToolStripMenuItem.Name = "finishedToolStripMenuItem";
            finishedToolStripMenuItem.Size = new Size(93, 29);
            finishedToolStripMenuItem.Text = "Finished";
            finishedToolStripMenuItem.Click += finishedToolStripMenuItem_Click;
            // 
            // flowLayoutPanelRunning
            // 
            flowLayoutPanelRunning.AutoScroll = true;
            flowLayoutPanelRunning.Controls.Add(flowLayoutPanelFinished);
            flowLayoutPanelRunning.Dock = DockStyle.Fill;
            flowLayoutPanelRunning.Location = new Point(0, 33);
            flowLayoutPanelRunning.Name = "flowLayoutPanelRunning";
            flowLayoutPanelRunning.Size = new Size(800, 417);
            flowLayoutPanelRunning.TabIndex = 1;
            // 
            // flowLayoutPanelFinished
            // 
            flowLayoutPanelFinished.AutoScroll = true;
            flowLayoutPanelFinished.Dock = DockStyle.Fill;
            flowLayoutPanelFinished.Location = new Point(3, 3);
            flowLayoutPanelFinished.Name = "flowLayoutPanelFinished";
            flowLayoutPanelFinished.Size = new Size(776, 0);
            flowLayoutPanelFinished.TabIndex = 2;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelRunning);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "OrderView";
            Text = "OrderView";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanelRunning.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem runningToolStripMenuItem;
        private ToolStripMenuItem finishedToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanelRunning;
        private FlowLayoutPanel flowLayoutPanelFinished;
    }
}