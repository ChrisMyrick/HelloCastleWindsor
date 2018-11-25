using System;
using System.Windows.Forms;
using CastleWindsorDI_Example.Interfaces;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class Criminal : Person, ICriminal, IDisposable
    {
        IWeaponHandlerFactory weaponFactory;

        public IWeaponHandler<Handgun> WeaponHandler { get; set; }

        public Criminal(string name, string role, int age, decimal weight, IWeaponHandlerFactory weaponFactory) : base(name, role, age, weight)
        {
            this.weaponFactory = weaponFactory;
            WeaponHandler = this.weaponFactory.Create<Handgun>("I am a criminal gun handler.");

            
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
            WeaponHandler.Attack(handgun);
        }

        public void ShowWeaponDescription()
        {
            MessageBox.Show(WeaponHandler.GetDescription());
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                weaponFactory.Dispose();
            }
            // free native resources if there are any.
            //if (nativeResource != IntPtr.Zero)
            //{
            //    Marshal.FreeHGlobal(nativeResource);
            //    nativeResource = IntPtr.Zero;
            //}
        }
    }
}
