using Castle.Windsor;
using CastleWindsorDI_Example.Presenters;
using CastleWindsorDI_Example.Views;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using CastleWindsorDI_Example.DependencyInjection;

namespace CastleWindsorDI_Example
{
    public static class Program
    {
        private static readonly WindsorContainer Container = new WindsorContainer();
        private static IPresenter _presenter;
        private static MainView _view;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;

            // bootstrap the container
            Container.Install(
                new WinformsInstaller()
            );

            _presenter = Container.Resolve<IPresenter>();
            _view = (MainView)Container.Resolve<IMainView>();
            Application.Run(_view);
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            Container.Dispose();
        }
    }
}
