namespace UI.OrderView
{
    partial class OrderSubmittedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSubmittedForm));
            btnOrderMainScreen = new Button();
            pbOrderViewTotalPriceFooter = new PictureBox();
            pbOrderSummaryFooter = new PictureBox();
            pbOrderSummaryHeader = new PictureBox();
            pbOrderSubmitted = new PictureBox();
            lblOrderSubmitted = new Label();
            ((System.ComponentModel.ISupportInitialize)pbOrderViewTotalPriceFooter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSummaryFooter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSummaryHeader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSubmitted).BeginInit();
            SuspendLayout();
            // 
            // btnOrderMainScreen
            // 
            btnOrderMainScreen.BackColor = Color.Black;
            btnOrderMainScreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrderMainScreen.ForeColor = Color.White;
            btnOrderMainScreen.Location = new Point(579, 814);
            btnOrderMainScreen.Name = "btnOrderMainScreen";
            btnOrderMainScreen.Size = new Size(138, 50);
            btnOrderMainScreen.TabIndex = 28;
            btnOrderMainScreen.Text = "Main Screen";
            btnOrderMainScreen.UseVisualStyleBackColor = false;
            btnOrderMainScreen.Click += btnOrderMainScreen_Click;
            // 
            // pbOrderViewTotalPriceFooter
            // 
            pbOrderViewTotalPriceFooter.BackColor = Color.White;
            pbOrderViewTotalPriceFooter.Location = new Point(0, 800);
            pbOrderViewTotalPriceFooter.Margin = new Padding(4, 5, 4, 5);
            pbOrderViewTotalPriceFooter.Name = "pbOrderViewTotalPriceFooter";
            pbOrderViewTotalPriceFooter.Size = new Size(729, 72);
            pbOrderViewTotalPriceFooter.TabIndex = 25;
            pbOrderViewTotalPriceFooter.TabStop = false;
            // 
            // pbOrderSummaryFooter
            // 
            pbOrderSummaryFooter.BackColor = Color.FromArgb(117, 30, 55);
            pbOrderSummaryFooter.Location = new Point(0, 872);
            pbOrderSummaryFooter.Margin = new Padding(4, 5, 4, 5);
            pbOrderSummaryFooter.Name = "pbOrderSummaryFooter";
            pbOrderSummaryFooter.Size = new Size(729, 72);
            pbOrderSummaryFooter.TabIndex = 24;
            pbOrderSummaryFooter.TabStop = false;
            // 
            // pbOrderSummaryHeader
            // 
            pbOrderSummaryHeader.BackColor = Color.FromArgb(117, 30, 55);
            pbOrderSummaryHeader.Location = new Point(0, 0);
            pbOrderSummaryHeader.Margin = new Padding(4, 5, 4, 5);
            pbOrderSummaryHeader.Name = "pbOrderSummaryHeader";
            pbOrderSummaryHeader.Size = new Size(729, 72);
            pbOrderSummaryHeader.TabIndex = 23;
            pbOrderSummaryHeader.TabStop = false;
            // 
            // pbOrderSubmitted
            // 
            pbOrderSubmitted.Image = (Image)resources.GetObject("pbOrderSubmitted.Image");
            pbOrderSubmitted.Location = new Point(242, 227);
            pbOrderSubmitted.Name = "pbOrderSubmitted";
            pbOrderSubmitted.Size = new Size(207, 204);
            pbOrderSubmitted.TabIndex = 29;
            pbOrderSubmitted.TabStop = false;
            // 
            // lblOrderSubmitted
            // 
            lblOrderSubmitted.AutoSize = true;
            lblOrderSubmitted.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderSubmitted.Location = new Point(71, 452);
            lblOrderSubmitted.Name = "lblOrderSubmitted";
            lblOrderSubmitted.Size = new Size(587, 45);
            lblOrderSubmitted.TabIndex = 30;
            lblOrderSubmitted.Text = "The order was successfully submitted!";
            lblOrderSubmitted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderSubmittedForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(728, 944);
            Controls.Add(lblOrderSubmitted);
            Controls.Add(pbOrderSubmitted);
            Controls.Add(btnOrderMainScreen);
            Controls.Add(pbOrderViewTotalPriceFooter);
            Controls.Add(pbOrderSummaryFooter);
            Controls.Add(pbOrderSummaryHeader);
            Name = "OrderSubmittedForm";
            Text = "Order Submitted";
            ((System.ComponentModel.ISupportInitialize)pbOrderViewTotalPriceFooter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSummaryFooter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSummaryHeader).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrderSubmitted).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrderMainScreen;
        private PictureBox pbOrderViewTotalPriceFooter;
        private PictureBox pbOrderSummaryFooter;
        private PictureBox pbOrderSummaryHeader;
        private PictureBox pbOrderSubmitted;
        private Label lblOrderSubmitted;
    }
}