using SimulationGames.Comportements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames
{
    public class SimulationJeu
    {
        public List<Personnage> PersonnageList { get; set; }

        public SimulationJeu()
        {
            PersonnageList = new List<Personnage>();

            CreationPersonnages();
        }

        public string AfficheTous()
        {
            string message = "";
            foreach(Personnage p in PersonnageList)
            {
                message += p.Afficher() + Environment.NewLine;
            }

            return message;
        }

        public void ChangerComportement()
        {
            Random random = new Random();
            int numberRandom = random.Next(0, PersonnageList.Count);

            if ((PersonnageList[numberRandom].ComportementCombat.GetType() != typeof(ComportementAPiedAvecHache)) && PersonnageList[numberRandom].ComportementCombat != null)
                PersonnageList[numberRandom].ComportementCombat = new ComportementAPiedAvecHache();

            else
                PersonnageList[numberRandom].ComportementCombat = new ComportementACheval();
        }

        private void CreationPersonnages()
        {
            PersonnageList.Add(new Archer("Oliver Queen"));
            PersonnageList.Add(new Fantassin("Fantassin !"));
            PersonnageList.Add(new Chevalier("Uther Pendragon"));
            PersonnageList.Add(new Princesse("Princesse Sarah"));
        }

        public string EmettreSonTous()
        {
            string message = "";
            foreach (Personnage p in PersonnageList)
            {
                message += p.ComportementEmetreUnSon.EmmettreSon() + Environment.NewLine;
            }
            return message;
        }

        public string LancerCombat()
        {
            string message = "";
            foreach (Personnage p in PersonnageList)
            {
                if(p.ComportementCombat != null)
                    message += p.ComportementCombat.Combattre() + Environment.NewLine;
            }
            return message;
        }
    }
}
