using System;

namespace Advice15
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamic = new DynamicSample();
            int re = dynamic.Add(1, 2);
            Console.WriteLine(re);
        }
    }
}
