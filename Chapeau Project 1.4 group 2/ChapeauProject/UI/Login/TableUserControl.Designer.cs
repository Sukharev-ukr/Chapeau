namespace UI.Login
{
    partial class TableUserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTableNumber = new Label();
            SuspendLayout();
            // 
            // lblTableNumber
            // 
            lblTableNumber.Dock = DockStyle.Fill;
            lblTableNumber.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblTableNumber.ForeColor = Color.Black;
            lblTableNumber.Location = new Point(0, 0);
            lblTableNumber.Name = "lblTableNumber";
            lblTableNumber.Size = new Size(100, 100);
            lblTableNumber.TabIndex = 0;
            lblTableNumber.Text = "1";
            lblTableNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTableNumber);
            Name = "TableUserControl";
            Size = new Size(100, 100);
            ResumeLayout(false);
        }

        private Label lblTableNumber;
    }
}
