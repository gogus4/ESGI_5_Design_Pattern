﻿using SimulationGames.Comportement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames.Comportements
{
    class ComportementAPiedAvecHache : ComportementCombat
    {
        public override string Combattre()
        {
            return "Je combat à pied mais avec une hâche !";
        }
    }
}
