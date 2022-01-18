using System;

namespace Advice37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = new Func<int, int, int>(Add);
            Action<string> print = new Action<string>(Print);

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
