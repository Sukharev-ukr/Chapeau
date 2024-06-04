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
            buttonSplitByPorion.Location = new Point(229, 4);
            buttonSplitByPorion.Name = "buttonSplitByPorion";
            buttonSplitByPorion.Size = new Size(132, 32);
            buttonSplitByPorion.TabIndex = 0;
            buttonSplitByPorion.Text = "Split by portion";
            buttonSplitByPorion.UseVisualStyleBackColor = false;
            buttonSplitByPorion.Click += buttonSplitByPorion_Click;
            // 
            // textBoxSplit
            // 
            textBoxSplit.Location = new Point(103, 8);
            textBoxSplit.Name = "textBoxSplit";
            textBoxSplit.Size = new Size(100, 23);
            textBoxSplit.TabIndex = 1;
            // 
            // labelPart
            // 
            labelPart.AutoSize = true;
            labelPart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPart.Location = new Point(22, 4);
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
            Size = new Size(469, 47);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSplitByPorion;
        private TextBox textBoxSplit;
        private Label labelPart;
    }
}
