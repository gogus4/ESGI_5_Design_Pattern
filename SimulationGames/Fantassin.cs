using SimulationGames.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames
{
    public class Fantassin : Personnage
    {
        public Fantassin(string unNom)
            : base(unNom)
        {
            ComportementCombat = new ComportementAPiedAvecHache();
            ComportementEmetreUnSon = new ComportementCrier();
        }

        public override string Afficher()
        {
            return string.Format("Je suis un fantassin, ComportementCombat : {0} | ComportementEmettreUnSon : {1}",ComportementCombat.GetType().Name,ComportementEmetreUnSon.GetType().Name);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace a pied avec une hâche !";
        }
    }
}
