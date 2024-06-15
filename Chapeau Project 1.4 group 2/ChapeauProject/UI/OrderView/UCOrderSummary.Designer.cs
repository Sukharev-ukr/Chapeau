namespace UI.OrderView
{
    partial class UCOrderSummary
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
            lblItemNameOrderSummary = new Label();
            lblItemAmountOrderSummary = new Label();
            btnMinusOrderSummary = new Button();
            btnPlusOrderSummary = new Button();
            SuspendLayout();
            // 
            // lblItemNameOrderSummary
            // 
            lblItemNameOrderSummary.AutoSize = true;
            lblItemNameOrderSummary.Location = new Point(118, 19);
            lblItemNameOrderSummary.MaximumSize = new Size(500, 40);
            lblItemNameOrderSummary.Name = "lblItemNameOrderSummary";
            lblItemNameOrderSummary.Size = new Size(94, 25);
            lblItemNameOrderSummary.TabIndex = 7;
            lblItemNameOrderSummary.Text = "itemName";
            // 
            // lblItemAmountOrderSummary
            // 
            lblItemAmountOrderSummary.AutoSize = true;
            lblItemAmountOrderSummary.Location = new Point(49, 19);
            lblItemAmountOrderSummary.Name = "lblItemAmountOrderSummary";
            lblItemAmountOrderSummary.Size = new Size(22, 25);
            lblItemAmountOrderSummary.TabIndex = 6;
            lblItemAmountOrderSummary.Text = "0";
            // 
            // btnMinusOrderSummary
            // 
            btnMinusOrderSummary.BackColor = Color.Red;
            btnMinusOrderSummary.ForeColor = Color.White;
            btnMinusOrderSummary.Location = new Point(8, 14);
            btnMinusOrderSummary.Name = "btnMinusOrderSummary";
            btnMinusOrderSummary.Size = new Size(35, 34);
            btnMinusOrderSummary.TabIndex = 5;
            btnMinusOrderSummary.Text = "-";
            btnMinusOrderSummary.UseVisualStyleBackColor = false;
            btnMinusOrderSummary.Click += btnMinusOrderSummary_Click;
            // 
            // btnPlusOrderSummary
            // 
            btnPlusOrderSummary.BackColor = Color.Lime;
            btnPlusOrderSummary.Location = new Point(77, 14);
            btnPlusOrderSummary.Name = "btnPlusOrderSummary";
            btnPlusOrderSummary.Size = new Size(35, 34);
            btnPlusOrderSummary.TabIndex = 4;
            btnPlusOrderSummary.Text = "+";
            btnPlusOrderSummary.UseVisualStyleBackColor = false;
            btnPlusOrderSummary.Click += btnPlusOrderSummary_Click;
            // 
            // UCOrderSummary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblItemNameOrderSummary);
            Controls.Add(lblItemAmountOrderSummary);
            Controls.Add(btnMinusOrderSummary);
            Controls.Add(btnPlusOrderSummary);
            Name = "UCOrderSummary";
            Size = new Size(725, 60);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemNameOrderSummary;
        private Label lblItemAmountOrderSummary;
        private Button btnMinusOrderSummary;
        private Button btnPlusOrderSummary;
    }
}
