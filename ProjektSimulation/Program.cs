using Gurock.SmartInspect;
using System;
using System.Windows.Forms;

namespace ProjektSimulation
{
    static class Program
    {
        private const string debugConfigurationFileName = "LoggingConfig\\ProjektSimulation-Debug-LogConfig.sic";
        private const string releaseConfigurationFileName = "LoggingConfig\\ProjektSimulation-Release-LogConfig.sic";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Logging mit SmartInspect vorbereiten
#if DEBUG
            SiAuto.Si.LoadConfiguration(debugConfigurationFileName);
            var timer = new ConfigurationTimer(SiAuto.Si, debugConfigurationFileName, 60000);
#else
            SiAuto.Si.LoadConfiguration(releaseConfigurationFileName);
            var timer = new ConfigurationTimer(SiAuto.Si, releaseConfigurationFileName, 60000);
#endif

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