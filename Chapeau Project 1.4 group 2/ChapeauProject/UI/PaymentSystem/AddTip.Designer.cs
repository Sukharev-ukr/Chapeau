namespace UI.PaymentSystem
{
    partial class AddTip
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
            AddAmount5 = new Button();
            AddAmount10 = new Button();
            AddAmount15 = new Button();
            AddAmount20 = new Button();
            buttonConfirm = new Button();
            textBoxTip = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelTotal = new Label();
            labelTipTotal = new Label();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(117, 30, 55);
            pictureBox2.Location = new Point(-1, 517);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(403, 43);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(117, 30, 55);
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 43);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 45);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 4;
            label1.Text = "Add Amount";
            // 
            // AddAmount5
            // 
            AddAmount5.BackColor = Color.Black;
            AddAmount5.FlatAppearance.BorderSize = 0;
            AddAmount5.FlatStyle = FlatStyle.Flat;
            AddAmount5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddAmount5.ForeColor = Color.White;
            AddAmount5.Location = new Point(96, 91);
            AddAmount5.Name = "AddAmount5";
            AddAmount5.Size = new Size(94, 29);
            AddAmount5.TabIndex = 12;
            AddAmount5.Tag = "5";
            AddAmount5.Text = "€5";
            AddAmount5.UseVisualStyleBackColor = false;
            AddAmount5.Click += AddTipButton_Click;
            // 
            // AddAmount10
            // 
            AddAmount10.BackColor = Color.Black;
            AddAmount10.FlatAppearance.BorderSize = 0;
            AddAmount10.FlatStyle = FlatStyle.Flat;
            AddAmount10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddAmount10.ForeColor = Color.White;
            AddAmount10.Location = new Point(200, 91);
            AddAmount10.Name = "AddAmount10";
            AddAmount10.Size = new Size(94, 29);
            AddAmount10.TabIndex = 13;
            AddAmount10.Tag = "10";
            AddAmount10.Text = "€10";
            AddAmount10.UseVisualStyleBackColor = false;
            AddAmount10.Click += AddTipButton_Click;
            // 
            // AddAmount15
            // 
            AddAmount15.BackColor = Color.Black;
            AddAmount15.FlatAppearance.BorderSize = 0;
            AddAmount15.FlatStyle = FlatStyle.Flat;
            AddAmount15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddAmount15.ForeColor = Color.White;
            AddAmount15.Location = new Point(96, 130);
            AddAmount15.Name = "AddAmount15";
            AddAmount15.Size = new Size(94, 29);
            AddAmount15.TabIndex = 14;
            AddAmount15.Tag = "15";
            AddAmount15.Text = "€15";
            AddAmount15.UseVisualStyleBackColor = false;
            AddAmount15.Click += AddTipButton_Click;
            // 
            // AddAmount20
            // 
            AddAmount20.BackColor = Color.Black;
            AddAmount20.FlatAppearance.BorderSize = 0;
            AddAmount20.FlatStyle = FlatStyle.Flat;
            AddAmount20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddAmount20.ForeColor = Color.White;
            AddAmount20.Location = new Point(200, 130);
            AddAmount20.Name = "AddAmount20";
            AddAmount20.Size = new Size(94, 29);
            AddAmount20.TabIndex = 15;
            AddAmount20.Tag = "20";
            AddAmount20.Text = "€20";
            AddAmount20.UseVisualStyleBackColor = false;
            AddAmount20.Click += AddTipButton_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Black;
            buttonConfirm.FlatAppearance.BorderSize = 0;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(200, 482);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 16;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Visible = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxTip
            // 
            textBoxTip.Location = new Point(132, 304);
            textBoxTip.Name = "textBoxTip";
            textBoxTip.Size = new Size(133, 23);
            textBoxTip.TabIndex = 17;
            textBoxTip.TextChanged += TextBoxCustomTip_TextChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 269);
            label2.Name = "label2";
            label2.Size = new Size(244, 32);
            label2.TabIndex = 18;
            label2.Text = "Enter custom amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 363);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 19;
            label3.Text = "Current total :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(82, 397);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 20;
            label4.Text = "New total: ";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(225, 363);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(49, 25);
            labelTotal.TabIndex = 21;
            labelTotal.Text = "Total";
            // 
            // labelTipTotal
            // 
            labelTipTotal.AutoSize = true;
            labelTipTotal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipTotal.Location = new Point(225, 397);
            labelTipTotal.Name = "labelTipTotal";
            labelTipTotal.Size = new Size(22, 25);
            labelTipTotal.TabIndex = 22;
            labelTipTotal.Text = "0";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Black;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(96, 482);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 23;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddTip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(401, 558);
            Controls.Add(buttonCancel);
            Controls.Add(labelTipTotal);
            Controls.Add(labelTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxTip);
            Controls.Add(buttonConfirm);
            Controls.Add(AddAmount20);
            Controls.Add(AddAmount15);
            Controls.Add(AddAmount10);
            Controls.Add(AddAmount5);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "AddTip";
            Text = "AddTip";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button AddAmount5;
        private Button AddAmount10;
        private Button AddAmount15;
        private Button AddAmount20;
        private Button buttonConfirm;
        private TextBox textBoxTip;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelTotal;
        private Label labelTipTotal;
        private Button buttonCancel;
    }
}