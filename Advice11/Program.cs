using System;

namespace Advice11
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = new Person("NB123");
            object b = new Person("NB123");

            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));
        }
    }
}
