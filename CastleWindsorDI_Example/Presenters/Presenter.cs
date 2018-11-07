using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using CastleWindsorDI_Example.Views;

namespace CastleWindsorDI_Example.Presenters
{
    public class Presenter : IPresenter
    {
        private MainView View { get; set; }

        public Presenter(ILogger logger)
        {

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
    }
}
