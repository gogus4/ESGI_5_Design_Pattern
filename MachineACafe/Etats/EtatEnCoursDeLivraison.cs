using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe.Etats
{
    public class EtatEnCoursDeLivraison : EtatAbstrait
    {
        public EtatEnCoursDeLivraison(MachineACafe distributeur)
            : base(distributeur)
        {
        }

        public override void ChoisirIngredient(EIngredient unIngredient)
        {
            Console.WriteLine("Methode non implementé.");
        }

        public override void ChoisirSucre(int dosage)
        {
            Console.WriteLine("Votre boisson est en cours de préparation. Vous ne pouvez pas choisir le sucre.");
        }

        public override void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            Console.WriteLine("Votre boisson est en cours de préparation. Vous ne pouvez pas choisir de boisson.");
        }

        public override void InsererMonnaie(double nbreEuros)
        {
            Console.WriteLine("Votre boisson est en cours de préparation. Vous ne pouvez pas inserer de monnaie.");
        }

        public override void PasserEnMaintenance()
        {
            Console.WriteLine("Passer en maintenance.");
        }

        public override void RecuperationGobelet()
        {
            Console.WriteLine("Commande en cours de preparation. Merci de patienter...");

            Task task = Task.Delay(2000);
            task.Wait();

            Console.WriteLine(string.Format("Votre commande est prête. Au revoir."));

            machineACafe.ChangeEtat(EEtat.PasDePiece);
        }

        public override void RecupererMonnaie()
        {
            Console.WriteLine(string.Format("Impossible de récupérer la monnaie car votre boisson est en cours de preparation."));
        }

        public override void RendreMonnaie()
        {
            Console.WriteLine("Impossible de rendre la monnaie car votre boisson est en cours de preparation.");
        }
    }
}
