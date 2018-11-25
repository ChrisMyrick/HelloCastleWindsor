using System;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CastleWindsorDI_Example.Interfaces;
using CastleWindsorDI_Example.DomainObjects;

namespace CastleWindsorDI_Example.DependencyInjection
{
    // Windsor Installers - https://github.com/castleproject/Windsor/blob/master/docs/installers.md
    public class WinformsInstaller : IWindsorInstaller
    {
        // This sets with two ways to register components that allows configuration of Criminals and Policy Officer
        // Both do the same thing of registering the services needed.
        enum RegMethod
        {
            ByAdditionalConfiguration, 
            ByException 
        }
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var regMethod = RegMethod.ByAdditionalConfiguration;
            BasedOnDescriptor regs;

            switch (regMethod)
            {
                // Register all services and then further configure the ones that need inline parameters
                case RegMethod.ByAdditionalConfiguration:
                    regs = Classes.FromThisAssembly()
                     .Where(x => !Attribute.IsDefined(x, typeof(SingletonAttribute))) //register all classes that aren't Singletons
                     .WithService
                     .DefaultInterfaces()
                     .LifestyleTransient();

                    regs.ConfigureFor<DomainObjects.Criminal>(component =>
                    {
                        component.DependsOn(Property.ForKey("name").Eq("THE JOKER"));
                        component.DependsOn(Property.ForKey("age").Eq(38));
                        component.DependsOn(Property.ForKey("weight").Eq(196.58m));
                        component.DependsOn(Property.ForKey("role").Eq("Criminal"));
                    });

                    regs.ConfigureFor<DomainObjects.PoliceOfficer>(component =>
                    {
                        component.DependsOn(Property.ForKey("name").Eq("Batman"));
                        component.DependsOn(Property.ForKey("age").Eq(36));
                        component.DependsOn(Property.ForKey("weight").Eq(215.1m));
                        component.DependsOn(Property.ForKey("role").Eq("Police Officer"));
                    });

                    container.Register(regs);

                    break;

                // Register all services except those who need inline parameters, which are registered separately later.
                case RegMethod.ByException:
                    regs = Classes.FromThisAssembly()
                     .Where(x => !Attribute.IsDefined(x, typeof(SingletonAttribute))) //register all classes that aren't Singletons
                     .Unless(t => (typeof(DomainObjects.Criminal) == t) || (typeof(DomainObjects.PoliceOfficer) == t))
                     .WithService
                     .DefaultInterfaces()
                     .LifestyleTransient();

                    container.Register(regs);

                    container.Register(
                        Component.For<ICriminal>()
                        .LifestyleTransient()
                        .ImplementedBy<Criminal>()
                        .DependsOn(Property.ForKey("name").Eq("THE JOKER"))
                        .DependsOn(Property.ForKey("age").Eq(38))
                        .DependsOn(Property.ForKey("weight").Eq(196.58m))
                        .DependsOn(Property.ForKey("role").Eq("Criminal"))
                    );

                    container.Register(
                        Component.For<IPoliceOfficer>()
                        .LifestyleTransient()
                        .ImplementedBy<PoliceOfficer>()
                        .DependsOn(Property.ForKey("name").Eq("Batman"))
                        .DependsOn(Property.ForKey("age").Eq(36))
                        .DependsOn(Property.ForKey("weight").Eq(215.1m))
                        .DependsOn(Property.ForKey("role").Eq("Police Officer"))
                    );

                    break;
                default:
                    break;
            }




        }
    }
}
