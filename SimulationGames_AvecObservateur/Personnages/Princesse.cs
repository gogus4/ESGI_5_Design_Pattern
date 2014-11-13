using SimulationGames_AvecObservateur.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur.Personnages
{
    public class Princesse : Personnage
    {
        public Princesse(Organisation unEtatMajor,string unNom)
            : base(null, unNom)
        {
            ComportementCombat = null;
            ComportementEmetreUnSon = new ComportementParlerPrincesse();
        }

        public override string Afficher()
        {
            return string.Format("- Princesse {0} | Etat : {1}", Nom, EtatFonctionnement);
        }

        public override string SeDeplacer()
        {
            return "Je ne me deplace pas, on me porte !";
        }
    }
}
