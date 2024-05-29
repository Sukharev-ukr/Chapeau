namespace UI
{
    partial class BillDetails
    {
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            listViewBillList = new ListView();
            columnItemName = new ColumnHeader();
            columnAmount = new ColumnHeader();
            columnPrice = new ColumnHeader();
            columnSum = new ColumnHeader();
            label1 = new Label();
            labelTotal = new Label();
            LabelOrderNR = new Label();
            labelTableNR = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(117, 30, 55);
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 43);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(117, 30, 55);
            pictureBox2.Location = new Point(-1, 517);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(403, 43);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // listViewBillList
            // 
            listViewBillList.Columns.AddRange(new ColumnHeader[] { columnItemName, columnAmount, columnPrice, columnSum });
            listViewBillList.Location = new Point(-1, 247);
            listViewBillList.Name = "listViewBillList";
            listViewBillList.Size = new Size(403, 232);
            listViewBillList.TabIndex = 2;
            listViewBillList.UseCompatibleStateImageBehavior = false;
            listViewBillList.View = System.Windows.Forms.View.Details;
            // 
            // columnItemName
            // 
            columnItemName.Text = "Item name";
            columnItemName.Width = 215;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 482);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 3;
            label1.Text = "Total:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(335, 482);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(54, 28);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total";
            // 
            // LabelOrderNR
            // 
            LabelOrderNR.AutoSize = true;
            LabelOrderNR.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LabelOrderNR.Location = new Point(71, 207);
            LabelOrderNR.Name = "LabelOrderNR";
            LabelOrderNR.Size = new Size(32, 37);
            LabelOrderNR.TabIndex = 5;
            LabelOrderNR.Text = "0";
            // 
            // labelTableNR
            // 
            labelTableNR.AutoSize = true;
            labelTableNR.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTableNR.Location = new Point(2, 45);
            labelTableNR.Name = "labelTableNR";
            labelTableNR.Size = new Size(79, 37);
            labelTableNR.TabIndex = 6;
            labelTableNR.Text = "Table";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(282, 202);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 7;
            button1.Text = "Split bill";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(166, 202);
            button2.Name = "button2";
            button2.Size = new Size(110, 39);
            button2.TabIndex = 8;
            button2.Text = "Pay bill";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-4, 207);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 9;
            label2.Text = "Order";
            // 
            // BillDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(401, 558);
            Controls.Add(LabelOrderNR);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelTableNR);
            Controls.Add(labelTotal);
            Controls.Add(label1);
            Controls.Add(listViewBillList);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "BillDetails";
            Text = "PaymentSystem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListView listViewBillList;
        private ColumnHeader columnItemName;
        private ColumnHeader columnAmount;
        private ColumnHeader columnPrice;
        private ColumnHeader columnSum;
        private Label label1;
        private Label labelTotal;
        private Label LabelOrderNR;
        private Label labelTableNR;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}