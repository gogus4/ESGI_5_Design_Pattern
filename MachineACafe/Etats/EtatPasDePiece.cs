using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe.Etats
{
    public class EtatPasDePiece : EtatAbstrait
    {
        public EtatPasDePiece(MachineACafe distributeur)
            : base(distributeur)
        {
        }

        public override void ChoisirIngredient(EIngredient unIngredient)
        {
            Console.WriteLine("Methode non implementé.");
        }

        public override void ChoisirSucre(int dosage)
        {
            Console.WriteLine("Impossible de choisir le sucre car il n'y as pas de pièce dans la machine à café.");
        }

        public override void ChoisirUneBoisson(EBoisson uneBoisson)
        {
            Console.WriteLine("Impossible de choisir une boisson car il n'y as pas de pièce dans la machine à café.");
        }

        public override void InsererMonnaie(double nbreEuros)
        {
            double[] PieceAutorise = { 0.1, 0.2, 0.5, 1, 2 };
            if (PieceAutorise.Contains(nbreEuros))
            {
                machineACafe.ChangeEtat(EEtat.Selection);
                machineACafe.ArgentRecupere += nbreEuros;
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
            if (machineACafe.ArgentRecupere > 0)
            {
                machineACafe.ArgentRecupere = 0;
                Console.WriteLine("Vous venez de recuperer votre monnaie.");
            }

            else
            {
                Console.WriteLine("Vous n'avez pas de monnaie dans la machine");
            }
        }

        public override void RendreMonnaie()
        {
            Console.WriteLine("Impossible de rendre la monnaie car il n'y a pas de pièce.");
        }
    }
}
