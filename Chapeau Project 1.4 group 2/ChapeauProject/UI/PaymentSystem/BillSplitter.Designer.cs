namespace UI.PaymentSystem
{
    partial class BillSplitter
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelTotal = new Label();
            label3 = new Label();
            labelRemainingTotal = new Label();
            flowLayoutPanelSplit = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            buttonCustomSplit = new Button();
            buttonEqualSplit = new Button();
            labelWarning = new Label();
            labelNotification = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(117, 30, 55);
            pictureBox2.Location = new Point(-2, 516);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(403, 43);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(117, 30, 55);
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 43);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-2, 44);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 4;
            label1.Text = "Total";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(166, 44);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(54, 28);
            labelTotal.TabIndex = 5;
            labelTotal.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(-2, 72);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 6;
            label3.Text = "Remaining Total";
            // 
            // labelRemainingTotal
            // 
            labelRemainingTotal.AutoSize = true;
            labelRemainingTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelRemainingTotal.Location = new Point(166, 72);
            labelRemainingTotal.Name = "labelRemainingTotal";
            labelRemainingTotal.Size = new Size(54, 28);
            labelRemainingTotal.TabIndex = 7;
            labelRemainingTotal.Text = "Total";
            // 
            // flowLayoutPanelSplit
            // 
            flowLayoutPanelSplit.AutoScroll = true;
            flowLayoutPanelSplit.Location = new Point(12, 124);
            flowLayoutPanelSplit.Name = "flowLayoutPanelSplit";
            flowLayoutPanelSplit.Size = new Size(377, 302);
            flowLayoutPanelSplit.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Black;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(95, 484);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Black;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(195, 484);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 9;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCustomSplit
            // 
            buttonCustomSplit.BackColor = Color.Black;
            buttonCustomSplit.FlatStyle = FlatStyle.Flat;
            buttonCustomSplit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustomSplit.ForeColor = Color.White;
            buttonCustomSplit.Location = new Point(80, 449);
            buttonCustomSplit.Name = "buttonCustomSplit";
            buttonCustomSplit.Size = new Size(109, 29);
            buttonCustomSplit.TabIndex = 11;
            buttonCustomSplit.Text = "Custom split";
            buttonCustomSplit.UseVisualStyleBackColor = false;
            buttonCustomSplit.Click += buttonCustomSplit_Click;
            // 
            // buttonEqualSplit
            // 
            buttonEqualSplit.BackColor = Color.Black;
            buttonEqualSplit.FlatStyle = FlatStyle.Flat;
            buttonEqualSplit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEqualSplit.ForeColor = Color.White;
            buttonEqualSplit.Location = new Point(195, 449);
            buttonEqualSplit.Name = "buttonEqualSplit";
            buttonEqualSplit.Size = new Size(109, 29);
            buttonEqualSplit.TabIndex = 12;
            buttonEqualSplit.Text = "Equal split";
            buttonEqualSplit.UseVisualStyleBackColor = false;
            buttonEqualSplit.Click += buttonEqualSplit_Click;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.Location = new Point(12, 106);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(0, 15);
            labelWarning.TabIndex = 13;
            // 
            // labelNotification
            // 
            labelNotification.Anchor = AnchorStyles.None;
            labelNotification.AutoSize = true;
            labelNotification.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNotification.Location = new Point(12, 429);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(52, 21);
            labelNotification.TabIndex = 14;
            labelNotification.Text = "notice";
            labelNotification.Visible = false;
            // 
            // BillSplitter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(401, 558);
            Controls.Add(labelNotification);
            Controls.Add(labelWarning);
            Controls.Add(buttonEqualSplit);
            Controls.Add(buttonCustomSplit);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(flowLayoutPanelSplit);
            Controls.Add(labelRemainingTotal);
            Controls.Add(label3);
            Controls.Add(labelTotal);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "BillSplitter";
            Text = "BillSplitter";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelTotal;
        private Label label3;
        private Label labelRemainingTotal;
        private FlowLayoutPanel flowLayoutPanelSplit;
        private Button buttonCancel;
        private Button buttonConfirm;
        private Button buttonCustomSplit;
        private Button buttonEqualSplit;
        private Label labelWarning;
        private Label labelNotification;
    }
}