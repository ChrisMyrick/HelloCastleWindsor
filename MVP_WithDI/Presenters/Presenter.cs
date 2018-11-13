using CastleWindsorDI_Example.Interfaces;
using CastleWindsorDI_Example.Views;
using System;
using System.Windows.Forms;

namespace CastleWindsorDI_Example.Presenters
{
    public class Presenter : IPresenter
    {
        private MainView View { get; set; }
        private IPerson Person { get; set; }

        public Presenter(IPerson person)
        {
            Person = person;
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Initialize(IMainView view)
        {
            view.Message = "This is a message from the presenter.";
        }

        public void Speak()
        {
            MessageBox.Show(Person.Speak());
        }

    }
}
