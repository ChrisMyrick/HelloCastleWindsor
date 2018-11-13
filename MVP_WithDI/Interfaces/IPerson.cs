using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleWindsorDI_Example.DomainObjects;

namespace CastleWindsorDI_Example.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        Ethnicity Ethnicity { get; set; }

        string Speak();
        void Sleep();
        void Eat();
    }
}
