using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSimulation.Model
{
    /// <summary>
    /// Verwaltet alle Projekte und stellt sicher, dass immer nur ein Projekt
    /// zur gleichen Zeit bearbeitet werden kann.
    /// </summary>
    /// <remarks>
    /// Das Dashboard ist wie ein Whiteboard an dem alle Projekte hängen, die
    /// momentan nicht bearbeitet werden. Hier hin können Entwickler kommen, wenn
    /// sie ein Projekt bearbeiten wollen. Sie nehmen es vom Dashboard so lange
    /// sie es bearbeiten und bringen es danach wieder zurück.
    /// </remarks>
    public class ProjektDashboard
    {
        private ConcurrentQueue<Projekt> zuBearbeitendeProjekte;

        public ProjektDashboard(IList<Projekt> projekte)
        {
            ProjektListe = new BindingList<Projekt>(projekte);
            zuBearbeitendeProjekte = new ConcurrentQueue<Projekt>(projekte);
        }

        /// <summary>
        /// Die komplette Liste aller Projekte die am Dashboard verfügbar sein
        /// sollten (d.h. unabhängig davon ob sie gerade bearbeitet werden oder nicht).
        /// </summary>
        public BindingList<Projekt> ProjektListe { get; private set; }

        /// <summary>
        /// Gibt das nächste verfügbare Projekt zurück, welches bearbeitet werden
        /// kann. Sollten bereits alle Projekte in der Bearbeitung sein, wird solange verzögert, 
        /// bis ein Projekt ansteht um bearbeitet werden zu können.
        /// </summary>
        /// <returns>Projekt welches bearbeitet werden kann.</returns>
        public async Task<Projekt> CheckoutZumBearbeitenAsync()
        {
            Projekt projektZumBearbeiten = null;

            while (!zuBearbeitendeProjekte.TryDequeue(out projektZumBearbeiten))
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            projektZumBearbeiten.IstInBearbeitung = true;

            return projektZumBearbeiten;
        }

        /// <summary>
        /// Sobald ein Projekt bearbeitet ist, muss es über diese Methode wieder am Dashboard
        /// eingecheckt werden um weiter- bzw. nochmals bearbeitet zu werden.
        /// </summary>
        /// <param name="bearbeitetesProjekt">Das Projekt welches (teilweise) bearbeitet wurde.</param>
        public void CheckinNachBearbeitung(Projekt bearbeitetesProjekt)
        {
            bearbeitetesProjekt.IstInBearbeitung = false;
            zuBearbeitendeProjekte.Enqueue(bearbeitetesProjekt);
        }
    }
}
