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
            lblOrderViewTotal = new Label();
            btnOrderViewSummary = new Button();
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
            // lblOrderViewTotal
            // 
            lblOrderViewTotal.AutoSize = true;
            lblOrderViewTotal.BackColor = Color.White;
            lblOrderViewTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderViewTotal.Location = new Point(93, 829);
            lblOrderViewTotal.Name = "lblOrderViewTotal";
            lblOrderViewTotal.Size = new Size(94, 25);
            lblOrderViewTotal.TabIndex = 9;
            lblOrderViewTotal.Text = "totalPrice";
            // 
            // btnOrderViewSummary
            // 
            btnOrderViewSummary.BackColor = Color.Black;
            btnOrderViewSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrderViewSummary.ForeColor = Color.White;
            btnOrderViewSummary.Location = new Point(578, 815);
            btnOrderViewSummary.Name = "btnOrderViewSummary";
            btnOrderViewSummary.Size = new Size(138, 50);
            btnOrderViewSummary.TabIndex = 10;
            btnOrderViewSummary.Text = "Summary";
            btnOrderViewSummary.UseVisualStyleBackColor = false;
            btnOrderViewSummary.Click += btnOrderViewSummary_Click;
            // 
            // OrderViewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(728, 944);
            Controls.Add(btnOrderViewSummary);
            Controls.Add(lblOrderViewTotal);
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
        private Label lblOrderViewTotal;
        private Button btnOrderViewSummary;
    }
}