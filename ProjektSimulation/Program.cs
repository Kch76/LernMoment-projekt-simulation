using Gurock.SmartInspect;
using System;
using System.Windows.Forms;

namespace ProjektSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SiAuto.Si.Enabled = true;
            SiAuto.Main.EnterProcess("ProjektSimulation");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            SiAuto.Main.LeaveProcess("ProjektSimulation");
        }
    }
}