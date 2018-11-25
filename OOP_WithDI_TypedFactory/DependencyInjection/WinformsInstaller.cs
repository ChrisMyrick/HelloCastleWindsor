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
             .Unless(t => t == (typeof(DomainObjects.Criminal)) || t == (typeof(DomainObjects.PoliceOfficer)))
             .Unless(t => t == (typeof(HandgunHandler)) || t == (typeof(FireThrowerHandler)))
             .WithService
             .DefaultInterfaces()
             .LifestyleTransient();

            container.Register(
                regs,

                Component.For<ICriminal>()
                .LifestyleTransient()
                .ImplementedBy<Criminal>()
                //.DependsOn(Property.ForKey("name").Eq("THE JOKER"))
                .DependsOn(Property.ForKey("age").Eq(38))
                .DependsOn(Property.ForKey("weight").Eq(196.58m))
                .DependsOn(Property.ForKey("role").Eq("Criminal"))
                // Now we can assign the criminal's name based on the time of the day.
                // However, since we have only the kenel and the property bag, we cannot
                // parameterize the delegate at run time. To do that, we need typedFactory.
                .DynamicParameters((k, d) => d["name"] = "THE JOKER as of" + DateTime.Now.ToString()),

                Component.For<IPoliceOfficer>()
                .LifestyleTransient()
                .ImplementedBy<PoliceOfficer>()
                //.DependsOn(Property.ForKey("name").Eq("Batman"))
                .DependsOn(Property.ForKey("age").Eq(36))
                .DependsOn(Property.ForKey("weight").Eq(215.1m))
                .DependsOn(Property.ForKey("role").Eq("Police Officer"))
                .DynamicParameters((k, d) =>
                {
                    // make sure Batman is created 1.5 seconds later, so we can compare his timestamp with the Joker
                    Thread.Sleep(1500);
                    d["name"] = "Batman as of" + DateTime.Now.ToString();

                }),

                Component.For<IWeaponHandler<Handgun>>()
                .ImplementedBy<HandgunHandler>()
                .LifestyleTransient(),

               Component.For<IWeaponHandler<FireThrower>>()
                .ImplementedBy<FireThrowerHandler>()
                .LifestyleTransient(),

                Component.For<IWeaponHandlerFactory>()
                .AsFactory()
            );

        }
    }
}
