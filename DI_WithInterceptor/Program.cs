using Castle.Windsor;
using DiWithInterceptors.Presenters;
using DiWithInterceptors.Views;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using DiWithInterceptors.DependencyInjection;

namespace DiWithInterceptors
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

