using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorDI_Example.Interfaces
{
    public interface IWeaponHandler<TWeapon> where TWeapon: IWeapon
    {
        void Attack(TWeapon weapon);
        string GetDescription();
    }
}
