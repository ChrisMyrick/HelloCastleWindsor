using System;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
//using CastleWindsorDI_Example.Logger;

namespace CastleWindsorDI_Example.DependencyInjection
{
    public class WinformsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            RegisterTransientComponents(container);
            RegisterSingletonComponents(container);
        }

        private static void RegisterTransientComponents(IWindsorContainer container)
        {
            container.Register(Classes.FromThisAssembly()
                .Where(x => !Attribute.IsDefined(x, typeof(SingletonAttribute)))
                .WithService
                .DefaultInterfaces()
                .LifestyleTransient());
            //.Configure(c => c.Interceptors<LoggingInterceptor>()));
        }

        private static void RegisterSingletonComponents(IWindsorContainer container)
        {
            container.Register(Classes.FromThisAssembly()
                .Where(x => Attribute.IsDefined(x, typeof(SingletonAttribute)))
                .WithService
                .DefaultInterfaces()
                .LifestyleSingleton());
            //.Configure(c => c.Interceptors<LoggingInterceptor>()));
        }
    }
}
