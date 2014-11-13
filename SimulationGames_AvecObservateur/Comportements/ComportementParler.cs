using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur.Comportements
{
    class ComportementParler : ComportementEmettreUnSon
    {
        public override string EmmettreSon()
        {
            return "Je parle ...";
        }
    }
}
