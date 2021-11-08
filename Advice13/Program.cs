using System;

namespace Advice13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { FirstName="Bomir", LastName="Wang", IDCode="Morn423" };
            Console.WriteLine(person);
            Console.WriteLine(person.ToString("ch", null));
            Console.WriteLine(person.ToString("eg", null));
        }
    }
}
