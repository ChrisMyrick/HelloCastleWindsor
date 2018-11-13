using DiWithInterceptors.Interfaces;

namespace DiWithInterceptors.DomainObjects
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
