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
            lblCategory = new Label();
            lblTableNumber = new Label();
            lblOrderTime = new Label();
            listViewOrderItems = new ListView();
            columnHeader1 = new ColumnHeader();
            groupBox1 = new GroupBox();
            lblOrderItemTime = new Label();
            comboBoxStatus = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(18, 111);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(81, 25);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "category";
            // 
            // lblTableNumber
            // 
            lblTableNumber.AutoSize = true;
            lblTableNumber.Location = new Point(18, 77);
            lblTableNumber.Name = "lblTableNumber";
            lblTableNumber.Size = new Size(67, 25);
            lblTableNumber.TabIndex = 11;
            lblTableNumber.Text = "tablenr";
            // 
            // lblOrderTime
            // 
            lblOrderTime.AutoSize = true;
            lblOrderTime.Location = new Point(18, 27);
            lblOrderTime.Name = "lblOrderTime";
            lblOrderTime.Size = new Size(87, 25);
            lblOrderTime.TabIndex = 12;
            lblOrderTime.Text = "Placed at:";
            // 
            // listViewOrderItems
            // 
            listViewOrderItems.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewOrderItems.FullRowSelect = true;
            listViewOrderItems.Location = new Point(18, 147);
            listViewOrderItems.Name = "listViewOrderItems";
            listViewOrderItems.Size = new Size(324, 203);
            listViewOrderItems.TabIndex = 14;
            listViewOrderItems.UseCompatibleStateImageBehavior = false;
            listViewOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 400;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(lblOrderItemTime);
            groupBox1.Controls.Add(lblTableNumber);
            groupBox1.Controls.Add(listViewOrderItems);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(lblOrderTime);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(23, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 356);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // lblOrderItemTime
            // 
            lblOrderItemTime.AutoSize = true;
            lblOrderItemTime.Location = new Point(208, 27);
            lblOrderItemTime.Name = "lblOrderItemTime";
            lblOrderItemTime.Size = new Size(90, 25);
            lblOrderItemTime.TabIndex = 15;
            lblOrderItemTime.Text = "ordertime";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "placed", "BeingPrepared", "ready" });
            comboBoxStatus.Location = new Point(208, 108);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(134, 33);
            comboBoxStatus.TabIndex = 14;
            comboBoxStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // KitchenAndBarUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "KitchenAndBarUserControl";
            Size = new Size(392, 390);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCategory;
        private Label lblTableNumber;
        private Label lblOrderTime;
        private ListView listViewOrderItems;
        private GroupBox groupBox1;
        private ComboBox comboBoxStatus;
        private ColumnHeader columnHeader1;
        private Label lblOrderItemTime;
    }
}
