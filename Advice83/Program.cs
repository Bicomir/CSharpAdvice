using System;
using System.Threading.Tasks;

namespace Advice83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = new string[] { "aa", "bb", "cc", "dd", "ee", "ff", "gg", "hh"};
            string result = string.Empty;
            Parallel.For(0, stringArr.Length, () => "-", (i, loopState, subResult) =>
            {
                return subResult += stringArr[i];
            }, (threadEndString) =>
            {
                result += threadEndString;
                Console.WriteLine("Inner:" + threadEndString);
            });

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
