using System;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace CastleWindsorDI_Example.DependencyInjection
{
    // Windsor Installers - https://github.com/castleproject/Windsor/blob/master/docs/installers.md
    public class WinformsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromThisAssembly()
                .Where(x => !Attribute.IsDefined(x, typeof(SingletonAttribute))) //register all classes that aren't Singletons
                .WithService
                .DefaultInterfaces()
                .LifestyleTransient()
            );
        }
    }
}
