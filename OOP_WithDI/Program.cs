using Castle.Windsor;
using CastleWindsorDI_Example.DependencyInjection;
using CastleWindsorDI_Example.Presenters;
using CastleWindsorDI_Example.Views;
using System;
using System.Windows.Forms;

namespace CastleWindsorDI_Example
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WindsorContainer container = new WindsorContainer();
            container.Bootstrap();

            IPresenter presenter = container.Resolve<IPresenter>();
            //Instantiation of view is required here due to dynamic proxy created by CastleWindsor which expects
            //a Form type (not an interface) at Application.Run
            MainView view = new MainView(presenter);
            Application.Run(view);
        }
    }
}
