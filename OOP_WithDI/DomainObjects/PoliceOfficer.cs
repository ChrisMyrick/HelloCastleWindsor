using CastleWindsorDI_Example.Interfaces;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class PoliceOfficer : Person, IPoliceOfficer
    {
        public PoliceOfficer(string name, int age, decimal weight) : base(name, age, weight)
        {
        }

        public void Arrest()
        {

        }

        public void Shoot()
        {

        }
    }
}
