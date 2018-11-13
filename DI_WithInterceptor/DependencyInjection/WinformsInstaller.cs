using System;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

//using CastleWindsorDI_Example.Logger;

namespace DiWithInterceptors.DependencyInjection
{
    public class WinformsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                .Where(x => !Attribute.IsDefined(x, typeof(SingletonAttribute))) //.Where(Component.IsInSameNamespaceAs<King>())
                .WithService
                .DefaultInterfaces()
                .LifestyleTransient());
        }
    }
}
