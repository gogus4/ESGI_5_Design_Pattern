using SimulationGames_AvecObservateur.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur.Personnages
{
    public class Chevalier : Personnage
    {
        public Chevalier(Organisation unEtatMajor,string unNom)
            : base(unEtatMajor, unNom)
        {
            ComportementCombat = new ComportementACheval();
            ComportementEmetreUnSon = new ComportementCrier();
        }

        public override string Afficher()
        {
            return string.Format("- Chevalier {0} | Etat : {1}", Nom, EtatFonctionnement);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace rapidement avec un cheval s'il n'est pas mort !";
        }
    }
}