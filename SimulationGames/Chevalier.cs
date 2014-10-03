using SimulationGames.Comportement;
using SimulationGames.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames
{
    public class Chevalier : Personnage
    {
        public Chevalier(string unNom)
            : base(unNom)
        {
            ComportementCombat = new ComportementACheval();
            ComportementEmetreUnSon = new ComportementCrier();
        }

        public override string Afficher()
        {
            return string.Format("Je suis un chevalier, ComportementCombat : {0} | ComportementEmettreUnSon : {1}",ComportementCombat.GetType().Name,ComportementEmetreUnSon.GetType().Name);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace rapidement avec un cheval s'il n'est pas mort !";
        }
    }
}
