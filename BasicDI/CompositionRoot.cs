using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDI
{
    public class CompositionRoot : ICompositionRoot
    {
        readonly IConsoleWriter _consoleWriter;

        public CompositionRoot(IConsoleWriter consoleWriter)
        {
            this._consoleWriter = consoleWriter;
            consoleWriter.LogMessage("Hello from the CompositionRoot Constructor.");
        }

        public void LogMessage(string message)
        {
            _consoleWriter.LogMessage(message);
        }
    }
}
