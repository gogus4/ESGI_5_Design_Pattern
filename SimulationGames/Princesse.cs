using SimulationGames.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames
{
    public class Princesse : Personnage
    {
        public Princesse(string unNom)
            : base(unNom)
        {
            ComportementCombat = null;
            ComportementEmetreUnSon = new ComportementParlerPrincesse();
        }

        public override string Afficher()
        {
            return string.Format("Je suis une princesse, ComportementEmettreUnSon : {0}",ComportementEmetreUnSon.GetType().Name);
        }

        public override string SeDeplacer()
        {
            return "Je ne me deplace pas, on me porte !";
        }
    }
}
