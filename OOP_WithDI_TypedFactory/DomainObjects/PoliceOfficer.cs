using System;
using System.Windows.Forms;
using CastleWindsorDI_Example.Interfaces;


namespace CastleWindsorDI_Example.DomainObjects
{
    public class PoliceOfficer : Person, IPoliceOfficer, IDisposable
    {
        IWeaponHandlerFactory weaponFactory;

        public IWeaponHandler<FireThrower> WeaponHandler { get; set; }

        public PoliceOfficer(string name, string role, int age, decimal weight, IWeaponHandlerFactory weaponFactory) : base(name, role, age, weight)
        {
            this.weaponFactory = weaponFactory;
            WeaponHandler = this.weaponFactory.Create<FireThrower>("I am a polic fire throw handler.");
        }

        public void Arrest()
        {
            MessageBox.Show("Hands above your head!!!");
        }

        public void Shoot()
        {
            MessageBox.Show("Shots fired!");
        }

        public override string Speak()
        {
            return ("I serve and protect, therefore I am.");
        }

        public void Attack(FireThrower fireThrower)
        {
            WeaponHandler.Attack(fireThrower);
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
