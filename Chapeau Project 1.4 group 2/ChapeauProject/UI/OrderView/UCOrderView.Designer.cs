namespace UI.OrderView
{
    partial class UCOrderView
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
            btnPlus = new Button();
            btnMinus = new Button();
            lblItemAmount = new Label();
            lblItemName = new Label();
            btnEditItemDetails = new Button();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Lime;
            btnPlus.Location = new Point(94, 14);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(35, 34);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Red;
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(25, 14);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(35, 34);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // lblItemAmount
            // 
            lblItemAmount.AutoSize = true;
            lblItemAmount.Location = new Point(66, 19);
            lblItemAmount.Name = "lblItemAmount";
            lblItemAmount.Size = new Size(22, 25);
            lblItemAmount.TabIndex = 2;
            lblItemAmount.Text = "0";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(135, 19);
            lblItemName.MaximumSize = new Size(500, 40);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(94, 25);
            lblItemName.TabIndex = 3;
            lblItemName.Text = "itemName";
            // 
            // btnEditItemDetails
            // 
            btnEditItemDetails.Location = new Point(647, 14);
            btnEditItemDetails.Name = "btnEditItemDetails";
            btnEditItemDetails.Size = new Size(63, 34);
            btnEditItemDetails.TabIndex = 4;
            btnEditItemDetails.Text = "Edit";
            btnEditItemDetails.UseVisualStyleBackColor = true;
            btnEditItemDetails.Click += btnEditItemDetails_Click;
            // 
            // UCOrderView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnEditItemDetails);
            Controls.Add(lblItemName);
            Controls.Add(lblItemAmount);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Name = "UCOrderView";
            Size = new Size(725, 60);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlus;
        private Button btnMinus;
        private Label lblItemAmount;
        private Label lblItemName;
        private Button btnEditItemDetails;
    }
}
