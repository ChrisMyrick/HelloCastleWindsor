using System;
using System.Windows.Forms;
using CastleWindsorDI_Example.Interfaces;


namespace CastleWindsorDI_Example.DomainObjects
{
    public class PoliceOfficer : IPoliceOfficer, IDisposable
    {
        private IPerson person = null;
        private IWeaponHandlerFactory weaponFactory;
        private IWeaponHandler<FireThrower> WeaponHandler { get; set; }


        public string Name { get => person.Name; }
        public Ethnicity Ethnicity { get => person.Ethnicity; set => person.Ethnicity = value;}

        public PoliceOfficer(IWeaponHandlerFactory weaponFactory)
        {
            
            this.weaponFactory = weaponFactory;
            WeaponHandler = this.weaponFactory.Create<FireThrower>("I am a polic fire throw handler.");

        }

        public void Personify(IPerson person)
        {
            this.person = person;
        }

        public void Arrest()
        {
            MessageBox.Show("Hands above your head!!!");
        }

        public void Shoot()
        {
            MessageBox.Show("Shots fired!");
        }

        // Notice that we don't delegate to the person's speack method. 
        // Effectively equivalent to override if we inherited from Person.
        public string Speak()
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
