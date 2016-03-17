using Gurock.SmartInspect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSimulation.Model
{
    public enum Beschaeftigung
    {
        Lernen,
        Planen,
        Entwickeln
    }

    public class Entwickler : NotifyPropertyChangeModelBase
    {
        public string Name { get; }

        private Beschaeftigung aktuelleAufgabe;
        public Beschaeftigung AktuelleAufgabe
        {
            get { return aktuelleAufgabe; }
            private set
            {
                if (value != aktuelleAufgabe)
                {
                    aktuelleAufgabe = value;
                    RaisePropertyChanged("AktuelleAufgabe");
                }
            }
        }

        private bool istErschoepft;
        public bool IstErschoepft
        {
            get { return istErschoepft; }
            set
            {
                if (value != istErschoepft)
                {
                    istErschoepft = value;
                    RaisePropertyChanged("IstErschoepft");
                }
            }
        }

        public Entwickler(string name)
        {
            Name = name;
            AktuelleAufgabe = Beschaeftigung.Lernen;
            IstErschoepft = false;
        }

        public async Task Arbeiten(ProjektDashboard dashboard)
        {
            SiAuto.Main.EnterThread("Entwickler.Arbeiten-Task - "+Name);
            Projekt aktuellesProjekt;

            while (!IstErschoepft)
            {
                aktuellesProjekt = await dashboard.CheckoutZumBearbeitenAsync();
                await Planen(aktuellesProjekt);
                await Entwickeln(aktuellesProjekt);
                dashboard.CheckinNachBearbeitung(aktuellesProjekt);
            }
            SiAuto.Main.LeaveThread("Entwickler.Arbeiten-Task - "+Name);
        }

        private async Task Planen(Projekt projekt)
        {
            //SiAuto.Main.EnterThread("Entwickler.Planen-Task");
            SiAuto.Main.EnterMethod(this, "Planen - "+Name);

            AktuelleAufgabe = Beschaeftigung.Planen;
            await projekt.Planen(Name);
            AktuelleAufgabe = Beschaeftigung.Lernen;

            SiAuto.Main.LeaveMethod(this, "Planen - "+Name);
            //SiAuto.Main.LeaveThread("Entwickler.Planen-Task");
        }

        private async Task Entwickeln(Projekt projekt)
        {
            //SiAuto.Main.EnterThread("Entwickler.Entwickeln-Task");
            SiAuto.Main.EnterMethod(this, "Entwickeln - "+Name);

            AktuelleAufgabe = Beschaeftigung.Entwickeln;
            await projekt.Entwickeln(Name);
            AktuelleAufgabe = Beschaeftigung.Lernen;

            SiAuto.Main.LeaveMethod(this, "Entwickeln - "+Name);
            //SiAuto.Main.LeaveThread("Entwickler.Entwickeln-Task");
        }
    }
}
