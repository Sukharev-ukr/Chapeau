using View.Properties;


namespace UI.PaymentSystem
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBoxNFC = new PictureBox();
            labelPart = new Label();
            label4 = new Label();
            labelPartCost = new Label();
            label3 = new Label();
            labelOrderNr = new Label();
            label1 = new Label();
            buttonConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNFC).BeginInit();
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
            // pictureBoxNFC
            // 
            pictureBoxNFC.Enabled = false;
            pictureBoxNFC.Image = (Image)resources.GetObject("pictureBoxNFC.Image");
            pictureBoxNFC.Location = new Point(53, 145);
            pictureBoxNFC.Name = "pictureBoxNFC";
            pictureBoxNFC.Size = new Size(272, 240);
            pictureBoxNFC.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNFC.TabIndex = 4;
            pictureBoxNFC.TabStop = false;
            pictureBoxNFC.Visible = false;
            pictureBoxNFC.Click += PaymentConfirm;
            // 
            // labelPart
            // 
            labelPart.AutoSize = true;
            labelPart.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelPart.Location = new Point(222, 91);
            labelPart.Name = "labelPart";
            labelPart.Size = new Size(23, 37);
            labelPart.TabIndex = 31;
            labelPart.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(131, 91);
            label4.Name = "label4";
            label4.Size = new Size(63, 37);
            label4.TabIndex = 30;
            label4.Text = "Part";
            // 
            // labelPartCost
            // 
            labelPartCost.AutoSize = true;
            labelPartCost.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelPartCost.Location = new Point(202, 418);
            labelPartCost.Name = "labelPartCost";
            labelPartCost.Size = new Size(48, 25);
            labelPartCost.TabIndex = 29;
            labelPartCost.Text = "total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(131, 418);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 28;
            label3.Text = "To Pay: ";
            // 
            // labelOrderNr
            // 
            labelOrderNr.AutoSize = true;
            labelOrderNr.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrderNr.Location = new Point(222, 45);
            labelOrderNr.Name = "labelOrderNr";
            labelOrderNr.Size = new Size(23, 37);
            labelOrderNr.TabIndex = 27;
            labelOrderNr.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(131, 45);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 26;
            label1.Text = "Order";
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Black;
            buttonConfirm.Enabled = false;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(131, 472);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 32;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Visible = false;
            buttonConfirm.Click += PaymentConfirm;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(401, 558);
            Controls.Add(buttonConfirm);
            Controls.Add(labelPart);
            Controls.Add(label4);
            Controls.Add(labelPartCost);
            Controls.Add(label3);
            Controls.Add(labelOrderNr);
            Controls.Add(label1);
            Controls.Add(pictureBoxNFC);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Checkout";
            Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNFC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxNFC;
        private Label labelPart;
        private Label label4;
        private Label labelPartCost;
        private Label label3;
        private Label labelOrderNr;
        private Label label1;
        private Button buttonConfirm;
    }
}