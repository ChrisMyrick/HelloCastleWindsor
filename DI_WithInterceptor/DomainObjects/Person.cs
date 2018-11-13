using System.Windows.Forms;
using DiWithInterceptors.Interfaces;

namespace DiWithInterceptors.DomainObjects
{
    public class Person : Mammal, ICanSpeak, IPerson
    {
        // abstract classes can have fields on it, but interfaces cannot.
        // an abstract class is a class, but an interface is often considered a contract.
        // an interface defines what something can do, but abstract classes define what something is.
        public string Name { get; set; }
        public Ethnicity Ethnicity { get; set; }

        public Person(string name, int age, decimal weight)
        {
            Name = name;
            base.Age = age;
            base.Weight = weight;
        }

        public string Speak()
        {
            return "I think, therefore I am.";
        }

        public override void Sleep()
        {
            var hours = 8;
            MessageBox.Show($"Yawn. I slept for {0} hours.", hours.ToString());
        }

        public override void Eat()
        {
            MessageBox.Show("I ate until I was satisfied, and not a bit more.");
        }

    }

    public enum Ethnicity
    {
        Asian,
        African,
        Caucasian,
        Hispanic,
        NativeAmerican,
        PacificIslander
    }
}
