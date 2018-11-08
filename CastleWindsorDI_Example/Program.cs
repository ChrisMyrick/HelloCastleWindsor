using Castle.Core.Logging;
using Castle.MicroKernel;
using Castle.Windsor;
using CastleWindsorDI_Example.DependencyInjection;
//using CastleWindsorDI_Example.Logger;
using System;
using System.Deployment.Application;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using CastleWindsorDI_Example.Views;
using CastleWindsorDI_Example.Presenters;

namespace CastleWindsorDI_Example
{
    public static class Program
    {
        public static MainView View { get; set; }
        public static IPresenter Presenter { get; set; }

        private static readonly WindsorContainer Container = new WindsorContainer();
        //private static ILogger Logger { get; set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BootstrapContainer();
            ManuallyResolveComponents();
            //Logger.Info("Starting the application");
            Application.Run(View);
        }

        private static void ManuallyResolveComponents()
        {
            Presenter = Container.Resolve<IPresenter>();
            //Logger = Container.Resolve<ILogger>();

            //Instantiation is required here due to dynamic proxy created by CastleWindsor which expects
            //a Form type (not an interface) at Application.Run
            View = new MainView(Presenter);
        }

        private static void BootstrapContainer()
        {
            try
            {
                Container.Bootstrap();
            }
            catch (ComponentRegistrationException ex)
            {
                //Logger.Error("An error occurred while bootstrapping the container", ex);
            }
        }
    }
}
