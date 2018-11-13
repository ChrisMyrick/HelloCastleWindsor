using DiWithInterceptors.Interfaces;

namespace DiWithInterceptors.DomainObjects
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
