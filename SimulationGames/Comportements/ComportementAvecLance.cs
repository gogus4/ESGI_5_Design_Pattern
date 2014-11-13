using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecComportement.Comportements
{
    class ComportementAvecLance : ComportementCombat
    {
        public override string Combattre()
        {
            return "Je combat avec une lance !";
        }
    }
}
