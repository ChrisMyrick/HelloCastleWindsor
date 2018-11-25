using CastleWindsorDI_Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class HandgunHandler : IWeaponHandler<Handgun>
    {
        public string Description { get; set; }
        public HandgunHandler(string description)
        {
            Description = description;
        }

        public void Attack(Handgun handgun)
        {
            handgun.Load();
            handgun.Fire();
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}

