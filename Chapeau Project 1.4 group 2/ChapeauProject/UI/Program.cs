
using Model;
using Service;
using DAL;
using UI.PaymentSystem;
using UI.OrderView;
using System.Drawing.Text;
using System.Windows.Forms;
using UI.Login;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            OrderDAL orderDAL = new OrderDAL();


            Application.Run(new BillDetails(orderDAL.GetStatusOrderByTableId(2,Status.served)));
            //Application.Run(new LoginForm());
        }

        public static void WindowSwitcher(Form oldForm, Form newForm)
        {
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = oldForm.Location;
          
            oldForm.Hide();
            newForm.Closed += (s, args) => oldForm.Close();

            newForm.Show();
        }
    }
}