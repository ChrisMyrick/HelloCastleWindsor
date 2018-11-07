using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers;
using Castle.Services.Logging.SerilogIntegration;
using Castle.Windsor;
using CastleWindsorDI_Example.Logger;

namespace CastleWindsorDI_Example.DependencyInjection
{
    // This class provides extension methods for the CastleWindsor container
    public static class ContainerExtensions
    {
        /// <summary>
        /// Registers all components to the container
        /// </summary>
        /// <param name="container">Castle Windsor container</param>
        public static void Bootstrap(this WindsorContainer container)
        {
            // Configure logging
            var logger = LoggerConfigurationManager.GetConfiguredLogger();

            // Using the Serilog logger here rather than the ILogger to avoid having to manually resolve from the container 
            logger.Information("Bootstrapping the container");
            container.AddFacility<LoggingFacility>(f => f.LogUsing(new SerilogFactory(logger)));

            // Setup property injection
            container.AddFacility(new PropertyInjectionFacility());

            // Allow lazy loading
            container.Register(Component.For<ILazyComponentLoader>()
                .ImplementedBy<LazyOfTComponentLoader>());

            // Run installers from other projects
            container.Install(
                new WinformsInstaller() //,
                //new DataLayerInstaller(),
                //new LibraryInstaller()
            );
        }

        public static void ReleaseComponents(this WindsorContainer container, params object[] components)
        {
            foreach (var component in components)
            {
                container.Release(component);
            }
        }
    }

}
