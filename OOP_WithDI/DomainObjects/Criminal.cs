using CastleWindsorDI_Example.Interfaces;

namespace CastleWindsorDI_Example.DomainObjects
{
    public class Criminal : Person, ICriminal
    {
        public Criminal(string name, int age, decimal weight) : base(name, age, weight)
        {
        }

        public void RobBank()
        {

        }

        public void StealCar()
        {

        }
    }
}
