using SimulationGames_AvecObservateur.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur.Personnages
{
    public class Fantassin : Personnage
    {
        public Fantassin(Organisation unEtatMajor,string unNom)
            : base(unEtatMajor, unNom)
        {
            ComportementCombat = new ComportementAPiedAvecHache();
            ComportementEmetreUnSon = new ComportementCrier();
        }

        public override string Afficher()
        {
            return string.Format("- Fantassin {0} | Etat : {1}", Nom, EtatFonctionnement);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace a pied avec une hâche !";
        }
    }
}
