using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers;
using Castle.Windsor;

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
            // Enable TypedFactoryFacilty to enable dynamic creation of componnet with parameters
            container.AddFacility<TypedFactoryFacility>();
            
            // Allow lazy loading
            container.Register(Component.For<ILazyComponentLoader>()
                .ImplementedBy<LazyOfTComponentLoader>());

            // Run installers
            container.Install(
                new WinformsInstaller()
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
