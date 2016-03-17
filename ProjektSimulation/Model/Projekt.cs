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
                    await Task.Delay(TimeSpan.FromSeconds(10));
                    break;
                case ProjektStatus.Test:
                    // Nach dem Test kommt die nächste Iteration. Diese muss auch
                    // geplant werden, aber das dauert jetzt nicht mehr so lange.
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
    }
}
