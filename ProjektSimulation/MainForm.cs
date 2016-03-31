using Gurock.SmartInspect;
using ProjektSimulation.Model;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektSimulation
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private BindingList<Entwickler> aktuellesTeam;
        private ProjektDashboard dashboard;
        private CancellationTokenSource cts;

        public MainForm()
        {
            InitializeComponent();

            aktuellesTeam = new BindingList<Entwickler>(EntwicklerPool.HoleEntwicklerTeam());
            dashboard = new ProjektDashboard(ProjektPortfolio.HoleAktuelleProjekte());
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.gridEntwickler.BestFitColumns();
            this.gridEntwickler.DataSource = aktuellesTeam;

            this.gridProjekte.BestFitColumns();
            this.gridProjekte.DataSource = dashboard.ProjektListe;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            //SiAuto.Main.EnterThread("btnStart_Click");
            SiAuto.Main.EnterMethod(this, "btnStart_Click");

            // später wollen wir die laufdenen Tasks beenden lassen.
            cts = new CancellationTokenSource();

            foreach (Entwickler entwickler in aktuellesTeam)
            {
                SiAuto.Main.LogMessage("Schicke Entwickler: {0} an die Arbeit!", entwickler.Name);
                entwickler.Arbeiten(dashboard, cts.Token);
                await Task.Delay(TimeSpan.FromSeconds(10));
            }
            SiAuto.Main.LeaveMethod(this, "btnStart_Click");
            //SiAuto.Main.LeaveThread("btnStart_Click");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Die laufenden Tasks beenden
            if (cts != null)
            {
                cts.Cancel();
            }

            // Alle Entwickler zum Ausruhen schicken
            foreach (Entwickler entwickler in aktuellesTeam)
            {
                entwickler.IstErschoepft = true;
            }

            
        }
    }
}
