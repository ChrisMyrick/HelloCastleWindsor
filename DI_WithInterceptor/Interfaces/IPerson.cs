using DiWithInterceptors.DomainObjects;

namespace DiWithInterceptors.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        Ethnicity Ethnicity { get; set; }

        string Speak();
        void Sleep();
        void Eat();
    }
}
