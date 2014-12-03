using MachineACafe.Etats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    public enum EIngredient
    {
        Cannelle,
        Lait,
        Chantilly,
        Caramel
    };

    public enum EBoisson
    {
        Aucune,
        Expresso,
        CafeLong,
        ExpressoGrains,
        CafeLonggrains,
        Chocolat,
        Capuccino
    };

    public enum EEtat
    {
        PasDePiece,
        Selection,
        EnCoursDeLivraison,
        Gagnant,
        EnMaintenance
    };

    public class MachineACafe
    {
        public double ArgentRecupere { get; set; }
        public EBoisson BoissonCourante { get; set; }
        public int DosageSucre { get; set; }

        public EtatAbstrait etatCourant { get; set; }

        public Dictionary<EBoisson, Boisson> boissonDico = new Dictionary<EBoisson, Boisson>();

        public MachineACafe()
        {
            boissonDico.Add(EBoisson.Aucune, null);
            boissonDico.Add(EBoisson.CafeLong, new Boisson("Cafe long", 0.3));
            boissonDico.Add(EBoisson.CafeLonggrains, new Boisson("Cafe long grains", 0.2));
            boissonDico.Add(EBoisson.Capuccino, new Boisson("Capuccino", 0.5));
            boissonDico.Add(EBoisson.Chocolat, new Boisson("Chocolat", 0.7));
            boissonDico.Add(EBoisson.Expresso, new Boisson("Expresso", 1.0));
            boissonDico.Add(EBoisson.ExpressoGrains, new Boisson("Expresso Grains", 0.5));

            ChangeEtat(EEtat.PasDePiece);
        }

        public bool AssezArgent(EBoisson uneBoisson)
        {
            if (boissonDico[uneBoisson].Cout <= ArgentRecupere)
                return true;

            return false;
        }

        public double CalculRenduArgent()
        {
            return ArgentRecupere - boissonDico[BoissonCourante].Cout;
        }

        public void ChangeEtat(EEtat nouvelEtat)
        {
            switch (nouvelEtat)
            {
                case EEtat.EnCoursDeLivraison:
                    etatCourant = new EtatEnCoursDeLivraison(this);
                    break;

                case EEtat.PasDePiece:
                    ArgentRecupere = 0;
                    DosageSucre = 0;
                    etatCourant = new EtatPasDePiece(this);
                    break;

                case EEtat.Selection:
                    etatCourant = new EtatSelection(this);
                    break;

                case EEtat.Gagnant:
                    DosageSucre = 0;
                    etatCourant = new EtatGagnant(this);
                    break;
            }
        }

        public void ChoisirIngredient(EIngredient unIngredient)
        {
            etatCourant.ChoisirIngredient(unIngredient);
        }

        public void ChoisirSucre(int dosage)
        {
            etatCourant.ChoisirSucre(dosage);
        }

        public void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            etatCourant.ChoisirUneBoisson(uneBoisson);
        }

        public void InsererMonnaie(double nbreEuros)
        {
            etatCourant.InsererMonnaie(nbreEuros);
        }

        public void PasserEnMaintenance()
        {
            etatCourant.PasserEnMaintenance();
        }

        public void RecuperationGobelet()
        {
            etatCourant.RecuperationGobelet();
        }

        public void RecupererMonnaie()
        {
            etatCourant.RecupererMonnaie();
        }

        public void RendreMonnaie()
        {
            etatCourant.RendreMonnaie();
        }
    }
}