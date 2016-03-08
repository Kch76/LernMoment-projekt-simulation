using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSimulation.Model
{
    public class EntwicklerPool
    {
        public static IList<Entwickler> HoleEntwicklerTeam()
        {
            List<Entwickler> team = new List<Entwickler>();

            team.Add(new Entwickler("Thomas"));
            team.Add(new Entwickler("Michael"));
            team.Add(new Entwickler("Andreas"));
            team.Add(new Entwickler("Michi"));

            return team;
        }
    }
}
