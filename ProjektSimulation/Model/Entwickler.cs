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

        public async Task Arbeiten(IEnumerable<Projekt> projekte)
        {
            SiAuto.Main.EnterThread("Entwickler.Arbeiten-Task - "+Name);
            while (!IstErschoepft)
            {
                foreach (Projekt projekt in projekte)
                {
                    if (!projekt.IstInBearbeitung)
                    {
                        projekt.IstInBearbeitung = true;
                        await Planen(projekt);
                        await Entwickeln(projekt);
                        projekt.IstInBearbeitung = false;
                    }
                }
            }
            SiAuto.Main.LeaveThread("Entwickler.Arbeiten-Task - "+Name);
        }

        private async Task Planen(Projekt projekt)
        {
            //SiAuto.Main.EnterThread("Entwickler.Planen-Task");
            SiAuto.Main.EnterMethod(this, "Planen - "+Name);

            if ((projekt.Status == ProjektStatus.Definition) 
                || (projekt.Status == ProjektStatus.Test))
            {
                projekt.Status = ProjektStatus.Planung;
                projekt.ZuletztAktiverEntwickler = Name;
                AktuelleAufgabe = Beschaeftigung.Planen;

                // Eigentlich kann der Entwickler gar nicht planen ;-)
                await Task.Delay(TimeSpan.FromSeconds(5));

                SiAuto.Main.LogObject("Entwickler " + Name + " hat das folgende Projekt geplant", projekt);
                AktuelleAufgabe = Beschaeftigung.Lernen;
            }

            SiAuto.Main.LeaveMethod(this, "Planen - "+Name);
            //SiAuto.Main.LeaveThread("Entwickler.Planen-Task");
        }

        private async Task Entwickeln(Projekt projekt)
        {
            //SiAuto.Main.EnterThread("Entwickler.Entwickeln-Task");
            SiAuto.Main.EnterMethod(this, "Entwickeln - "+Name);

            if (projekt.Status == ProjektStatus.Planung)
            {
                projekt.Status = ProjektStatus.Entwicklung;
                AktuelleAufgabe = Beschaeftigung.Entwickeln;
                projekt.ZuletztAktiverEntwickler = Name;

                await Task.Delay(TimeSpan.FromSeconds(15));

                SiAuto.Main.LogObject("Entwickler " + Name + " hat das folgende Projekt entwickelt", projekt);
                AktuelleAufgabe = Beschaeftigung.Lernen;
            }

            SiAuto.Main.LeaveMethod(this, "Entwickeln - "+Name);
            //SiAuto.Main.LeaveThread("Entwickler.Entwickeln-Task");
        }
    }
}
