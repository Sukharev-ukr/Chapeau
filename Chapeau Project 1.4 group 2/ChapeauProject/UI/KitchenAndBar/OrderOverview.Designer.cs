using System.Drawing.Printing;

namespace UI
{
    partial class OrderOverview
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            lblTime = new ToolStripMenuItem();
            lblEmployee = new ToolStripMenuItem();
            flowLayoutPanelRunning = new FlowLayoutPanel();
            flowLayoutPanelFinished = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            flowLayoutPanelRunning.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(117, 30, 55);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { runningToolStripMenuItem, finishedToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, lblTime, lblEmployee });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 39);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // runningToolStripMenuItem
            // 
            runningToolStripMenuItem.ForeColor = SystemColors.Control;
            runningToolStripMenuItem.Name = "runningToolStripMenuItem";
            runningToolStripMenuItem.Size = new Size(94, 35);
            runningToolStripMenuItem.Text = "Running";
            runningToolStripMenuItem.Click += runningToolStripMenuItem_Click_1;
            // 
            // finishedToolStripMenuItem
            // 
            finishedToolStripMenuItem.ForeColor = Color.White;
            finishedToolStripMenuItem.Name = "finishedToolStripMenuItem";
            finishedToolStripMenuItem.Size = new Size(93, 35);
            finishedToolStripMenuItem.Text = "Finished";
            finishedToolStripMenuItem.Click += finishedToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(16, 35);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(123, 35);
            toolStripMenuItem2.Text = "                   ";
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = SystemColors.Control;
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(16, 35);
            // 
            // lblEmployee
            // 
            lblEmployee.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployee.ForeColor = SystemColors.Control;
            lblEmployee.Margin = new Padding(160, 5, 5, 5);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(198, 25);
            lblEmployee.Text = "                                           ";
            // 
            // flowLayoutPanelRunning
            // 
            flowLayoutPanelRunning.AutoScroll = true;
            flowLayoutPanelRunning.BackColor = Color.FromArgb(255, 223, 223);
            flowLayoutPanelRunning.Controls.Add(flowLayoutPanelFinished);
            flowLayoutPanelRunning.Dock = DockStyle.Fill;
            flowLayoutPanelRunning.Location = new Point(0, 0);
            flowLayoutPanelRunning.Name = "flowLayoutPanelRunning";
            flowLayoutPanelRunning.Size = new Size(800, 450);
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
            // OrderOverview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(flowLayoutPanelRunning);
            MainMenuStrip = menuStrip1;
            Name = "OrderOverview";
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem lblTime;
        private ToolStripMenuItem lblEmployee;
    }
}