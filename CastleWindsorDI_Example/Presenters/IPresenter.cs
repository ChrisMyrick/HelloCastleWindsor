using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleWindsorDI_Example.Views;

namespace CastleWindsorDI_Example.Presenters
{
    public interface IPresenter
    {
        void Display();

        void Initialize(IMainView view);

        void DoSomething();
    }
}
