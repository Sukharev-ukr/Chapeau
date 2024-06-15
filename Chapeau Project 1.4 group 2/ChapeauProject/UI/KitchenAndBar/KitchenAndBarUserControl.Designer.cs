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
            lblOrderTime.Size = new Size(0, 25);
            lblOrderTime.TabIndex = 12;
            // 
            // listViewOrderItems
            // 
            listViewOrderItems.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listViewOrderItems.FullRowSelect = true;
            listViewOrderItems.Location = new Point(18, 147);
            listViewOrderItems.Name = "listViewOrderItems";
            listViewOrderItems.Size = new Size(324, 203);
            listViewOrderItems.TabIndex = 14;
            listViewOrderItems.UseCompatibleStateImageBehavior = false;
            listViewOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "";
            columnHeader2.Width = 400;
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
            groupBoxOrder.Location = new Point(23, 31);
            groupBoxOrder.Name = "groupBoxOrder";
            groupBoxOrder.Size = new Size(356, 356);
            groupBoxOrder.TabIndex = 15;
            groupBoxOrder.TabStop = false;
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
            comboBoxStatus.Location = new Point(198, 108);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(144, 33);
            comboBoxStatus.TabIndex = 14;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // lblHiddenFinishedTime
            // 
            this.lblHiddenFinishedTime.AutoSize = true;
            this.lblHiddenFinishedTime.Location = new System.Drawing.Point(13, 13);
            this.lblHiddenFinishedTime.Name = "lblHiddenFinishedTime";
            this.lblHiddenFinishedTime.Size = new System.Drawing.Size(0, 13);
            this.lblHiddenFinishedTime.TabIndex = 0;
            this.lblHiddenFinishedTime.Visible = false;
            this.Controls.Add(this.lblHiddenFinishedTime);
            this.ResumeLayout(false);
            // 
            // KitchenAndBarUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblHiddenFinishedTime);
            Controls.Add(groupBoxOrder);
            Name = "KitchenAndBarUserControl";
            Size = new Size(392, 390);
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
    }
}
