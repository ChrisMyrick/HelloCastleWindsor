using Castle.Windsor;
using CastleWindsorDI_Example.DependencyInjection;
using CastleWindsorDI_Example.Presenters;
using CastleWindsorDI_Example.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP_WithDI_TypedFactory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
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
