using System.Linq;
using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.ModelBuilder.Inspectors;

namespace CastleWindsorDI_Example.DependencyInjection
{
    public class PropertyInjectionFacility : AbstractFacility
    {
        protected override void Init()
        {
            var propInjector = Kernel.ComponentModelBuilder
                .Contributors
                .OfType<PropertiesDependenciesModelInspector>()
                .Single();

            Kernel.ComponentModelBuilder.RemoveContributor(propInjector);

            Kernel.ComponentModelBuilder.AddContributor(new PropertyInjectionContributor());
        }
    }
}
