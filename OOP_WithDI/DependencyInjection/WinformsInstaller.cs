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
            var regs = Classes.FromThisAssembly()
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
        }
    }
}
