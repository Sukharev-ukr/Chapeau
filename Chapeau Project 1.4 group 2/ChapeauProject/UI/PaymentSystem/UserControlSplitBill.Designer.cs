namespace UI.PaymentSystem
{
    partial class UserControlSplitBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBoxSplit = new TextBox();
            labelPart = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(229, 15);
            button1.Name = "button1";
            button1.Size = new Size(132, 32);
            button1.TabIndex = 0;
            button1.Text = "Split by portion";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBoxSplit
            // 
            textBoxSplit.Location = new Point(103, 19);
            textBoxSplit.Name = "textBoxSplit";
            textBoxSplit.Size = new Size(100, 23);
            textBoxSplit.TabIndex = 1;
            // 
            // labelPart
            // 
            labelPart.AutoSize = true;
            labelPart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPart.Location = new Point(22, 15);
            labelPart.Name = "labelPart";
            labelPart.Size = new Size(65, 28);
            labelPart.TabIndex = 2;
            labelPart.Text = "label1";
            // 
            // UserControlSplitBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelPart);
            Controls.Add(textBoxSplit);
            Controls.Add(button1);
            Name = "UserControlSplitBill";
            Size = new Size(469, 58);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxSplit;
        private Label labelPart;
    }
}
