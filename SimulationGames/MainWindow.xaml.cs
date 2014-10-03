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

namespace SimulationGames
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SimulationJeu Games { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Games = new SimulationJeu();
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
    }
}
