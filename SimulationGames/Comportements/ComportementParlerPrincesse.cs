using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames.Comportements
{
    public class ComportementParlerPrincesse : ComportementEmettreUnSon
    {
        public override string EmmettreSon()
        {
            return "Je parle comme une princesse <3";
        }
    }
}
