using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur.Comportements
{
    class ComportementAvecEpee : ComportementCombat
    {
        public override string Combattre()
        {
            return "Je combat avec une epee !";
        }
    }
}
