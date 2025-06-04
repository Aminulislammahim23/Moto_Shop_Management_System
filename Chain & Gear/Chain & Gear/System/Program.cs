using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chain___Gear.Admin;

namespace Chain___Gear
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
            Application.SetCompatibleTextRenderingDefault(false);
            // Show the splash form
            Splash splash = new Splash();
            splash.Show();
            splash.Refresh();

            // Simulate loading time (e.g., 1 seconds)
            Thread.Sleep(1000);

            // Close splash and run main form
            splash.Close();
            Application.Run(new Login());
        }
    }
}
