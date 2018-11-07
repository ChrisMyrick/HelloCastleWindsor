using System;

namespace CastleWindsorDI_Example.DependencyInjection
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class InjectedAttribute : Attribute
    {

    }
}
