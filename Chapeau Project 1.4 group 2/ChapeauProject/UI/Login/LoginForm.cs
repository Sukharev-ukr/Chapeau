using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class LoginForm : Form
    {
        private StaffService staffService;
        public LoginForm()
        {
            InitializeComponent();
            staffService = new StaffService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            StaffService staffService = new StaffService();
            if (staffService.ValidateStaffCredentials(username, password))
            {
                // Login successful
                MessageBox.Show("Login successful!");
                // Proceed to the next form or main application
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
