namespace DiWithInterceptors.DomainObjects
{
    public abstract class Mammal
    {
        public Gender MammalGender;
        public int Age;
        public decimal Weight;
        public decimal Temperature = 98.6M;

        public abstract void Sleep();
        public abstract void Eat();
    }

    public enum Gender{
        Male,
        Female
    }
}
