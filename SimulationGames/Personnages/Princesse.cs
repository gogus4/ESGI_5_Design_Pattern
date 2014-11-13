using SimulationGames_AvecComportement.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecComportement.Personnages
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
            return string.Format("Princesse {0} | ComportementEmettreUnSon : {1}",Nom,ComportementEmetreUnSon.GetType().Name);
        }

        public override string SeDeplacer()
        {
            return "Je ne me deplace pas, on me porte !";
        }
    }
}
