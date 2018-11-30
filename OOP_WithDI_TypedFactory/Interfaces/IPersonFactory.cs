using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorDI_Example.Interfaces
{
    public interface IPersonFactory
    {
        IPerson Create(string name, string role, int age, decimal weight);
        void Release(IPerson instance);
        void Dispose();
    }
}
