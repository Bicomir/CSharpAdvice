using System;

namespace Advice37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (i, j) => i + j;

            Action<string> print = msg => Console.WriteLine(msg);

            print(add(1, 2).ToString());
        }
    }
}
