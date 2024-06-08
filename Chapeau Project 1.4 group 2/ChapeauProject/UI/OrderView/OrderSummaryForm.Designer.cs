namespace UI.OrderView
{
    partial class OrderSummaryForm
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
            btnOrderSummarySubmit = new Button();
            lblOrderViewTotal = new Label();
            lblOrderViewTotalTxt = new Label();
            pbOrderViewTotalPriceFooter = new PictureBox();
            pbOrderSummaryFooter = new PictureBox();
            pbOrderSummaryHeader = new PictureBox();
            pnlOrderSummary = new Panel();
            btnOrderSummaryMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pbOrderViewTotalPriceFooter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSummaryFooter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSummaryHeader).BeginInit();
            SuspendLayout();
            // 
            // btnOrderSummarySubmit
            // 
            btnOrderSummarySubmit.BackColor = Color.Black;
            btnOrderSummarySubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrderSummarySubmit.ForeColor = Color.White;
            btnOrderSummarySubmit.Location = new Point(579, 814);
            btnOrderSummarySubmit.Name = "btnOrderSummarySubmit";
            btnOrderSummarySubmit.Size = new Size(138, 50);
            btnOrderSummarySubmit.TabIndex = 20;
            btnOrderSummarySubmit.Text = "Submit Order";
            btnOrderSummarySubmit.UseVisualStyleBackColor = false;
            btnOrderSummarySubmit.Click += btnOrderSummarySubmit_Click;
            // 
            // lblOrderViewTotal
            // 
            lblOrderViewTotal.AutoSize = true;
            lblOrderViewTotal.BackColor = Color.White;
            lblOrderViewTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderViewTotal.Location = new Point(94, 828);
            lblOrderViewTotal.Name = "lblOrderViewTotal";
            lblOrderViewTotal.Size = new Size(94, 25);
            lblOrderViewTotal.TabIndex = 19;
            lblOrderViewTotal.Text = "totalPrice";
            // 
            // lblOrderViewTotalTxt
            // 
            lblOrderViewTotalTxt.AutoSize = true;
            lblOrderViewTotalTxt.BackColor = Color.White;
            lblOrderViewTotalTxt.Location = new Point(13, 827);
            lblOrderViewTotalTxt.Name = "lblOrderViewTotalTxt";
            lblOrderViewTotalTxt.Size = new Size(53, 25);
            lblOrderViewTotalTxt.TabIndex = 18;
            lblOrderViewTotalTxt.Text = "Total:";
            // 
            // pbOrderViewTotalPriceFooter
            // 
            pbOrderViewTotalPriceFooter.BackColor = Color.White;
            pbOrderViewTotalPriceFooter.Location = new Point(0, 800);
            pbOrderViewTotalPriceFooter.Margin = new Padding(4, 5, 4, 5);
            pbOrderViewTotalPriceFooter.Name = "pbOrderViewTotalPriceFooter";
            pbOrderViewTotalPriceFooter.Size = new Size(729, 72);
            pbOrderViewTotalPriceFooter.TabIndex = 17;
            pbOrderViewTotalPriceFooter.TabStop = false;
            // 
            // pbOrderSummaryFooter
            // 
            pbOrderSummaryFooter.BackColor = Color.FromArgb(117, 30, 55);
            pbOrderSummaryFooter.Location = new Point(0, 872);
            pbOrderSummaryFooter.Margin = new Padding(4, 5, 4, 5);
            pbOrderSummaryFooter.Name = "pbOrderSummaryFooter";
            pbOrderSummaryFooter.Size = new Size(729, 72);
            pbOrderSummaryFooter.TabIndex = 16;
            pbOrderSummaryFooter.TabStop = false;
            // 
            // pbOrderSummaryHeader
            // 
            pbOrderSummaryHeader.BackColor = Color.FromArgb(117, 30, 55);
            pbOrderSummaryHeader.Location = new Point(0, 0);
            pbOrderSummaryHeader.Margin = new Padding(4, 5, 4, 5);
            pbOrderSummaryHeader.Name = "pbOrderSummaryHeader";
            pbOrderSummaryHeader.Size = new Size(729, 72);
            pbOrderSummaryHeader.TabIndex = 15;
            pbOrderSummaryHeader.TabStop = false;
            // 
            // pnlOrderSummary
            // 
            pnlOrderSummary.AutoScroll = true;
            pnlOrderSummary.Location = new Point(0, 73);
            pnlOrderSummary.Name = "pnlOrderSummary";
            pnlOrderSummary.Size = new Size(729, 719);
            pnlOrderSummary.TabIndex = 14;
            // 
            // btnOrderSummaryMenu
            // 
            btnOrderSummaryMenu.BackColor = Color.Black;
            btnOrderSummaryMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrderSummaryMenu.ForeColor = Color.White;
            btnOrderSummaryMenu.Location = new Point(435, 814);
            btnOrderSummaryMenu.Name = "btnOrderSummaryMenu";
            btnOrderSummaryMenu.Size = new Size(138, 50);
            btnOrderSummaryMenu.TabIndex = 21;
            btnOrderSummaryMenu.Text = "Back to Menu";
            btnOrderSummaryMenu.UseVisualStyleBackColor = false;
            btnOrderSummaryMenu.Click += btnOrderSummaryMenu_Click;
            // 
            // OrderSummaryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(728, 944);
            Controls.Add(btnOrderSummaryMenu);
            Controls.Add(btnOrderSummarySubmit);
            Controls.Add(lblOrderViewTotal);
            Controls.Add(lblOrderViewTotalTxt);
            Controls.Add(pbOrderViewTotalPriceFooter);
            Controls.Add(pbOrderSummaryFooter);
            Controls.Add(pbOrderSummaryHeader);
            Controls.Add(pnlOrderSummary);
            Name = "OrderSummaryForm";
            Text = "Order Summary";
            ((System.ComponentModel.ISupportInitialize)pbOrderViewTotalPriceFooter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSummaryFooter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSummaryHeader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrderSummarySubmit;
        private Label lblOrderViewTotal;
        private Label lblOrderViewTotalTxt;
        private PictureBox pbOrderViewTotalPriceFooter;
        private PictureBox pbOrderSummaryFooter;
        private PictureBox pbOrderSummaryHeader;
        private Panel pnlOrderSummary;
        private Button btnOrderSummaryMenu;
    }
}