using System;
using DiWithInterceptors.Interfaces;
using DiWithInterceptors.Views;
//using Castle.Core.Logging;

namespace DiWithInterceptors.Presenters
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
