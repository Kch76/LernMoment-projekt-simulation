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

    public class Entwickler
    {
        public string Name { get; }
        public Beschaeftigung AktuelleAufgabe { get; private set; }

        public Entwickler(string name)
        {
            Name = name;
            AktuelleAufgabe = Beschaeftigung.Lernen;
        }

        public async Task Arbeiten(IEnumerable<Projekt> projekte)
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

        private async Task Planen(Projekt projekt)
        {
            if ((projekt.Status == ProjektStatus.Definition) 
                || (projekt.Status == ProjektStatus.Test))
            {
                projekt.Status = ProjektStatus.Planung;
                AktuelleAufgabe = Beschaeftigung.Planen;
                await Task.Delay(TimeSpan.FromSeconds(5));
                AktuelleAufgabe = Beschaeftigung.Lernen;
            }
        }

        private async Task Entwickeln(Projekt projekt)
        {
            if (projekt.Status == ProjektStatus.Planung)
            {
                projekt.Status = ProjektStatus.Entwicklung;
                AktuelleAufgabe = Beschaeftigung.Entwickeln;
                await Task.Delay(TimeSpan.FromSeconds(15));
                AktuelleAufgabe = Beschaeftigung.Lernen;
            }
        }
    }
}
