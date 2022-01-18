using System;

namespace Advice33
{
    public class MyList
    {
        public static int Count { get; set; }

        public static int Func<T>()
        {
            return Count++;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyList.Func<int>());
            Console.WriteLine(MyList.Func<int>());
            Console.WriteLine(MyList.Func<string>());

            Console.ReadLine();
        }
    }
}
