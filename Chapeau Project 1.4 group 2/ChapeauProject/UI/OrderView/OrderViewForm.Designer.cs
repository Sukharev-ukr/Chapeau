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
            ucOrderView = new UCOrderView();
            pnlOrderView.SuspendLayout();
            SuspendLayout();
            // 
            // btnLunch
            // 
            btnLunch.Location = new Point(12, 12);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(261, 172);
            btnLunch.TabIndex = 1;
            btnLunch.Text = "Lunch";
            btnLunch.UseVisualStyleBackColor = true;
            btnLunch.Click += btnLunch_Click;
            // 
            // btnDiner
            // 
            btnDiner.Location = new Point(279, 12);
            btnDiner.Name = "btnDiner";
            btnDiner.Size = new Size(261, 172);
            btnDiner.TabIndex = 2;
            btnDiner.Text = "Diner";
            btnDiner.UseVisualStyleBackColor = true;
            btnDiner.Click += btnDiner_Click;
            // 
            // btnDrinks
            // 
            btnDrinks.Location = new Point(546, 12);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(254, 172);
            btnDrinks.TabIndex = 3;
            btnDrinks.Text = "Drinks";
            btnDrinks.UseVisualStyleBackColor = true;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // pnlOrderView
            // 
            pnlOrderView.Controls.Add(ucOrderView);
            pnlOrderView.Location = new Point(12, 190);
            pnlOrderView.Name = "pnlOrderView";
            pnlOrderView.Size = new Size(788, 642);
            pnlOrderView.TabIndex = 4;
            // 
            // ucOrderView
            // 
            ucOrderView.BackColor = Color.White;
            ucOrderView.Item = null;
            ucOrderView.Location = new Point(3, 3);
            ucOrderView.Name = "ucOrderView";
            ucOrderView.Size = new Size(782, 66);
            ucOrderView.TabIndex = 1;
            // 
            // OrderViewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 223);
            ClientSize = new Size(812, 844);
            Controls.Add(btnDrinks);
            Controls.Add(btnDiner);
            Controls.Add(btnLunch);
            Controls.Add(pnlOrderView);
            Name = "OrderViewForm";
            Text = "Form1";
            Load += OrderView_Load;
            pnlOrderView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnLunch;
        private Button btnDiner;
        private Button btnDrinks;
        private Panel pnlOrderView;
        private UCOrderView ucOrderView;
    }
}