using System;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CastleWindsorDI_Example.Interfaces;
using CastleWindsorDI_Example.DomainObjects;
using System.Threading;
using Castle.Facilities.TypedFactory;

namespace CastleWindsorDI_Example.DependencyInjection
{
    // Windsor Installers - https://github.com/castleproject/Windsor/blob/master/docs/installers.md
    public class WinformsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var regs = Classes.FromThisAssembly()
             .Where(x => !Attribute.IsDefined(x, typeof(SingletonAttribute))) //register all classes that aren't Singletons
             .Unless(t => t == (typeof(HandgunHandler)) || t == (typeof(FireThrowerHandler)))
             .WithService
             .DefaultInterfaces()
             .LifestyleTransient();

            container.Register(
                regs,

                Component.For<IWeaponHandler<Handgun>>()
                .ImplementedBy<HandgunHandler>()
                .LifestyleTransient(),

               Component.For<IWeaponHandler<FireThrower>>()
                .ImplementedBy<FireThrowerHandler>()
                .LifestyleTransient(),

                Component.For<IWeaponHandlerFactory>()
                .AsFactory(),

                Component.For<IPersonFactory>()
                .AsFactory()
            );

        }
    }
}
