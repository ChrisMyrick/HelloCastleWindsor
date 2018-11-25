using CastleWindsorDI_Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class FireThrower : IWeapon
    {
        public int Volume { get; set; }
        public string Type { get; set; }
        public string NickName { get; set; }

        public FireThrower(int volume, string type, string nickName)
        {
            Volume = volume;
            Type = type;
            NickName = nickName;
        }
        public void Fire()
        {
            MessageBox.Show($"Fired {NickName},  a {Type} Fire Thrower with {Volume} gallon volume.");
        }

        public void Load()
        {
            MessageBox.Show($"Loaded {NickName},  a {Type} Fire Thrower with {Volume} gallon volume.");
        }
    }
}
