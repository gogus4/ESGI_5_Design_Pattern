using SimulationGames_AvecComportement.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecComportement.Personnages
{
    public abstract class Personnage
    {
        protected string Nom { get; set; }
        protected ComportementCombat ComportementCombat { get; set; }
        protected ComportementEmettreUnSon ComportementEmetreUnSon { get; set; }

        public abstract string Afficher();
        public abstract string SeDeplacer();

        protected Personnage(string sonNom)
        {
            Nom = sonNom;
        }

        public void ModifierComportementCombat(ComportementCombat nouveauComportement)
        {
            ComportementCombat = nouveauComportement;
        }

        public void ModifierComportementEmettreUnSon(ComportementEmettreUnSon nouveauComportement)
        {
            ComportementEmetreUnSon = nouveauComportement;
        }

        public string EmettreUnSon()
        {
            if (ComportementEmetreUnSon != null)
                return ComportementEmetreUnSon.EmmettreSon();

            return "Je suis muet.";
        }

        public string Combattre()
        {
            if(ComportementCombat != null)
                return ComportementCombat.Combattre();

            return "Je ne combat pas.";
        }
    }
}