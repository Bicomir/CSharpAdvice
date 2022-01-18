using System;

namespace Advice36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Add;
            Action<string> print = Print;

            print(add(1, 2).ToString());
        }

        static int Add(int i, int j)
        {
            return i + j;
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
