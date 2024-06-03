
using Model;
using Service;
using DAL;
using UI.PaymentSystem;
using System.Drawing.Text;
using System.Windows.Forms;

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
<<<<<<< Updated upstream
=======
            //Application.Run(new BillDetails(2));
>>>>>>> Stashed changes
            Application.Run(new BillDetails(2));
        }

        public static void WindowSwitcher(Form oldForm, Form newForm)
        {
            // this just hides the old forms, need something beter
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = oldForm.Location;



            oldForm.Hide();
            newForm.Closed += (s, args) => oldForm.Close();


            newForm.Show();
        }


    }
}