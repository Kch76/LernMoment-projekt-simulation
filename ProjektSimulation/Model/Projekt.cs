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

    public class Projekt
    {
        public string Name { get; }
        public ProjektStatus Status { get; set; }

        public Projekt(string name)
        {
            Name = name;
            Status = ProjektStatus.Definition;
        }

    }
}
