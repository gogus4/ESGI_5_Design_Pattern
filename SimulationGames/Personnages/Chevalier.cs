using SimulationGames_AvecComportement.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecComportement.Personnages
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
            return string.Format("Chevalier {0} | ComportementCombat : {1} | ComportementEmettreUnSon : {2}",Nom,ComportementCombat.GetType().Name,ComportementEmetreUnSon.GetType().Name);
        }

        public override string SeDeplacer()
        {
            return "Je me deplace rapidement avec un cheval s'il n'est pas mort !";
        }
    }
}