namespace UI.PaymentSystem
{
    partial class PaymentForm
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
            radioButtonCredit = new RadioButton();
            radioButtonDebit = new RadioButton();
            radioButtonCash = new RadioButton();
            label1 = new Label();
            labelOrderNr = new Label();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            labelPartCost = new Label();
            label4 = new Label();
            labelPart = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(117, 30, 55);
            pictureBox2.Location = new Point(0, 517);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(403, 43);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(117, 30, 55);
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 43);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // radioButtonCredit
            // 
            radioButtonCredit.AutoSize = true;
            radioButtonCredit.Location = new Point(35, 188);
            radioButtonCredit.Name = "radioButtonCredit";
            radioButtonCredit.Size = new Size(57, 19);
            radioButtonCredit.TabIndex = 4;
            radioButtonCredit.TabStop = true;
            radioButtonCredit.Text = "Credit";
            radioButtonCredit.UseVisualStyleBackColor = true;
            radioButtonCredit.CheckedChanged += radioButtonCredit_CheckedChanged;
            // 
            // radioButtonDebit
            // 
            radioButtonDebit.AutoSize = true;
            radioButtonDebit.Location = new Point(35, 213);
            radioButtonDebit.Name = "radioButtonDebit";
            radioButtonDebit.Size = new Size(53, 19);
            radioButtonDebit.TabIndex = 5;
            radioButtonDebit.TabStop = true;
            radioButtonDebit.Text = "Debit";
            radioButtonDebit.UseVisualStyleBackColor = true;
            radioButtonDebit.CheckedChanged += radioButtonDebit_CheckedChanged;
            // 
            // radioButtonCash
            // 
            radioButtonCash.AutoSize = true;
            radioButtonCash.Location = new Point(35, 238);
            radioButtonCash.Name = "radioButtonCash";
            radioButtonCash.Size = new Size(51, 19);
            radioButtonCash.TabIndex = 6;
            radioButtonCash.TabStop = true;
            radioButtonCash.Text = "Cash";
            radioButtonCash.UseVisualStyleBackColor = true;
            radioButtonCash.CheckedChanged += radioButtonCash_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(124, 45);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 7;
            label1.Text = "Order";
            // 
            // labelOrderNr
            // 
            labelOrderNr.AutoSize = true;
            labelOrderNr.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrderNr.Location = new Point(215, 45);
            labelOrderNr.Name = "labelOrderNr";
            labelOrderNr.Size = new Size(23, 37);
            labelOrderNr.TabIndex = 8;
            labelOrderNr.Text = ".";
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Black;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(215, 482);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 19;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Black;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(98, 482);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 20;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 160);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 21;
            label2.Text = "Payment method";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(132, 378);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 22;
            label3.Text = "To Pay: ";
            // 
            // labelPartCost
            // 
            labelPartCost.AutoSize = true;
            labelPartCost.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelPartCost.Location = new Point(203, 378);
            labelPartCost.Name = "labelPartCost";
            labelPartCost.Size = new Size(48, 25);
            labelPartCost.TabIndex = 23;
            labelPartCost.Text = "total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(124, 91);
            label4.Name = "label4";
            label4.Size = new Size(63, 37);
            label4.TabIndex = 24;
            label4.Text = "Part";
            // 
            // labelPart
            // 
            labelPart.AutoSize = true;
            labelPart.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelPart.Location = new Point(215, 91);
            labelPart.Name = "labelPart";
            labelPart.Size = new Size(23, 37);
            labelPart.TabIndex = 25;
            labelPart.Text = ".";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(401, 558);
            Controls.Add(labelPart);
            Controls.Add(label4);
            Controls.Add(labelPartCost);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(labelOrderNr);
            Controls.Add(label1);
            Controls.Add(radioButtonCash);
            Controls.Add(radioButtonDebit);
            Controls.Add(radioButtonCredit);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "PaymentForm";
            Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RadioButton radioButtonCredit;
        private RadioButton radioButtonDebit;
        private RadioButton radioButtonCash;
        private Label label1;
        private Label labelOrderNr;
        private Button buttonConfirm;
        private Button buttonCancel;
        private Label label2;
        private Label label3;
        private Label labelPartCost;
        private Label label4;
        private Label labelPart;
    }
}