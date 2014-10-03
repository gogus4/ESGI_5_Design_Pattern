using SimulationGames.Comportement;
using SimulationGames.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames
{
    public abstract class Personnage
    {
        public string Nom { get; set; }
        public ComportementCombat ComportementCombat { get; set; }
        public ComportementEmettreUnSon ComportementEmetreUnSon { get; set; }

        public abstract string Afficher();
        public abstract string SeDeplacer();

        public Personnage(string sonNom)
        {
            Nom = sonNom;
        }

        private string EmettreUnSon()
        {
            if (ComportementEmetreUnSon != null)
                return ComportementEmetreUnSon.EmmettreSon();

            return "Je suis muet.";
        }

        private string Combattre()
        {
            if(ComportementCombat != null)
                return ComportementCombat.Combattre();

            return "Je ne combat pas.";
        }
    }
}
