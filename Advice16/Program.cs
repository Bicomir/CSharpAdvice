using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Advice16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResizeArray();
            ResizeList();
        }

        private static void ResizeArray()
        {
            int[] iArr = { 0, 1, 2, 3, 4, 5, 6 };
            Stopwatch watch = new Stopwatch();
            watch.Start();
            iArr = (int[])iArr.Resize(10);
            watch.Stop();
            Console.WriteLine("ResizeArray: " + watch.Elapsed);
        }

        private static void ResizeList()
        {
            List<int> iArr = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });
            Stopwatch watch = new Stopwatch();
            watch.Start();
            iArr.Add(0);
            iArr.Add(0);
            iArr.Add(0);
            watch.Stop();
            Console.WriteLine("ResizeList: " + watch.Elapsed);
        }
    }

    public static class ClassForExtensions
    {
        public static Array Resize(this Array array, int newSize)
        {
            Type t = array.GetType().GetElementType();
            Array newArray = Array.CreateInstance(t, newSize);
            Array.Copy(array, 0, newArray, 0, Math.Min(array.Length, newSize));
            return newArray;
        }
    }
}
