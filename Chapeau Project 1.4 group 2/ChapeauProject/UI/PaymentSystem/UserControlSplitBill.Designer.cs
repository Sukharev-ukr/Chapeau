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
            buttonSplitByPorion = new Button();
            textBoxSplit = new TextBox();
            labelPart = new Label();
            SuspendLayout();
            // 
            // buttonSplitByPorion
            // 
            buttonSplitByPorion.BackColor = Color.Black;
            buttonSplitByPorion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSplitByPorion.ForeColor = Color.White;
            buttonSplitByPorion.Location = new Point(208, 3);
            buttonSplitByPorion.Name = "buttonSplitByPorion";
            buttonSplitByPorion.Size = new Size(141, 32);
            buttonSplitByPorion.TabIndex = 0;
            buttonSplitByPorion.Text = "Edit split";
            buttonSplitByPorion.UseVisualStyleBackColor = false;
            buttonSplitByPorion.Click += buttonSplitByPorion_Click;
            // 
            // textBoxSplit
            // 
            textBoxSplit.Location = new Point(91, 7);
            textBoxSplit.Name = "textBoxSplit";
            textBoxSplit.ReadOnly = true;
            textBoxSplit.Size = new Size(100, 23);
            textBoxSplit.TabIndex = 1;
            // 
            // labelPart
            // 
            labelPart.AutoSize = true;
            labelPart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPart.Location = new Point(10, 3);
            labelPart.Name = "labelPart";
            labelPart.Size = new Size(46, 28);
            labelPart.TabIndex = 2;
            labelPart.Text = "Part";
            // 
            // UserControlSplitBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelPart);
            Controls.Add(textBoxSplit);
            Controls.Add(buttonSplitByPorion);
            Name = "UserControlSplitBill";
            Size = new Size(351, 42);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSplitByPorion;
        private TextBox textBoxSplit;
        private Label labelPart;
    }
}
