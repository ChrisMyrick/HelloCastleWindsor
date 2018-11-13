using DiWithInterceptors.DomainObjects;

namespace DiWithInterceptors.Interfaces
{
    public interface ICriminal
    {
        void RobBank();
        void StealCar();
        string Name { get; set; }
        Ethnicity Ethnicity { get; set; }
        string Speak();
        void Sleep();
        void Eat();
    }
}
