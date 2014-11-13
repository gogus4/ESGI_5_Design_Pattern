using SimulationGames_AvecObservateur.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur.Personnages
{
    public class Lancier : Personnage
    {
        public Lancier(Organisation unEtatMajor,string unNom)
            : base(unEtatMajor, unNom)
        {
            ComportementCombat = new ComportementAvecLance();
            ComportementEmetreUnSon = new ComportementParler();
        }

        public override string Afficher()
        {
            return string.Format("- Lancier {0} | Etat : {1}", Nom, EtatFonctionnement);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace avec une lance !";
        }
    }
}