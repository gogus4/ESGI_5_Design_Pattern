using SimulationGames_AvecObservateur.Comportements;
using SimulationGames_AvecObservateur.Personnages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur
{
    public class SimulationJeu
    {
        public List<Personnage> PersonnageList { get; set; }
        public Organisation EtatMajor { get; set; }

        public SimulationJeu()
        {
            PersonnageList = new List<Personnage>();
            EtatMajor = new Organisation();

            CreationPersonnages();
            EtatMajor.ModeFonctionnement = eMode.NonDefini;
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

        private void AjouterALaSimulation(Personnage nouveauPersonnage)
        {
            PersonnageList.Add(nouveauPersonnage);
            EtatMajor.Attach(PersonnageList[PersonnageList.Count - 1]);
        }

        private void CreationPersonnages()
        {
            PersonnageList.Add(new Archer(EtatMajor, "Oliver Queen"));
            EtatMajor.Attach(PersonnageList[0]);

            PersonnageList.Add(new Fantassin(EtatMajor, "Fantassin !"));
            EtatMajor.Attach(PersonnageList[1]);

            PersonnageList.Add(new Chevalier(EtatMajor, "Uther Pendragon"));
            EtatMajor.Attach(PersonnageList[2]);

            PersonnageList.Add(new Princesse(EtatMajor, "Princesse Sarah"));
            EtatMajor.Attach(PersonnageList[3]);

            PersonnageList.Add(new Lancier(EtatMajor, "Lancier !"));
            EtatMajor.Attach(PersonnageList[4]);

            PersonnageList.Add(new Spadassin(EtatMajor, "Spadassin !"));
            EtatMajor.Attach(PersonnageList[5]);

            PersonnageList.Add(new Arbaletrier(EtatMajor, "Arbaletrier !"));
            EtatMajor.Attach(PersonnageList[6]);
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

        public void EnvoyerOrdreGuerre()
        {
            EtatMajor.ModeFonctionnement = eMode.EnGuerre;
        }

        public void EnvoyerOrdrePaix()
        {
            EtatMajor.ModeFonctionnement = eMode.EnPaix;
        }
    }
}