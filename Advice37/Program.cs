using System;

namespace Advice37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = new Func<int, int, int>(delegate (int i, int j)
            {
                return i + j;
            });

            Action<string> print = new Action<string>(delegate (string msg)
            {
                Console.WriteLine(msg);
            });

            print(add(1, 2).ToString());
        }
    }
}
