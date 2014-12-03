using System;
using System.Linq;

namespace MachineACafe.Etats
{
    public class EtatSelection : EtatAbstrait
    {
        public Random rand = new Random();

        public EtatSelection(MachineACafe distributeur)
            : base(distributeur)
        {
        }

        public override void ChoisirIngredient(EIngredient unIngredient)
        {
            Console.WriteLine("Methode non implementé.");
        }

        public override void ChoisirSucre(int dosage)
        {
            if (dosage >= 0 && dosage <= 5)
                machineACafe.DosageSucre = dosage;

            else
                Console.WriteLine("Impossible de choisir le sucre.");
        }

        public override void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            Boisson coutBoisson = machineACafe.boissonDico[uneBoisson];
            int nbRandom = rand.Next(1, 100);

            if(nbRandom >= 0 && nbRandom < 10)
            {
                machineACafe.ChangeEtat(EEtat.Gagnant);
                machineACafe.BoissonCourante = EBoisson.Chocolat;
                machineACafe.ChoisirUneBoisson(EBoisson.Chocolat);
            }

            else if (machineACafe.AssezArgent(uneBoisson))
            {
                machineACafe.BoissonCourante = uneBoisson;

                Console.WriteLine(string.Format("Boisson choisi : \"{0}\" Coût : {1} euros", coutBoisson.Nom, coutBoisson.Cout));

                machineACafe.RendreMonnaie();
                machineACafe.ChangeEtat(EEtat.EnCoursDeLivraison);
            }

            else
                Console.WriteLine("Vous ne disposez pas d'assez d'argent pour choisir la boisson " + coutBoisson.Nom);
        }

        public override void InsererMonnaie(double nbreEuros)
        {
            double[] PieceAutorise = { 0.1, 0.2, 0.5, 1, 2 };

            if (PieceAutorise.Contains(nbreEuros))
            {
                machineACafe.ArgentRecupere += nbreEuros;
                machineACafe.ChangeEtat(EEtat.Selection);
            }

            else
                Console.WriteLine(string.Format("Le montant de votre pièce de monnaie n'est pas pris en charge par la machine."));
        }

        public override void PasserEnMaintenance()
        {
            Console.WriteLine("Passer en maintenance");
        }

        public override void RecuperationGobelet()
        {
            Console.WriteLine("Impossible de récupérer le gobelet car il n'y à pas de pièce.");
        }

        public override void RecupererMonnaie()
        {
            Console.WriteLine("Impossible de récupérer la monnaie car il n'y à pas de pièce");
        }

        public override void RendreMonnaie()
        {
            double reste = machineACafe.CalculRenduArgent();

            if (reste > 0)
                Console.WriteLine(string.Format("Votre monnaie d'un montant de {0} euros est disponible.", reste));
        }
    }
}
