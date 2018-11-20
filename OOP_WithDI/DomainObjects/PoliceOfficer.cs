using System.Windows.Forms;
using CastleWindsorDI_Example.Interfaces;


namespace CastleWindsorDI_Example.DomainObjects
{
    public class PoliceOfficer : Person, IPoliceOfficer
    {
        public PoliceOfficer(string name, string role, int age, decimal weight) : base(name, role, age, weight)
        {
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
    }
}
