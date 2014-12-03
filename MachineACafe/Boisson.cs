using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    public class Boisson
    {
        public double Cout { get; set; }
        public string Nom { get; set; }

        public Boisson(string unNom, double unCout)
        {
            Cout = unCout;
            Nom = unNom;
        }
    }
}
