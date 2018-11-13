using DiWithInterceptors.DomainObjects;

namespace DiWithInterceptors.Interfaces
{
    public interface IPoliceOfficer
    {
        void Arrest();
        void Shoot();
        string Name { get; set; }
        Ethnicity Ethnicity { get; set; }
        string Speak();
        void Sleep();
        void Eat();
    }
}
