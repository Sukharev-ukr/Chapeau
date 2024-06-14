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
            btnOrderMainScreen.Location = new Point(405, 488);
            btnOrderMainScreen.Margin = new Padding(2, 2, 2, 2);
            btnOrderMainScreen.Name = "btnOrderMainScreen";
            btnOrderMainScreen.Size = new Size(97, 30);
            btnOrderMainScreen.TabIndex = 28;
            btnOrderMainScreen.Text = "Main Screen";
            btnOrderMainScreen.UseVisualStyleBackColor = false;
            btnOrderMainScreen.Click += btnOrderMainScreen_Click;
            // 
            // pbOrderViewTotalPriceFooter
            // 
            pbOrderViewTotalPriceFooter.BackColor = Color.White;
            pbOrderViewTotalPriceFooter.Location = new Point(0, 480);
            pbOrderViewTotalPriceFooter.Name = "pbOrderViewTotalPriceFooter";
            pbOrderViewTotalPriceFooter.Size = new Size(510, 43);
            pbOrderViewTotalPriceFooter.TabIndex = 25;
            pbOrderViewTotalPriceFooter.TabStop = false;
            // 
            // pbOrderSummaryFooter
            // 
            pbOrderSummaryFooter.BackColor = Color.FromArgb(117, 30, 55);
            pbOrderSummaryFooter.Location = new Point(0, 523);
            pbOrderSummaryFooter.Name = "pbOrderSummaryFooter";
            pbOrderSummaryFooter.Size = new Size(510, 43);
            pbOrderSummaryFooter.TabIndex = 24;
            pbOrderSummaryFooter.TabStop = false;
            // 
            // pbOrderSummaryHeader
            // 
            pbOrderSummaryHeader.BackColor = Color.FromArgb(117, 30, 55);
            pbOrderSummaryHeader.Location = new Point(0, 0);
            pbOrderSummaryHeader.Name = "pbOrderSummaryHeader";
            pbOrderSummaryHeader.Size = new Size(510, 43);
            pbOrderSummaryHeader.TabIndex = 23;
            pbOrderSummaryHeader.TabStop = false;
            // 
            // pbOrderSubmitted
            // 
            pbOrderSubmitted.Image = (Image)resources.GetObject("pbOrderSubmitted.Image");
            pbOrderSubmitted.Location = new Point(153, 77);
            pbOrderSubmitted.Margin = new Padding(2, 2, 2, 2);
            pbOrderSubmitted.Name = "pbOrderSubmitted";
            pbOrderSubmitted.Size = new Size(202, 192);
            pbOrderSubmitted.TabIndex = 29;
            pbOrderSubmitted.TabStop = false;
            // 
            // lblOrderSubmitted
            // 
            lblOrderSubmitted.AutoSize = true;
            lblOrderSubmitted.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderSubmitted.Location = new Point(50, 271);
            lblOrderSubmitted.Margin = new Padding(2, 0, 2, 0);
            lblOrderSubmitted.Name = "lblOrderSubmitted";
            lblOrderSubmitted.Size = new Size(408, 30);
            lblOrderSubmitted.TabIndex = 30;
            lblOrderSubmitted.Text = "The order was successfully submitted!";
            lblOrderSubmitted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderSubmittedForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(510, 566);
            Controls.Add(lblOrderSubmitted);
            Controls.Add(pbOrderSubmitted);
            Controls.Add(btnOrderMainScreen);
            Controls.Add(pbOrderViewTotalPriceFooter);
            Controls.Add(pbOrderSummaryFooter);
            Controls.Add(pbOrderSummaryHeader);
            Margin = new Padding(2, 2, 2, 2);
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