namespace UI.PaymentSystem
{
    partial class CustomSplit
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
            label1 = new Label();
            textBoxCustomAmount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonDevide1 = new Button();
            buttonDevide2 = new Button();
            buttonDevide3 = new Button();
            buttonDevide4 = new Button();
            buttonDevide5 = new Button();
            LabelDevideTotal = new Label();
            labelDevidePartCost = new Label();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Custom split";
            // 
            // textBoxCustomAmount
            // 
            textBoxCustomAmount.Location = new Point(12, 27);
            textBoxCustomAmount.Name = "textBoxCustomAmount";
            textBoxCustomAmount.Size = new Size(100, 23);
            textBoxCustomAmount.TabIndex = 1;
            textBoxCustomAmount.TextChanged += TextBoxCustomAmount_OnTextChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Bill total: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 3;
            label3.Text = "Part cost: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 9);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 4;
            label4.Text = "Quick selection";
            // 
            // buttonDevide1
            // 
            buttonDevide1.AccessibleName = "QuickDevider";
            buttonDevide1.BackColor = Color.Black;
            buttonDevide1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDevide1.ForeColor = Color.White;
            buttonDevide1.Location = new Point(170, 27);
            buttonDevide1.Name = "buttonDevide1";
            buttonDevide1.Size = new Size(79, 29);
            buttonDevide1.TabIndex = 11;
            buttonDevide1.Tag = "0.5";
            buttonDevide1.Text = "1/2";
            buttonDevide1.UseVisualStyleBackColor = false;
            buttonDevide1.Click += QuickSelection_Click;
            // 
            // buttonDevide2
            // 
            buttonDevide2.BackColor = Color.Black;
            buttonDevide2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDevide2.ForeColor = Color.White;
            buttonDevide2.Location = new Point(254, 27);
            buttonDevide2.Name = "buttonDevide2";
            buttonDevide2.Size = new Size(79, 29);
            buttonDevide2.TabIndex = 12;
            buttonDevide2.Tag = "0.33";
            buttonDevide2.Text = "1/3";
            buttonDevide2.UseVisualStyleBackColor = false;
            buttonDevide2.Click += QuickSelection_Click;
            // 
            // buttonDevide3
            // 
            buttonDevide3.BackColor = Color.Black;
            buttonDevide3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDevide3.ForeColor = Color.White;
            buttonDevide3.Location = new Point(170, 62);
            buttonDevide3.Name = "buttonDevide3";
            buttonDevide3.Size = new Size(79, 29);
            buttonDevide3.TabIndex = 13;
            buttonDevide3.Tag = "0.66";
            buttonDevide3.Text = "2/3";
            buttonDevide3.UseVisualStyleBackColor = false;
            buttonDevide3.Click += QuickSelection_Click;
            // 
            // buttonDevide4
            // 
            buttonDevide4.BackColor = Color.Black;
            buttonDevide4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDevide4.ForeColor = Color.White;
            buttonDevide4.Location = new Point(255, 62);
            buttonDevide4.Name = "buttonDevide4";
            buttonDevide4.Size = new Size(79, 29);
            buttonDevide4.TabIndex = 14;
            buttonDevide4.Tag = "0.75";
            buttonDevide4.Text = "3/4";
            buttonDevide4.UseVisualStyleBackColor = false;
            buttonDevide4.Click += QuickSelection_Click;
            // 
            // buttonDevide5
            // 
            buttonDevide5.BackColor = Color.Black;
            buttonDevide5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDevide5.ForeColor = Color.White;
            buttonDevide5.Location = new Point(254, 97);
            buttonDevide5.Name = "buttonDevide5";
            buttonDevide5.Size = new Size(79, 29);
            buttonDevide5.TabIndex = 15;
            buttonDevide5.Tag = "0.25";
            buttonDevide5.Text = "1/4";
            buttonDevide5.UseVisualStyleBackColor = false;
            buttonDevide5.Click += QuickSelection_Click;
            // 
            // LabelDevideTotal
            // 
            LabelDevideTotal.AutoSize = true;
            LabelDevideTotal.Location = new Point(91, 106);
            LabelDevideTotal.Name = "LabelDevideTotal";
            LabelDevideTotal.Size = new Size(51, 15);
            LabelDevideTotal.TabIndex = 16;
            LabelDevideTotal.Text = "Amount";
            // 
            // labelDevidePartCost
            // 
            labelDevidePartCost.AutoSize = true;
            labelDevidePartCost.Location = new Point(91, 134);
            labelDevidePartCost.Name = "labelDevidePartCost";
            labelDevidePartCost.Size = new Size(51, 15);
            labelDevidePartCost.TabIndex = 17;
            labelDevidePartCost.Text = "Amount";
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Black;
            buttonConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(112, 169);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 18;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // CustomSplit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 203);
            Controls.Add(buttonConfirm);
            Controls.Add(labelDevidePartCost);
            Controls.Add(LabelDevideTotal);
            Controls.Add(buttonDevide5);
            Controls.Add(buttonDevide4);
            Controls.Add(buttonDevide3);
            Controls.Add(buttonDevide2);
            Controls.Add(buttonDevide1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxCustomAmount);
            Controls.Add(label1);
            Name = "CustomSplit";
            Text = "Devide by bill total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCustomAmount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonDevide1;
        private Button buttonDevide2;
        private Button buttonDevide3;
        private Button buttonDevide4;
        private Button buttonDevide5;
        private Label LabelDevideTotal;
        private Label labelDevidePartCost;
        private Button buttonConfirm;
    }
}