using SimulationGames_AvecComportement.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecComportement.Personnages
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
            return string.Format("Archer {0} | ComportementCombat : {1} | ComportementEmettreUnSon : {2}",Nom,ComportementCombat.GetType().Name,ComportementEmetreUnSon.GetType().Name);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace avec un arc !";
        }
    }
}