using SimulationGames_AvecComportement.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecComportement.Personnages
{
    public class Spadassin : Personnage
    {
        public Spadassin(string unNom)
            : base(unNom)
        {
            ComportementCombat = new ComportementAvecEpee();
            ComportementEmetreUnSon = new ComportementParler();
        }

        public override string Afficher()
        {
            return string.Format("Spadassin {0} | ComportementCombat : {1} | ComportementEmettreUnSon : {2}", Nom, ComportementCombat.GetType().Name, ComportementEmetreUnSon.GetType().Name);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace avec une epee !";
        }
    }
}