namespace UI.PaymentSystem
{
    partial class EqualSplit
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
            labelIncrease = new Label();
            labelDecrease = new Label();
            labelEqualSplitAmount = new Label();
            label3 = new Label();
            labelEqualSplitPart = new Label();
            buttonConfirm = new Button();
            labelWarning = new Label();
            SuspendLayout();
            // 
            // labelIncrease
            // 
            labelIncrease.AutoSize = true;
            labelIncrease.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            labelIncrease.Location = new Point(217, 53);
            labelIncrease.Name = "labelIncrease";
            labelIncrease.Size = new Size(76, 81);
            labelIncrease.TabIndex = 0;
            labelIncrease.Text = "+";
            labelIncrease.Click += labelIncrease_Click;
            // 
            // labelDecrease
            // 
            labelDecrease.AutoSize = true;
            labelDecrease.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            labelDecrease.Location = new Point(53, 53);
            labelDecrease.Name = "labelDecrease";
            labelDecrease.Size = new Size(59, 81);
            labelDecrease.TabIndex = 1;
            labelDecrease.Text = "-";
            labelDecrease.Click += labelDecrease_Click;
            // 
            // labelEqualSplitAmount
            // 
            labelEqualSplitAmount.AutoSize = true;
            labelEqualSplitAmount.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelEqualSplitAmount.Location = new Point(141, 75);
            labelEqualSplitAmount.Name = "labelEqualSplitAmount";
            labelEqualSplitAmount.Size = new Size(45, 54);
            labelEqualSplitAmount.TabIndex = 2;
            labelEqualSplitAmount.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 9);
            label3.Name = "label3";
            label3.Size = new Size(162, 28);
            label3.TabIndex = 3;
            label3.Text = "Amount per part:";
            // 
            // labelEqualSplitPart
            // 
            labelEqualSplitPart.AutoSize = true;
            labelEqualSplitPart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelEqualSplitPart.Location = new Point(213, 9);
            labelEqualSplitPart.Name = "labelEqualSplitPart";
            labelEqualSplitPart.Size = new Size(80, 28);
            labelEqualSplitPart.TabIndex = 4;
            labelEqualSplitPart.Text = "amount";
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Black;
            buttonConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(113, 151);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 10;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.Location = new Point(96, 60);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(115, 15);
            labelWarning.TabIndex = 11;
            labelWarning.Text = "cant go lower than 2";
            labelWarning.Visible = false;
            // 
            // EqualSplit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 203);
            Controls.Add(labelWarning);
            Controls.Add(buttonConfirm);
            Controls.Add(labelEqualSplitPart);
            Controls.Add(label3);
            Controls.Add(labelEqualSplitAmount);
            Controls.Add(labelDecrease);
            Controls.Add(labelIncrease);
            Name = "EqualSplit";
            Text = "Select amount of parts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIncrease;
        private Label labelDecrease;
        private Label labelEqualSplitAmount;
        private Label label3;
        private Label labelEqualSplitPart;
        private Button buttonConfirm;
        private Label labelWarning;
    }
}