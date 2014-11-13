using SimulationGames_AvecObservateur.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur.Personnages
{
    public abstract class Personnage : IObservateurAbstrait
    {
        protected string Nom { get; set; }
        protected ComportementCombat ComportementCombat { get; set; }
        protected ComportementEmettreUnSon ComportementEmetreUnSon { get; set; }

        protected Organisation EtatMajor { get; set; }

        public string EtatFonctionnement { get; set; }

        public abstract string Afficher();
        public abstract string SeDeplacer();

        protected Personnage(Organisation unEtatMajor, string sonNom)
        {
            Nom = sonNom;
            EtatMajor = unEtatMajor;
        }

        public void Update()
        {
            if (EtatMajor != null)
            {
                switch (EtatMajor.ModeFonctionnement)
                {
                    case eMode.EnGuerre:
                        this.EtatFonctionnement = "En guerre";
                        break;

                    case eMode.EnPaix:
                        this.EtatFonctionnement = "En paix";
                        break;

                    case eMode.EnRepli:
                        this.EtatFonctionnement = "En repli";
                        break;

                    case eMode.NonDefini:
                        this.EtatFonctionnement = "Non defini";
                        break;

                    default:
                        this.EtatFonctionnement = "Pas d'etat de fonctionnement";
                        break;
                }
            }

            else
            {
                this.EtatFonctionnement = "Pas d'etat de fonctionnement";
            }
        }

        public void ModifierComportementCombat(ComportementCombat nouveauComportement)
        {
            ComportementCombat = nouveauComportement;
        }

        public void ModifierComportementEmettreSon(ComportementEmettreUnSon nouveauComportement)
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
            if (ComportementCombat != null)
                return ComportementCombat.Combattre();

            return "Je ne combat pas.";
        }
    }
}