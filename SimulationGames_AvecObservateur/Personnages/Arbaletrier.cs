using SimulationGames_AvecObservateur.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur.Personnages
{
    public class Arbaletrier : Personnage
    {
        public Arbaletrier(Organisation unEtatMajor,string unNom)
            : base(unEtatMajor, unNom)
        {
            ComportementCombat = new ComportementAvecArbalete();
            ComportementEmetreUnSon = new ComportementParler();
        }

        public override string Afficher()
        {
            return string.Format("- Arbaletrier {0} | Etat : {1}", Nom,EtatFonctionnement);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace avec une arbalete !";
        }
    }
}