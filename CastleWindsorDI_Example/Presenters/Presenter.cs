using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Castle.Core.Logging;
using CastleWindsorDI_Example.Interfaces;
using CastleWindsorDI_Example.Views;

namespace CastleWindsorDI_Example.Presenters
{
    public class Presenter : IPresenter
    {
        private MainView View { get; set; }
        //private ILogger Logger { get; set; }
        private ICriminal Criminal { get; set; }
        private IPoliceOfficer PoliceOfficer { get; set; }

        public Presenter(ICriminal criminal, IPoliceOfficer officer) //ILogger logger,
        {
           // Logger = logger;
            Criminal = criminal;
            PoliceOfficer = officer;
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Initialize(IMainView view)
        {
            view.Message = "This is a message from the presenter.";
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }

        public void RobBank()
        {
            Criminal.RobBank();
        }

        public void Shoot()
        {
            PoliceOfficer.Shoot();
        }

        public void Arrest()
        {
            PoliceOfficer.Arrest();
        }

        public void Speak()
        {
            Criminal.Speak();
            PoliceOfficer.Speak();
        }
    }
}
