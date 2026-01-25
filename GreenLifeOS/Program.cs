using GreenLifeOS.UI;
using System;
using System.Windows.Forms;

namespace GreenLifeOS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new AdminMainForm());
            //Application.Run(new CustomerMainForm());
            Application.Run(new LoginForm());

        }
    }
}
