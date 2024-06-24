namespace UI.OrderView
{
    partial class OrderItemEditDetails
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
            lblItemPriceText = new Label();
            lblItemPrice = new Label();
            lblAddComment = new Label();
            tbCommentBox = new RichTextBox();
            btnSubmitComment = new Button();
            lblItemName = new Label();
            SuspendLayout();
            // 
            // lblItemPriceText
            // 
            lblItemPriceText.AutoSize = true;
            lblItemPriceText.Location = new Point(19, 34);
            lblItemPriceText.Name = "lblItemPriceText";
            lblItemPriceText.Size = new Size(94, 25);
            lblItemPriceText.TabIndex = 0;
            lblItemPriceText.Text = "Item Price:";
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemPrice.Location = new Point(112, 34);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(57, 25);
            lblItemPrice.TabIndex = 1;
            lblItemPrice.Text = "€0.00";
            // 
            // lblAddComment
            // 
            lblAddComment.AutoSize = true;
            lblAddComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddComment.Location = new Point(18, 93);
            lblAddComment.Name = "lblAddComment";
            lblAddComment.Size = new Size(134, 25);
            lblAddComment.TabIndex = 2;
            lblAddComment.Text = "Add Comment";
            // 
            // tbCommentBox
            // 
            tbCommentBox.Location = new Point(20, 131);
            tbCommentBox.Name = "tbCommentBox";
            tbCommentBox.Size = new Size(641, 250);
            tbCommentBox.TabIndex = 3;
            tbCommentBox.Text = "";
            // 
            // btnSubmitComment
            // 
            btnSubmitComment.Location = new Point(525, 387);
            btnSubmitComment.Name = "btnSubmitComment";
            btnSubmitComment.Size = new Size(136, 48);
            btnSubmitComment.TabIndex = 4;
            btnSubmitComment.Text = "Submit";
            btnSubmitComment.UseVisualStyleBackColor = true;
            btnSubmitComment.Click += btnSubmitComment_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(18, 9);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(94, 25);
            lblItemName.TabIndex = 5;
            lblItemName.Text = "itemName";
            // 
            // OrderItemEditDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 447);
            Controls.Add(lblItemName);
            Controls.Add(btnSubmitComment);
            Controls.Add(tbCommentBox);
            Controls.Add(lblAddComment);
            Controls.Add(lblItemPrice);
            Controls.Add(lblItemPriceText);
            Name = "OrderItemEditDetails";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemPriceText;
        private Label lblItemPrice;
        private Label lblAddComment;
        private RichTextBox tbCommentBox;
        private Button btnSubmitComment;
        private Label lblItemName;
    }
}