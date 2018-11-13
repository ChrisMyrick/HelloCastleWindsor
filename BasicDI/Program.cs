using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace BasicDI
{
    class Program
    {
        static void Main(string[] args)
        {
            EstablishInjectionInfrastructure();

            // Wait for user input so they can check the program's output.
            Console.ReadLine();
        }

        private static void EstablishInjectionInfrastructure()
        {
            var container = new WindsorContainer();

            // For Castle to know about injected types, register the CompositionRoot type with the container
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());


            // Ask the container for an instance of IComposition root (resolve an object of type ICompositionRoot)
            // "Resolve" is analogous to calling new() in a non-IoC application.
            var root = container.Resolve<ICompositionRoot>();
            root.LogMessage("Infrastructure wiring completed.");
        }
    }
}
