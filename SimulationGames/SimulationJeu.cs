using SimulationGames_AvecComportement.Comportements;
using SimulationGames_AvecComportement.Personnages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecComportement
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
            StringBuilder message = new StringBuilder();
            foreach (Personnage p in PersonnageList)
                message.Append(p.Afficher() + Environment.NewLine);

            return message.ToString();
        }

        public void ChangerComportement()
        {
            Random random = new Random();
            int numberRandom = random.Next(0, PersonnageList.Count);

            if (PersonnageList[numberRandom].GetType() != typeof(Princesse))
                PersonnageList[numberRandom].ModifierComportementCombat(new ComportementAPiedAvecHache());
        }

        private void CreationPersonnages()
        {
            PersonnageList.Add(new Archer("Oliver Queen"));
            PersonnageList.Add(new Fantassin("Fantassin !"));
            PersonnageList.Add(new Chevalier("Uther Pendragon"));
            PersonnageList.Add(new Princesse("Princesse Sarah"));
            PersonnageList.Add(new Lancier("Lancier !"));
            PersonnageList.Add(new Spadassin("Spadassin !"));
            PersonnageList.Add(new Arbaletrier("Arbaletrier !"));
        }

        public string EmettreSonTous()
        {
            StringBuilder message = new StringBuilder();
            foreach (Personnage p in PersonnageList)
                message.Append(p.EmettreUnSon() + Environment.NewLine);

            return message.ToString();
        }

        public string LancerCombat()
        {
            StringBuilder message = new StringBuilder();
            foreach (Personnage p in PersonnageList)
                message.Append(p.Combattre() + Environment.NewLine);

            return message.ToString();
        }
    }
}