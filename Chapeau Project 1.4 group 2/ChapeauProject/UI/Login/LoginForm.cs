using Model;
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
using UI.Login;
using View;

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

            Staff loggedUser = staffService.GetStaffByUsernameAndpassword(username, password);

            if (loggedUser != null)
            {
                getUIForStaff(loggedUser);
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void getUIForStaff(Staff staff)
        {
            switch (staff.Role)
            {
                case Role.Waiter:
                    OpenUI(new TableView_Form());
                    break;
                case Role.Chef:
                    OpenUI(new KitchenAndBar());
                    break;
                case Role.Bartender:
                    OpenUI(new KitchenAndBar());
                    break;
                
            }
        }



        private void OpenUI(Form newForm)
        {

            Form activeForm = ActiveForm;
            activeForm.Hide();

            newForm.ShowDialog();

            
            activeForm.Close();
        }
    }
}
