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
        public string Description { get; set; }
        public FireThrowerHandler(string description)
        {
            Description = description;
        }

        public void Attack(FireThrower fireThrower)
        {
            fireThrower.Load();
            fireThrower.Fire();
        }


        public string GetDescription()
        {
            return Description;
        }
    }
}
