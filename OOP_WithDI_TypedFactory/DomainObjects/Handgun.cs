using CastleWindsorDI_Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class Handgun : IWeapon
    {
        public int Caliber { get; set; }
        public string Type { get; set; }

        public Handgun(int caliber, string type)
        {
            Caliber = caliber;
            Type = type;
        }
        public void Fire()
        {
            MessageBox.Show($"Fired a {Type} hand gun with {Caliber} mm caliber.");
        }

        public void Load()
        {
            MessageBox.Show($"Loaded a {Type} hand gun with {Caliber} mm caliber.");
        }
    }
}
