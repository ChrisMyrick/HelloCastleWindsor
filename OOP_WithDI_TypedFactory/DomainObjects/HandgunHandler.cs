using CastleWindsorDI_Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class HandgunHandler : IWeaponHandler<Handgun>
    {
        public HandgunHandler()
        {
        }

        public void Attack(Handgun handgun)
        {
            handgun.Load();
            handgun.Fire();
        }

       
    }
}

