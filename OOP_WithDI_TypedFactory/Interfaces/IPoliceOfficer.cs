using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleWindsorDI_Example.DomainObjects;

namespace CastleWindsorDI_Example.Interfaces
{
    public interface IPoliceOfficer
    {
        void Arrest();
        void Shoot();
        string Name { get; set; }
        Ethnicity Ethnicity { get; set; }
        string Speak();
        void Sleep();
        void Eat();
        void Attack(FireThrower fireThrower);
        string WhomAmI();
    }
}
