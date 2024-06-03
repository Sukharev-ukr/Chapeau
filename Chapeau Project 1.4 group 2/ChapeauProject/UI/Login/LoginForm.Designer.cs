namespace UI
{
    partial class LoginForm
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
            Top_Login_bar = new Panel();
            Login_Bottom_Panel = new Panel();
            Login_Welcome = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // Top_Login_bar
            // 
            Top_Login_bar.BackColor = Color.FromArgb(117, 30, 55);
            Top_Login_bar.Location = new Point(0, 1);
            Top_Login_bar.Margin = new Padding(2, 3, 2, 3);
            Top_Login_bar.Name = "Top_Login_bar";
            Top_Login_bar.Size = new Size(819, 65);
            Top_Login_bar.TabIndex = 0;
            // 
            // Login_Bottom_Panel
            // 
            Login_Bottom_Panel.BackColor = Color.FromArgb(117, 30, 55);
            Login_Bottom_Panel.Location = new Point(0, 1091);
            Login_Bottom_Panel.Name = "Login_Bottom_Panel";
            Login_Bottom_Panel.Size = new Size(822, 69);
            Login_Bottom_Panel.TabIndex = 1;
            // 
            // Login_Welcome
            // 
            Login_Welcome.AutoSize = true;
            Login_Welcome.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Login_Welcome.Location = new Point(236, 282);
            Login_Welcome.Name = "Login_Welcome";
            Login_Welcome.Size = new Size(352, 32);
            Login_Welcome.TabIndex = 2;
            Login_Welcome.Text = "Welcome back! Please, login!";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(249, 389);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(330, 56);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(249, 532);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(330, 56);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(249, 623);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 56);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(817, 749);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(Login_Welcome);
            Controls.Add(Login_Bottom_Panel);
            Controls.Add(Top_Login_bar);
            Margin = new Padding(2, 3, 2, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Top_Login_bar;
        private Panel Login_Bottom_Panel;
        private Label Login_Welcome;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}