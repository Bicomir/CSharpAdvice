using System;
using System.Collections.Generic;

namespace Advice38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Action> lists = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                Action t = () =>
                {
                    Console.WriteLine(i.ToString());
                };
                lists.Add(t);
            }

            foreach (var t in lists)
            {
                t();
            }
        }
    }
}
