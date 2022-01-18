using System;

namespace Advice36
{
    internal class Program
    {
        delegate int AddHandler(int i, int j);
        delegate void PrintHandler(string msg);

        static void Main(string[] args)
        {
            AddHandler add = Add;
            PrintHandler print = Print;

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
