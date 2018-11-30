using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleWindsorDI_Example.DomainObjects;

namespace CastleWindsorDI_Example.Interfaces
{
    public interface IPoliceOfficer: IPerson
    {
        void Personify(IPerson person);
        void Arrest();
        void Shoot();
        void Attack(FireThrower fireThrower);
    }
}
