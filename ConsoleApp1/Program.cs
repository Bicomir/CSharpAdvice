using System;

namespace Advice33
{
    public class MyList<T>
    {
        public static int Count { get; set; }

        public MyList()
        {
            Count++;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList1 = new MyList<int>();
            MyList<int> myList2 = new MyList<int>();

            MyList<string> myList3 = new MyList<string>();

            Console.WriteLine(MyList<int>.Count);
            Console.WriteLine(MyList<string>.Count);
            Console.ReadLine();
        }
    }
}
