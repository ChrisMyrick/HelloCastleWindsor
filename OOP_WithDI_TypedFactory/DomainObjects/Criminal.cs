using System;
using System.Windows.Forms;
using CastleWindsorDI_Example.Interfaces;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class Criminal : ICriminal, IDisposable
    {

        private IPerson person = null;
        private IWeaponHandlerFactory weaponFactory;
        private IWeaponHandler<Handgun> WeaponHandler { get; set; }

        public string Name { get => person.Name; }
        public Ethnicity Ethnicity { get => person.Ethnicity; set => person.Ethnicity = value; }

  
        public Criminal(IWeaponHandlerFactory weaponFactory)
        {
            this.weaponFactory = weaponFactory;
            WeaponHandler = this.weaponFactory.Create<Handgun>("I am a criminal gun handler.");

        }

        public void Personify(IPerson person)
        {
            this.person = person;
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

        // Notice that we don't delegate to the person's speack method. 
        // Effectively equivalent to override if we inherited from Person.
        public string Speak()
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

        // Delegate the following to person

        public string WhomAmI() => this.person.WhomAmI();
        public void Sleep() => this.person.Sleep();
        public void Eat() => this.person.Eat();


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
