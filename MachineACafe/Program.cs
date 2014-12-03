using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineACafe machineACafe = new MachineACafe();

            machineACafe.InsererMonnaie(1);
            machineACafe.ChoisirSucre(2);
            machineACafe.ChoisirUneBoisson(EBoisson.CafeLong);
            machineACafe.RecuperationGobelet();

            Console.ReadKey();
        }
    }
}
