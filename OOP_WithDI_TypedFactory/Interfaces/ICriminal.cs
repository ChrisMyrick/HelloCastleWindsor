using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleWindsorDI_Example.DomainObjects;

namespace CastleWindsorDI_Example.Interfaces
{
    public interface ICriminal : IPerson
    {
        void Personify(IPerson person);
        void RobBank();
        void StealCar();
        void Attack(Handgun handgun);
        void ShowWeaponDescription();
    }
}
