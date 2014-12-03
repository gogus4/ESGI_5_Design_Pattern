using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe.Etats
{
    public class EtatGagnant : EtatAbstrait
    {
        public EtatGagnant(MachineACafe distributeur)
            : base(distributeur)
        {
        }

        public override void ChoisirIngredient(EIngredient unIngredient)
        {
            Console.WriteLine("Methode non implementé.");
        }

        public override void ChoisirSucre(int dosage)
        {
            Console.WriteLine("Impossible de choisir le sucre car c'est un chocolat gratuit.");
        }

        public override void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            Boisson coutBoisson = machineACafe.boissonDico[uneBoisson];

            Console.WriteLine(string.Format("Boisson choisi : \"{0}\" Coût : gratuit", coutBoisson.Nom));

            machineACafe.RecupererMonnaie();
            machineACafe.ChangeEtat(EEtat.EnCoursDeLivraison);
        }

        public override void InsererMonnaie(double nbreEuros)
        {
            Console.WriteLine("Pas besoins d'inserer une monnaie c'est gratuit !");
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
            if (machineACafe.ArgentRecupere > 0)
            {
                machineACafe.ArgentRecupere = 0;

                Console.WriteLine("Vous venez de recuperer votre monnaie.");
            }

            else
                Console.WriteLine("Vous n'avez pas de monnaie dans la machine");
        }

        public override void RendreMonnaie()
        {
            Console.WriteLine("C'est gratuit, pas besoin de rendre la monnaie !");
        }
    }
}
