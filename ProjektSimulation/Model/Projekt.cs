using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSimulation.Model
{
    public enum ProjektStatus
    {
        Definition,
        Planung,
        Entwicklung,
        Test,
        Release
    }

    public class Projekt : NotifyPropertyChangeModelBase
    {
        public string Name { get; }

        private ProjektStatus status;
        public ProjektStatus Status
        {
            get { return status; }
            private set
            {
                if (value != status)
                {
                    status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }

        private bool istInBearbeitung;
        public bool IstInBearbeitung
        {
            get { return istInBearbeitung; }
            set
            {
                if (value != istInBearbeitung)
                {
                    istInBearbeitung = value;
                    RaisePropertyChanged("IstInBearbeitung");
                }
            }
        }

        private string zuletztAktiverEntwickler;
        public string ZuletztAktiverEntwickler
        {
            get { return zuletztAktiverEntwickler; }
            private set
            {
                if (value != zuletztAktiverEntwickler)
                {
                    zuletztAktiverEntwickler = value;
                    RaisePropertyChanged("ZuletztAktiverEntwickler");
                }
            }
        }

        public Projekt(string name)
        {
            Name = name;
            Status = ProjektStatus.Definition;
            ZuletztAktiverEntwickler = "Niemand";
        }

        public async Task Planen(string nameDesEntwicklers)
        {
            ZuletztAktiverEntwickler = nameDesEntwicklers;

            switch (Status)
            {
                case ProjektStatus.Definition:
                    // Projekt ist erst definiert und braucht die initiale Planung.
                    // Das dauert etwas länger ;-)!
                    Status = ProjektStatus.Planung;
                    await Task.Delay(TimeSpan.FromSeconds(10));
                    break;
                case ProjektStatus.Test:
                    // Nach dem Test kommt die nächste Iteration. Diese muss auch
                    // geplant werden, aber das dauert jetzt nicht mehr so lange.
                    Status = ProjektStatus.Planung;
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    break;
                case ProjektStatus.Planung:
                case ProjektStatus.Entwicklung:
                case ProjektStatus.Release:
                default:
                    string message = String.Format("Ein Projekt kann nicht im Status {0} geplant werden!", Status);
                    throw new InvalidOperationException(message);
            }

            return;
        }

        public async Task Entwickeln(string nameDesEntwicklers)
        {
            ZuletztAktiverEntwickler = nameDesEntwicklers;

            switch (Status)
            {
                case ProjektStatus.Planung:
                    // Nach der Planung kommt die Entwicklung. Das dauert schon etwas länger
                    Status = ProjektStatus.Entwicklung;
                    await Task.Delay(TimeSpan.FromSeconds(10));
                    break;
                case ProjektStatus.Definition:
                case ProjektStatus.Entwicklung:
                case ProjektStatus.Test:
                case ProjektStatus.Release:
                default:
                    string message = String.Format("Projekt hat Status: {0}. Es muss erst geplant werden!", Status);
                    throw new InvalidOperationException(message);
            }

            return;
        }

        public async Task Testen(string nameDesEntwicklers)
        {
            ZuletztAktiverEntwickler = nameDesEntwicklers;

            switch (Status)
            {
                case ProjektStatus.Entwicklung:
                    // Nach der Entwicklung kommt der Test. Das richtig schnell
                    Status = ProjektStatus.Test;
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    break;
                case ProjektStatus.Definition:
                case ProjektStatus.Planung:
                case ProjektStatus.Test:
                case ProjektStatus.Release:
                default:
                    string message = String.Format("Projekt hat Status: {0}. Es muss erst entwickelt werden!", Status);
                    throw new InvalidOperationException(message);
            }

            return;
        }
    }
}
