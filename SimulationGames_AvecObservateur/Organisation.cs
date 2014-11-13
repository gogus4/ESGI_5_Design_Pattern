using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur
{
    public enum eMode
    {
        NonDefini,
        EnGuerre,
        EnPaix,
        EnRepli
    };

    public class Organisation : SujetObserveAbstrait
    {
        public Organisation Parent { get; set; }

        private eMode modeFonctionnement;
        public eMode ModeFonctionnement
        {
            get
            {
                return modeFonctionnement;
            }

            set
            {
                modeFonctionnement = value;
                Update();
            }
        }

        public Organisation()
        {
            modeFonctionnement = eMode.NonDefini;
        }

        public Organisation(Organisation unParent)
        {
            this.Parent = unParent;
        }
    }
}
