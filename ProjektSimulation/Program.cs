using Gurock.SmartInspect;
using System;
using System.Windows.Forms;

namespace ProjektSimulation
{
    static class Program
    {
        private const string configurationFileName = "LoggingConfig\\ProjektSimulation-Debug-LogConfig.sic";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Logging mit SmartInspect vorbereiten
            SiAuto.Si.LoadConfiguration(configurationFileName);
            var timer = new ConfigurationTimer(SiAuto.Si, configurationFileName, 60000);

            // Das eigentliche Ausführen der Anwendung
            SiAuto.Main.EnterProcess("ProjektSimulation");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            SiAuto.Main.LeaveProcess("ProjektSimulation");

            // Sicherstellen, dass alle Nachrichten aus dem Backlog per Tcp geschrieben werden 
            SiAuto.Main.LogError("Flush Backlog!");
            // Logging Komponente beenden.
            SiAuto.Si.Dispose();
        }
    }
}