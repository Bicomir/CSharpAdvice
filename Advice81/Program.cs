using System;
using System.Threading.Tasks;

namespace Advice81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5};
            Parallel.For(0, nums.Length, i => 
            { 
                Console.WriteLine("ArrayIndex{0} -> Element{1}", i, nums[i]);
            });
            Console.ReadKey();
        }
    }
}
