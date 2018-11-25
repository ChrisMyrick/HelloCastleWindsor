using System.Windows.Forms;
using CastleWindsorDI_Example.Interfaces;


namespace CastleWindsorDI_Example.DomainObjects
{
    public class PoliceOfficer : Person, IPoliceOfficer
    {
        IWeaponHandlerFactory weaponFactory;

        public PoliceOfficer(string name, string role, int age, decimal weight, IWeaponHandlerFactory weaponFactory) : base(name, role, age, weight)
        {
            this.weaponFactory = weaponFactory;
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
           
            var fireThrowerHandler = weaponFactory.Create<FireThrower>();
            fireThrowerHandler.Attack(fireThrower);
            weaponFactory.Release(fireThrowerHandler);
        }
    }
}
