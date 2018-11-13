using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.ModelBuilder;

//using Svmic.Policy.Library.Attributes;

namespace DiWithInterceptors.DependencyInjection
{
    public class PropertyInjectionContributor : IContributeComponentModelConstruction
    {
        public void ProcessModel(IKernel kernel, ComponentModel model)
        {
            var properties = GetProperties(model);
            if (properties.Count > 0)
            {
                properties.ForEach(p => model.AddProperty(BuildDependency(p)));
            }
        }

        private static PropertySet BuildDependency(PropertyInfo property)
        {
            var dependency = new PropertyDependencyModel(property, false);
            return new PropertySet(property, dependency);
        }

        private static List<PropertyInfo> GetProperties(ComponentModel model)
        {
            BindingFlags bindingFlags;
            if (model.InspectionBehavior == PropertiesInspectionBehavior.DeclaredOnly)
            {
                bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
            }
            else
            {
                bindingFlags = BindingFlags.Public | BindingFlags.Instance;
            }

            var properties = model.Implementation.GetProperties(bindingFlags);
            return properties.Where(IsValidPropertyDependency).ToList();
        }

        private static bool IsValidPropertyDependency(PropertyInfo property)
        {
            return IsSettable(property) && HasParameters(property) == false && HasInjectedAttribute(property);
        }

        private static bool IsSettable(PropertyInfo property)
        {
            return property.CanWrite && property.GetSetMethod() != null;
        }

        private static bool HasParameters(PropertyInfo property)
        {
            var indexerParams = property.GetIndexParameters();
            return indexerParams.Length != 0;
        }

        private static bool HasInjectedAttribute(MemberInfo property)
        {
            return property.IsDefined(typeof(InjectedAttribute));
        }
    }
}
