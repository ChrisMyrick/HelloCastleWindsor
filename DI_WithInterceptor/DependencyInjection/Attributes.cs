using System;

namespace DiWithInterceptors.DependencyInjection
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class InjectedAttribute : Attribute
    {

    }
}
