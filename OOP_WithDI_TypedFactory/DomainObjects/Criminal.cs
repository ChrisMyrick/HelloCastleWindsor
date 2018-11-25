using System;
using System.Windows.Forms;
using CastleWindsorDI_Example.Interfaces;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class Criminal : Person, ICriminal
    {
        IWeaponHandlerFactory weapontFactory;
        public Criminal(string name, string role, int age, decimal weight, IWeaponHandlerFactory weaponFactory) : base(name, role, age, weight)
        {
            this.weapontFactory = weaponFactory;
        }

        public void RobBank()
        {
            var now = DateTime.Now;
            MessageBox.Show($"Good deal, just robbed a bank on {now.DayOfWeek}, at {now:HH:mm}! Got $$$$!");
        }

        public void StealCar()
        {
            var now = DateTime.Now;
            MessageBox.Show($"Got a new ride on {now.DayOfWeek}, at {now:HH:mm}!");
        }

        public override string Speak()
        {
            return ("I rob, therefore I am!");
        }

        public void Attack(Handgun handgun)
        {
            var handgunHandler = weapontFactory.Create<Handgun>();
            handgunHandler.Attack(handgun);
            weapontFactory.Release(handgunHandler);

        }

       
    }
}
