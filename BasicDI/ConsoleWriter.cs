using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDI
{
    public class ConsoleWriter : IConsoleWriter
    {
        // Single Responsibility Principle - this class has one responsibility: Writing to the console.
        public void LogMessage(string message)
        {
            Console.WriteLine($"From Logger: {message}");
        }
    }
}
