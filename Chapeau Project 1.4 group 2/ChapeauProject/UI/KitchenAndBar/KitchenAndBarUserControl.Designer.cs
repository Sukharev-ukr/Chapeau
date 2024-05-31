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
            listViewOrder.Location = new Point(330, 63);
            listViewOrder.Name = "listViewOrder";
            listViewOrder.Size = new Size(316, 351);
            listViewOrder.TabIndex = 7;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // KitchenAndBarUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listViewOrder);
            Name = "KitchenAndBarUserControl";
            Size = new Size(1056, 592);
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView listViewOrder;
    }
}
