using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Advice16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            ArrayList arrayList = new ArrayList(iArr);

            arrayList.Add(10);
            List<int> listInt = iArr.ToList();
            listInt.Add(10);

            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            listInt.ForEach(x => Console.Write(x + " "));
        }
    }
}
