using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorDI_Example.Interfaces
{
    public interface IWeaponHandlerFactory
    {
        IWeaponHandler<T> Create<T>() where T : IWeapon;
        void Release<T>(IWeaponHandler<T> instance) where T : IWeapon;
    }
}
