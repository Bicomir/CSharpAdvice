using System;
using System.Collections.Generic;
using System.Linq;

namespace Advice84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intlist = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var query = from p in intlist select p;
            Console.WriteLine("以下是LINQ的输出: ");
            foreach (var item in query)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("以下是PLINQ的输出: ");
            var queryParallel = from p in intlist.AsParallel().AsOrdered() select p;
            foreach (var item in queryParallel)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("**************Split Line****************");

            queryParallel.ForAll((item) =>
            {
                Console.WriteLine(item.ToString());
            });
        }
    }
}
