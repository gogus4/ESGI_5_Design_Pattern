using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur.Comportements
{
    class ComportementAvecArc : ComportementCombat
    {
        public override string Combattre()
        {
            return "Je combat avec un arc !";
        }
    }
}
