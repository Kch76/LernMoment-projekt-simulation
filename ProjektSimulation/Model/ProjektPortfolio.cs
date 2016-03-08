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
            projekte.Add(new Projekt("Docker"));
            projekte.Add(new Projekt("Git"));
            projekte.Add(new Projekt("GitHub"));
            projekte.Add(new Projekt("WPF"));
            projekte.Add(new Projekt("MVVM"));
            projekte.Add(new Projekt("MVC"));
            projekte.Add(new Projekt("XamarinStudio"));
            projekte.Add(new Projekt("LernMoment"));
            projekte.Add(new Projekt("Jekyll"));
            projekte.Add(new Projekt("Markdown"));
            projekte.Add(new Projekt("CSS"));
            projekte.Add(new Projekt("HTML"));
            projekte.Add(new Projekt("JavaScript"));
            projekte.Add(new Projekt("Node.JS"));
            projekte.Add(new Projekt("Awesomium"));
            projekte.Add(new Projekt("OpenPop"));
            projekte.Add(new Projekt("UlitmateToolkit"));

            return projekte;
        }
    }
}
