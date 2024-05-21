namespace View
{
    partial class KitchenAndBar
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
            btnKitchen = new Button();
            btnBar = new Button();
            pnlLogin = new Panel();
            pnlKitchen = new Panel();
            pnlBarOrders = new Panel();
            listViewBarOrders = new ListView();
            listViewKitchenOrders = new ListView();
            pnlLogin.SuspendLayout();
            pnlKitchen.SuspendLayout();
            pnlBarOrders.SuspendLayout();
            SuspendLayout();
            // 
            // btnKitchen
            // 
            btnKitchen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnKitchen.Location = new Point(179, 156);
            btnKitchen.Name = "btnKitchen";
            btnKitchen.Size = new Size(231, 98);
            btnKitchen.TabIndex = 1;
            btnKitchen.Text = "Kitchen";
            btnKitchen.UseVisualStyleBackColor = true;
            // 
            // btnBar
            // 
            btnBar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBar.Location = new Point(515, 156);
            btnBar.Name = "btnBar";
            btnBar.Size = new Size(231, 98);
            btnBar.TabIndex = 2;
            btnBar.Text = "Bar";
            btnBar.UseVisualStyleBackColor = true;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnKitchen);
            pnlLogin.Controls.Add(btnBar);
            pnlLogin.Location = new Point(12, 8);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(942, 430);
            pnlLogin.TabIndex = 3;
            // 
            // pnlKitchen
            // 
            pnlKitchen.Controls.Add(pnlBarOrders);
            pnlKitchen.Controls.Add(listViewKitchenOrders);
            pnlKitchen.Location = new Point(12, 8);
            pnlKitchen.Name = "pnlKitchen";
            pnlKitchen.Size = new Size(942, 430);
            pnlKitchen.TabIndex = 3;
            // 
            // pnlBarOrders
            // 
            pnlBarOrders.Controls.Add(listViewBarOrders);
            pnlBarOrders.Location = new Point(0, 0);
            pnlBarOrders.Name = "pnlBarOrders";
            pnlBarOrders.Size = new Size(950, 438);
            pnlBarOrders.TabIndex = 4;
            // 
            // listViewBarOrders
            // 
            listViewBarOrders.Location = new Point(36, 49);
            listViewBarOrders.Name = "listViewBarOrders";
            listViewBarOrders.Size = new Size(864, 330);
            listViewBarOrders.TabIndex = 0;
            listViewBarOrders.UseCompatibleStateImageBehavior = false;
            // 
            // listViewKitchenOrders
            // 
            listViewKitchenOrders.Location = new Point(36, 49);
            listViewKitchenOrders.Name = "listViewKitchenOrders";
            listViewKitchenOrders.Size = new Size(864, 330);
            listViewKitchenOrders.TabIndex = 0;
            listViewKitchenOrders.UseCompatibleStateImageBehavior = false;
            // 
            // KitchenAndBar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 490);
            Controls.Add(pnlKitchen);
            Controls.Add(pnlLogin);
            Name = "KitchenAndBar";
            Text = "Form2";
            pnlLogin.ResumeLayout(false);
            pnlKitchen.ResumeLayout(false);
            pnlBarOrders.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnKitchen;
        private Button btnBar;
        private Panel pnlLogin;
        private Panel pnlKitchen;
        private ListView listViewKitchenOrders;
        private Panel pnlBarOrders;
        private ListView listViewBarOrders;
    }
}