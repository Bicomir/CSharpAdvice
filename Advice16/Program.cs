using System;

namespace Advice16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new int[] { 0, 1, 2, 3, 4, 5, 6};
            iArr = (int[])iArr.Resize(10);

            for (int i = 0; i < iArr.Length; i++)
            {
                Console.WriteLine(iArr[i]);
            }
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
