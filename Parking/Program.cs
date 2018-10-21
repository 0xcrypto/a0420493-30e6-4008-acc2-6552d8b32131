using System;
using System.Windows.Forms;
using Parking.Exit.Forms;

namespace Parking.Exit
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MPS());
        }
    }
}
