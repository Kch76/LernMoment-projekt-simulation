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
            set
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
            set
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

    }
}
