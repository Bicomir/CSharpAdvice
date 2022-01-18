using System;
using System.Collections.Generic;

namespace Advice35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new List<int>() { 1,2,2,3,3,3,3,35,56,7};
            list.Find(v => v > 6);
        }
    }

    public T Func<T>()
    {
        //T t = null;
        //return t;

        //T t = 0;
        //return t;

        T t = default(T);
        return t;
    }
}
