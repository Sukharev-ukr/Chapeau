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
            listViewOrder = new ListView();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
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
            // listViewOrder
            // 
            listViewOrder.BackColor = Color.White;
            listViewOrder.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            listViewOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listViewOrder.FullRowSelect = true;
            listViewOrder.Location = new Point(17, 127);
            listViewOrder.Name = "listViewOrder";
            listViewOrder.Size = new Size(316, 291);
            listViewOrder.TabIndex = 7;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(366, 127);
            listView1.Name = "listView1";
            listView1.Size = new Size(316, 291);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
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
            // listView2
            // 
            listView2.BackColor = Color.White;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader6 });
            listView2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listView2.FullRowSelect = true;
            listView2.Location = new Point(714, 127);
            listView2.Name = "listView2";
            listView2.Size = new Size(316, 291);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
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
            // KitchenAndBarUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(listViewOrder);
            Name = "KitchenAndBarUserControl";
            Size = new Size(1056, 592);
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView listViewOrder;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
    }
}
