using System;
using System.Threading;
using System.Threading.Tasks;

namespace Advice83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int total = 0;
            Parallel.For<int>(0, nums.Length, () => 
            {
                return 1;    
            }, (i, loopState, subtotal) =>
            {
                subtotal += nums[i];
                return subtotal;
            },
            (x) => Interlocked.Add(ref total, x));

            Console.WriteLine("total={0}", total);
            Console.ReadKey();
        }
    }
}
