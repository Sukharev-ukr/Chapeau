namespace UI.PaymentSystem
{
    partial class BillCompleted
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
            listViewBillList = new ListView();
            columnItemName = new ColumnHeader();
            columnAmount = new ColumnHeader();
            columnPrice = new ColumnHeader();
            columnSum = new ColumnHeader();
            columnVAT = new ColumnHeader();
            labelSubtotal = new Label();
            labelVAT = new Label();
            label4 = new Label();
            label3 = new Label();
            labelTotal = new Label();
            label1 = new Label();
            buttonConfirm = new Button();
            label2 = new Label();
            LabelOrderNR = new Label();
            label5 = new Label();
            labelTip = new Label();
            label8 = new Label();
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
            // listViewBillList
            // 
            listViewBillList.Columns.AddRange(new ColumnHeader[] { columnItemName, columnAmount, columnPrice, columnSum, columnVAT });
            listViewBillList.Location = new Point(-1, 113);
            listViewBillList.Name = "listViewBillList";
            listViewBillList.Size = new Size(403, 232);
            listViewBillList.TabIndex = 4;
            listViewBillList.UseCompatibleStateImageBehavior = false;
            listViewBillList.View = System.Windows.Forms.View.Details;
            // 
            // columnItemName
            // 
            columnItemName.Text = "Item name";
            columnItemName.Width = 160;
            // 
            // columnAmount
            // 
            columnAmount.Text = "Amount";
            // 
            // columnPrice
            // 
            columnPrice.Text = "Price";
            // 
            // columnSum
            // 
            columnSum.Text = "Sum";
            // 
            // columnVAT
            // 
            columnVAT.Text = "VAT";
            columnVAT.Width = 45;
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubtotal.Location = new Point(340, 365);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(38, 19);
            labelSubtotal.TabIndex = 21;
            labelSubtotal.Text = "Total";
            // 
            // labelVAT
            // 
            labelVAT.AutoSize = true;
            labelVAT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelVAT.Location = new Point(340, 384);
            labelVAT.Name = "labelVAT";
            labelVAT.Size = new Size(38, 19);
            labelVAT.TabIndex = 20;
            labelVAT.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(257, 365);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 19;
            label4.Text = "Subtotal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(285, 384);
            label3.Name = "label3";
            label3.Size = new Size(35, 19);
            label3.TabIndex = 18;
            label3.Text = "VAT:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(324, 415);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(54, 28);
            labelTotal.TabIndex = 17;
            labelTotal.Text = "Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 415);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 16;
            label1.Text = "Total:";
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Black;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(148, 482);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 33;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 356);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 34;
            label2.Text = "Bill Completed";
            // 
            // LabelOrderNR
            // 
            LabelOrderNR.AutoSize = true;
            LabelOrderNR.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LabelOrderNR.Location = new Point(87, 73);
            LabelOrderNR.Name = "LabelOrderNR";
            LabelOrderNR.Size = new Size(32, 37);
            LabelOrderNR.TabIndex = 35;
            LabelOrderNR.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 73);
            label5.Name = "label5";
            label5.Size = new Size(85, 37);
            label5.TabIndex = 36;
            label5.Text = "Order";
            // 
            // labelTip
            // 
            labelTip.AutoSize = true;
            labelTip.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTip.Location = new Point(340, 403);
            labelTip.Name = "labelTip";
            labelTip.Size = new Size(38, 19);
            labelTip.TabIndex = 40;
            labelTip.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(285, 403);
            label8.Name = "label8";
            label8.Size = new Size(30, 19);
            label8.TabIndex = 39;
            label8.Text = "Tip:";
            // 
            // BillCompleted
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(401, 558);
            Controls.Add(labelTip);
            Controls.Add(label8);
            Controls.Add(LabelOrderNR);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(buttonConfirm);
            Controls.Add(labelSubtotal);
            Controls.Add(labelVAT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelTotal);
            Controls.Add(label1);
            Controls.Add(listViewBillList);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "BillCompleted";
            Text = "BillOverview";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ListView listViewBillList;
        private ColumnHeader columnItemName;
        private ColumnHeader columnAmount;
        private ColumnHeader columnPrice;
        private ColumnHeader columnSum;
        private ColumnHeader columnVAT;
        private Label labelSubtotal;
        private Label labelVAT;
        private Label label4;
        private Label label3;
        private Label labelTotal;
        private Label label1;
        private Button buttonConfirm;
        private Label label2;
        private Label LabelOrderNR;
        private Label label5;
        private Label labelTip;
        private Label label8;
    }
}