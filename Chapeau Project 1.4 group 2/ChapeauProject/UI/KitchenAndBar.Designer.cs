namespace View
{
    partial class KitchenAndBar
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
            pnlFinishedOrders = new Panel();
            listViewKitchenOrder2 = new ListView();
            listViewKitchenOrder1 = new ListView();
            menuStrip1 = new MenuStrip();
            runningToolStripMenuItem = new ToolStripMenuItem();
            finishedToolStripMenuItem = new ToolStripMenuItem();
            pnlRunningOrders = new Panel();
            groupBoxMain1 = new GroupBox();
            label2 = new Label();
            btnMain1 = new Button();
            groupBoxDesert1 = new GroupBox();
            label3 = new Label();
            btnDesert1 = new Button();
            groupBoxStarter1 = new GroupBox();
            label1 = new Label();
            btnStarter1 = new Button();
            listViewOrder1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            pnlFinishedOrders.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlRunningOrders.SuspendLayout();
            groupBoxMain1.SuspendLayout();
            groupBoxDesert1.SuspendLayout();
            groupBoxStarter1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFinishedOrders
            // 
            pnlFinishedOrders.Controls.Add(listViewKitchenOrder2);
            pnlFinishedOrders.Controls.Add(listViewKitchenOrder1);
            pnlFinishedOrders.Location = new Point(12, 36);
            pnlFinishedOrders.Name = "pnlFinishedOrders";
            pnlFinishedOrders.Size = new Size(954, 442);
            pnlFinishedOrders.TabIndex = 4;
            // 
            // listViewKitchenOrder2
            // 
            listViewKitchenOrder2.Location = new Point(536, 38);
            listViewKitchenOrder2.Name = "listViewKitchenOrder2";
            listViewKitchenOrder2.Size = new Size(316, 356);
            listViewKitchenOrder2.TabIndex = 1;
            listViewKitchenOrder2.UseCompatibleStateImageBehavior = false;
            // 
            // listViewKitchenOrder1
            // 
            listViewKitchenOrder1.Location = new Point(76, 38);
            listViewKitchenOrder1.Name = "listViewKitchenOrder1";
            listViewKitchenOrder1.Size = new Size(316, 356);
            listViewKitchenOrder1.TabIndex = 0;
            listViewKitchenOrder1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { runningToolStripMenuItem, finishedToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(987, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // runningToolStripMenuItem
            // 
            runningToolStripMenuItem.Name = "runningToolStripMenuItem";
            runningToolStripMenuItem.Size = new Size(94, 29);
            runningToolStripMenuItem.Text = "Running";
            runningToolStripMenuItem.Click += runningToolStripMenuItem_Click;
            // 
            // finishedToolStripMenuItem
            // 
            finishedToolStripMenuItem.Name = "finishedToolStripMenuItem";
            finishedToolStripMenuItem.Size = new Size(93, 29);
            finishedToolStripMenuItem.Text = "Finished";
            finishedToolStripMenuItem.Click += finishedToolStripMenuItem_Click;
            // 
            // pnlRunningOrders
            // 
            pnlRunningOrders.Controls.Add(groupBoxMain1);
            pnlRunningOrders.Controls.Add(groupBoxDesert1);
            pnlRunningOrders.Controls.Add(groupBoxStarter1);
            pnlRunningOrders.Controls.Add(listViewOrder1);
            pnlRunningOrders.Location = new Point(12, 36);
            pnlRunningOrders.Name = "pnlRunningOrders";
            pnlRunningOrders.Size = new Size(954, 442);
            pnlRunningOrders.TabIndex = 5;
            // 
            // groupBoxMain1
            // 
            groupBoxMain1.BackColor = Color.White;
            groupBoxMain1.Controls.Add(label2);
            groupBoxMain1.Controls.Add(btnMain1);
            groupBoxMain1.Location = new Point(81, 208);
            groupBoxMain1.Name = "groupBoxMain1";
            groupBoxMain1.Size = new Size(307, 101);
            groupBoxMain1.TabIndex = 15;
            groupBoxMain1.TabStop = false;
            groupBoxMain1.Text = "Mains";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // btnMain1
            // 
            btnMain1.Location = new Point(189, 37);
            btnMain1.Name = "btnMain1";
            btnMain1.Size = new Size(112, 34);
            btnMain1.TabIndex = 13;
            btnMain1.Text = "Ready";
            btnMain1.UseVisualStyleBackColor = true;
            btnMain1.Click += btnMain1_Click;
            // 
            // groupBoxDesert1
            // 
            groupBoxDesert1.BackColor = Color.White;
            groupBoxDesert1.Controls.Add(label3);
            groupBoxDesert1.Controls.Add(btnDesert1);
            groupBoxDesert1.Location = new Point(79, 315);
            groupBoxDesert1.Name = "groupBoxDesert1";
            groupBoxDesert1.Size = new Size(307, 100);
            groupBoxDesert1.TabIndex = 15;
            groupBoxDesert1.TabStop = false;
            groupBoxDesert1.Text = "Deserts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 46);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // btnDesert1
            // 
            btnDesert1.Location = new Point(191, 37);
            btnDesert1.Name = "btnDesert1";
            btnDesert1.Size = new Size(112, 34);
            btnDesert1.TabIndex = 12;
            btnDesert1.Text = "Ready";
            btnDesert1.UseVisualStyleBackColor = true;
            btnDesert1.Click += btnDesert1_Click;
            // 
            // groupBoxStarter1
            // 
            groupBoxStarter1.BackColor = Color.White;
            groupBoxStarter1.Controls.Add(label1);
            groupBoxStarter1.Controls.Add(btnStarter1);
            groupBoxStarter1.Location = new Point(81, 104);
            groupBoxStarter1.Name = "groupBoxStarter1";
            groupBoxStarter1.Size = new Size(307, 98);
            groupBoxStarter1.TabIndex = 14;
            groupBoxStarter1.TabStop = false;
            groupBoxStarter1.Text = "Starters";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 46);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // btnStarter1
            // 
            btnStarter1.Location = new Point(189, 30);
            btnStarter1.Name = "btnStarter1";
            btnStarter1.Size = new Size(112, 34);
            btnStarter1.TabIndex = 4;
            btnStarter1.Text = "Ready";
            btnStarter1.UseVisualStyleBackColor = true;
            btnStarter1.Click += btnStarter1_Click;
            // 
            // listViewOrder1
            // 
            listViewOrder1.BackColor = Color.White;
            listViewOrder1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            listViewOrder1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listViewOrder1.Location = new Point(76, 20);
            listViewOrder1.Name = "listViewOrder1";
            listViewOrder1.Size = new Size(316, 405);
            listViewOrder1.TabIndex = 7;
            listViewOrder1.UseCompatibleStateImageBehavior = false;
            listViewOrder1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "";
            columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "001";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 312;
            // 
            // KitchenAndBar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 490);
            Controls.Add(menuStrip1);
            Controls.Add(pnlRunningOrders);
            Controls.Add(pnlFinishedOrders);
            Name = "KitchenAndBar";
            Text = "Form2";
            pnlFinishedOrders.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlRunningOrders.ResumeLayout(false);
            groupBoxMain1.ResumeLayout(false);
            groupBoxMain1.PerformLayout();
            groupBoxDesert1.ResumeLayout(false);
            groupBoxDesert1.PerformLayout();
            groupBoxStarter1.ResumeLayout(false);
            groupBoxStarter1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlFinishedOrders;
        private ListView listViewKitchenOrder2;
        private ListView listViewKitchenOrder1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem runningToolStripMenuItem;
        private ToolStripMenuItem finishedToolStripMenuItem;
        private Panel pnlRunningOrders;
        private ListView listViewBarOrder2;
        private ListView listViewOrder1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button3;
        private Button btnStarter1;
        private Button btnMain1;
        private Button btnDesert1;
        private GroupBox groupBoxStarter1;
        private Label label1;
        private GroupBox groupBoxMain1;
        private Label label2;
        private GroupBox groupBoxDesert1;
        private Label label3;
    }
}