using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSimulation.Model
{
    public class ProjektPortfolio
    {
        public static IList<Projekt> HoleAktuelleProjekte()
        {
            List<Projekt> projekte = new List<Projekt>();

            projekte.Add(new Projekt("Taschenrechner"));
            projekte.Add(new Projekt("Syntax"));
            projekte.Add(new Projekt("Mail-Client"));
            projekte.Add(new Projekt("Webbrowser"));

            return projekte;
        }
    }
}
