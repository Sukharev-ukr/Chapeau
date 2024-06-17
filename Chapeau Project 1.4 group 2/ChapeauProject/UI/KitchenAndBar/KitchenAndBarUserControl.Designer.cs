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
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            groupBoxOrder = new GroupBox();
            lblOrderItemTime = new Label();
            comboBoxStatus = new ComboBox();
            lblHiddenFinishedTime = new Label();
            groupBoxOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(14, 111);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(81, 25);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "category";
            // 
            // lblTableNumber
            // 
            lblTableNumber.AutoSize = true;
            lblTableNumber.Location = new Point(15, 77);
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
            lblOrderTime.Size = new Size(0, 25);
            lblOrderTime.TabIndex = 12;
            // 
            // listViewOrderItems
            // 
            listViewOrderItems.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1 });
            listViewOrderItems.FullRowSelect = true;
            listViewOrderItems.Location = new Point(13, 147);
            listViewOrderItems.Name = "listViewOrderItems";
            listViewOrderItems.Size = new Size(517, 203);
            listViewOrderItems.TabIndex = 14;
            listViewOrderItems.UseCompatibleStateImageBehavior = false;
            listViewOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Items";
            columnHeader2.Width = 420;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Comment";
            columnHeader1.Width = 260;
            // 
            // groupBoxOrder
            // 
            groupBoxOrder.BackColor = Color.WhiteSmoke;
            groupBoxOrder.Controls.Add(lblOrderItemTime);
            groupBoxOrder.Controls.Add(lblTableNumber);
            groupBoxOrder.Controls.Add(listViewOrderItems);
            groupBoxOrder.Controls.Add(lblCategory);
            groupBoxOrder.Controls.Add(lblOrderTime);
            groupBoxOrder.Controls.Add(comboBoxStatus);
            groupBoxOrder.ForeColor = SystemColors.ControlText;
            groupBoxOrder.Location = new Point(19, 31);
            groupBoxOrder.Name = "groupBoxOrder";
            groupBoxOrder.Size = new Size(545, 356);
            groupBoxOrder.TabIndex = 15;
            groupBoxOrder.TabStop = false;
            // 
            // lblOrderItemTime
            // 
            lblOrderItemTime.AutoSize = true;
            lblOrderItemTime.Location = new Point(418, 35);
            lblOrderItemTime.Name = "lblOrderItemTime";
            lblOrderItemTime.Size = new Size(90, 25);
            lblOrderItemTime.TabIndex = 15;
            lblOrderItemTime.Text = "ordertime";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "placed", "BeingPrepared", "ready" });
            comboBoxStatus.Location = new Point(384, 103);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(144, 33);
            comboBoxStatus.TabIndex = 14;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // lblHiddenFinishedTime
            // 
            lblHiddenFinishedTime.AutoSize = true;
            lblHiddenFinishedTime.Location = new Point(13, 13);
            lblHiddenFinishedTime.Name = "lblHiddenFinishedTime";
            lblHiddenFinishedTime.Size = new Size(0, 25);
            lblHiddenFinishedTime.TabIndex = 0;
            lblHiddenFinishedTime.Visible = false;
            // 
            // KitchenAndBarUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblHiddenFinishedTime);
            Controls.Add(groupBoxOrder);
            Name = "KitchenAndBarUserControl";
            Size = new Size(567, 390);
            groupBoxOrder.ResumeLayout(false);
            groupBoxOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCategory;
        private Label lblTableNumber;
        private Label lblOrderTime;
        private ListView listViewOrderItems;
        private GroupBox groupBoxOrder;
        private ComboBox comboBoxStatus;
        private Label lblOrderItemTime;
        private ColumnHeader columnHeader2;
        private Label lblHiddenFinishedTime;
        private ColumnHeader columnHeader1;
    }
}
