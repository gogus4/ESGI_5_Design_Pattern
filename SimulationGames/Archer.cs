using SimulationGames.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames
{
    public class Archer : Personnage
    {
        public Archer(string unNom) : base(unNom)
        {
            ComportementCombat = new ComportementAvecArc();
            ComportementEmetreUnSon = new ComportementParler();
        }

        public override string Afficher()
        {
            return string.Format("Je suis un archer, ComportementCombat : {0} | ComportementEmettreUnSon : {1}",ComportementCombat.GetType().Name,ComportementEmetreUnSon.GetType().Name);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace avec un arc !";
        }
    }
}
