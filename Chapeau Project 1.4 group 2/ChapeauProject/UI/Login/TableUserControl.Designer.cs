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
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableNumber.Font = new System.Drawing.Font("Roboto", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableNumber.ForeColor = System.Drawing.Color.Black;
            this.lblTableNumber.Location = new System.Drawing.Point(0, 0);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(100, 100);
            this.lblTableNumber.TabIndex = 0;
            this.lblTableNumber.Text = "1";
            this.lblTableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTableNumber);
            this.Name = "TableUserControl";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTableNumber;
    }
}
