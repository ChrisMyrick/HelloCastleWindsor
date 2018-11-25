using CastleWindsorDI_Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class FireThrowerHandler : IWeaponHandler<FireThrower>
    {
        public FireThrowerHandler()
        {
        }

        public void Attack(FireThrower fireThrower)
        {
            fireThrower.Load();
            fireThrower.Fire();
        }
    }
}
