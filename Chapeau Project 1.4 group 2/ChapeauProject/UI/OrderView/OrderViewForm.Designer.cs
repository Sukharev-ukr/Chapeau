namespace UI.OrderView
{
    partial class OrderViewForm
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
            btnLunch = new Button();
            btnDiner = new Button();
            btnDrinks = new Button();
            pnlOrderView = new Panel();
            pbOrderViewHeader = new PictureBox();
            pbOrderViewFooter = new PictureBox();
            pbOrderViewTotalPriceFooter = new PictureBox();
            lblOrderViewTotalTxt = new Label();
            lblOrderViewTotalPrice = new Label();
            btnOrderViewSubmit = new Button();
            lblTableNr = new Label();
            lblOrderId = new Label();
            btnDeleteOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)pbOrderViewHeader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderViewFooter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderViewTotalPriceFooter).BeginInit();
            SuspendLayout();
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.FromArgb(255, 223, 223);
            btnLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLunch.Location = new Point(6, 81);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(235, 132);
            btnLunch.TabIndex = 1;
            btnLunch.Text = "Lunch";
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.Click += btnLunch_Click;
            // 
            // btnDiner
            // 
            btnDiner.BackColor = Color.FromArgb(255, 223, 223);
            btnDiner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiner.Location = new Point(247, 81);
            btnDiner.Name = "btnDiner";
            btnDiner.Size = new Size(235, 132);
            btnDiner.TabIndex = 2;
            btnDiner.Text = "Diner";
            btnDiner.UseVisualStyleBackColor = false;
            btnDiner.Click += btnDiner_Click;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = Color.FromArgb(255, 223, 223);
            btnDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDrinks.Location = new Point(488, 81);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(235, 132);
            btnDrinks.TabIndex = 3;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = false;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // pnlOrderView
            // 
            pnlOrderView.AutoScroll = true;
            pnlOrderView.Location = new Point(-1, 219);
            pnlOrderView.Name = "pnlOrderView";
            pnlOrderView.Size = new Size(729, 574);
            pnlOrderView.TabIndex = 4;
            // 
            // pbOrderViewHeader
            // 
            pbOrderViewHeader.BackColor = Color.FromArgb(117, 30, 55);
            pbOrderViewHeader.Location = new Point(-1, 1);
            pbOrderViewHeader.Margin = new Padding(4, 5, 4, 5);
            pbOrderViewHeader.Name = "pbOrderViewHeader";
            pbOrderViewHeader.Size = new Size(729, 72);
            pbOrderViewHeader.TabIndex = 5;
            pbOrderViewHeader.TabStop = false;
            // 
            // pbOrderViewFooter
            // 
            pbOrderViewFooter.BackColor = Color.FromArgb(117, 30, 55);
            pbOrderViewFooter.Location = new Point(-1, 873);
            pbOrderViewFooter.Margin = new Padding(4, 5, 4, 5);
            pbOrderViewFooter.Name = "pbOrderViewFooter";
            pbOrderViewFooter.Size = new Size(729, 72);
            pbOrderViewFooter.TabIndex = 6;
            pbOrderViewFooter.TabStop = false;
            // 
            // pbOrderViewTotalPriceFooter
            // 
            pbOrderViewTotalPriceFooter.BackColor = Color.White;
            pbOrderViewTotalPriceFooter.Location = new Point(-1, 801);
            pbOrderViewTotalPriceFooter.Margin = new Padding(4, 5, 4, 5);
            pbOrderViewTotalPriceFooter.Name = "pbOrderViewTotalPriceFooter";
            pbOrderViewTotalPriceFooter.Size = new Size(729, 72);
            pbOrderViewTotalPriceFooter.TabIndex = 7;
            pbOrderViewTotalPriceFooter.TabStop = false;
            // 
            // lblOrderViewTotalTxt
            // 
            lblOrderViewTotalTxt.AutoSize = true;
            lblOrderViewTotalTxt.BackColor = Color.White;
            lblOrderViewTotalTxt.Location = new Point(12, 828);
            lblOrderViewTotalTxt.Name = "lblOrderViewTotalTxt";
            lblOrderViewTotalTxt.Size = new Size(53, 25);
            lblOrderViewTotalTxt.TabIndex = 8;
            lblOrderViewTotalTxt.Text = "Total:";
            // 
            // lblOrderViewTotalPrice
            // 
            lblOrderViewTotalPrice.AutoSize = true;
            lblOrderViewTotalPrice.BackColor = Color.White;
            lblOrderViewTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderViewTotalPrice.Location = new Point(59, 828);
            lblOrderViewTotalPrice.Name = "lblOrderViewTotalPrice";
            lblOrderViewTotalPrice.Size = new Size(57, 25);
            lblOrderViewTotalPrice.TabIndex = 9;
            lblOrderViewTotalPrice.Text = "€0.00";
            // 
            // btnOrderViewSubmit
            // 
            btnOrderViewSubmit.BackColor = Color.Black;
            btnOrderViewSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrderViewSubmit.ForeColor = Color.White;
            btnOrderViewSubmit.Location = new Point(578, 815);
            btnOrderViewSubmit.Name = "btnOrderViewSubmit";
            btnOrderViewSubmit.Size = new Size(138, 50);
            btnOrderViewSubmit.TabIndex = 10;
            btnOrderViewSubmit.Text = "Submit";
            btnOrderViewSubmit.UseVisualStyleBackColor = false;
            btnOrderViewSubmit.Click += btnOrderViewSubmit_Click;
            // 
            // lblTableNr
            // 
            lblTableNr.AutoSize = true;
            lblTableNr.BackColor = Color.FromArgb(117, 30, 55);
            lblTableNr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNr.ForeColor = Color.White;
            lblTableNr.Location = new Point(21, 23);
            lblTableNr.Name = "lblTableNr";
            lblTableNr.Size = new Size(72, 25);
            lblTableNr.TabIndex = 11;
            lblTableNr.Text = "Table 0";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.BackColor = Color.FromArgb(117, 30, 55);
            lblOrderId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderId.ForeColor = Color.White;
            lblOrderId.Location = new Point(99, 23);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(36, 25);
            lblOrderId.TabIndex = 12;
            lblOrderId.Text = "(0)";
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.Black;
            btnDeleteOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteOrder.ForeColor = Color.White;
            btnDeleteOrder.Location = new Point(578, 10);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(138, 50);
            btnDeleteOrder.TabIndex = 13;
            btnDeleteOrder.Text = "Delete Order";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // OrderViewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(728, 944);
            Controls.Add(btnDeleteOrder);
            Controls.Add(lblOrderId);
            Controls.Add(lblTableNr);
            Controls.Add(btnOrderViewSubmit);
            Controls.Add(lblOrderViewTotalPrice);
            Controls.Add(lblOrderViewTotalTxt);
            Controls.Add(pbOrderViewTotalPriceFooter);
            Controls.Add(pbOrderViewFooter);
            Controls.Add(pbOrderViewHeader);
            Controls.Add(btnDrinks);
            Controls.Add(btnDiner);
            Controls.Add(btnLunch);
            Controls.Add(pnlOrderView);
            Name = "OrderViewForm";
            Text = "Order View";
            Load += OrderView_Load;
            ((System.ComponentModel.ISupportInitialize)pbOrderViewHeader).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderViewFooter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderViewTotalPriceFooter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLunch;
        private Button btnDiner;
        private Button btnDrinks;
        private Panel pnlOrderView;
        private PictureBox pbOrderViewHeader;
        private PictureBox pbOrderViewFooter;
        private PictureBox pbOrderViewTotalPriceFooter;
        private Label lblOrderViewTotalTxt;
        private Label lblOrderViewTotalPrice;
        private Button btnOrderViewSubmit;
        private Label lblTableNr;
        private Label lblOrderId;
        private Button btnDeleteOrder;
    }
}