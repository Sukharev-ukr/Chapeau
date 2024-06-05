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
            btnStatus = new Button();
            lblTableNumber = new Label();
            lblOrderTime = new Label();
            lblOrderStatus = new Label();
            listViewOrderItems = new ListView();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(22, 98);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(81, 25);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "category";
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(189, 93);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(112, 34);
            btnStatus.TabIndex = 10;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // lblTableNumber
            // 
            lblTableNumber.AutoSize = true;
            lblTableNumber.Location = new Point(22, 50);
            lblTableNumber.Name = "lblTableNumber";
            lblTableNumber.Size = new Size(67, 25);
            lblTableNumber.TabIndex = 11;
            lblTableNumber.Text = "tablenr";
            // 
            // lblOrderTime
            // 
            lblOrderTime.AutoSize = true;
            lblOrderTime.Location = new Point(234, 50);
            lblOrderTime.Name = "lblOrderTime";
            lblOrderTime.Size = new Size(90, 25);
            lblOrderTime.TabIndex = 12;
            lblOrderTime.Text = "ordertime";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Location = new Point(125, 50);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(106, 25);
            lblOrderStatus.TabIndex = 13;
            lblOrderStatus.Text = "OrderStatus";
            // 
            // listViewOrderItems
            // 
            listViewOrderItems.Location = new Point(22, 133);
            listViewOrderItems.Name = "listViewOrderItems";
            listViewOrderItems.Size = new Size(279, 203);
            listViewOrderItems.TabIndex = 14;
            listViewOrderItems.UseCompatibleStateImageBehavior = false;
            listViewOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // KitchenAndBarUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listViewOrderItems);
            Controls.Add(lblOrderStatus);
            Controls.Add(lblOrderTime);
            Controls.Add(lblTableNumber);
            Controls.Add(btnStatus);
            Controls.Add(lblCategory);
            Name = "KitchenAndBarUserControl";
            Size = new Size(317, 352);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCategory;
        private Button btnStatus;
        private Label lblTableNumber;
        private Label lblOrderTime;
        private Label lblOrderStatus;
        private ListView listViewOrderItems;
    }
}
