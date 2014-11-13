using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGames_AvecObservateur
{
    public abstract class SujetObserveAbstrait
    {
        public List<IObservateurAbstrait> observateurList { get; set; }

        protected SujetObserveAbstrait()
        {
            observateurList = new List<IObservateurAbstrait>();
        }

        public void Attach(IObservateurAbstrait unObservateur)
        {
            observateurList.Add(unObservateur);
        }

        public void DeAttach(IObservateurAbstrait unObservateur)
        {
            observateurList.Remove(unObservateur);
        }

        public void Update()
        {
            foreach (IObservateurAbstrait observateur in observateurList)
            {
                observateur.Update();
            }
        }
    }
}