using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimulationGames_AvecObservateur
{
    public partial class MainWindow : Window
    {
        public SimulationJeu Games { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Games = new SimulationJeu();
        }

        private void SendWarOrder_Click(object sender, RoutedEventArgs e)
        {
            Games.EnvoyerOrdreGuerre();
        }

        private void SendPeaceOrder_Click(object sender, RoutedEventArgs e)
        {
            Games.EnvoyerOrdrePaix();
        }

        private void DisplayAll_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Games.AfficheTous());
        }

        private void EmitSoundAll_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Games.EmettreSonTous());
        }

        private void LaunchFight_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Games.LancerCombat());
        }

        private void ChangeBehavior_Click(object sender, RoutedEventArgs e)
        {
            Games.ChangerComportement();
        }

        private void DetachPersonnage_Click(object sender, RoutedEventArgs e)
        {
            if (Games.EtatMajor.observateurList.Contains(Games.PersonnageList[0]))
            {
                Games.PersonnageList[0].EtatFonctionnement = "Pas d'etat de fonctionnement";
                Games.EtatMajor.DeAttach(Games.PersonnageList[0]);
            }
        }

        private void AttachPersonnage_Click(object sender, RoutedEventArgs e)
        {
            if (!Games.EtatMajor.observateurList.Contains(Games.PersonnageList[0]))
            {
                Games.PersonnageList[0].EtatFonctionnement = "Non defini";
                Games.EtatMajor.Attach(Games.PersonnageList[0]);
            }
        }
    }
}
