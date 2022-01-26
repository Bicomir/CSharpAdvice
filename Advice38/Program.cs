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
                TempClass tempClass = new TempClass();
                tempClass.i = i;
                Action t = tempClass.TempFunc;
                lists.Add(t);
            }

            foreach (var t in lists)
            {
                t();
            }
        }
    }

    class TempClass
    {
        public int i;

        public void TempFunc()
        {
            Console.WriteLine(i.ToString());
        }
    }
}
