using System;
using System.Threading.Tasks;

namespace Advice81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
            () => 
            {
                Console.WriteLine("任务1......");
            },
            () =>
            {
                Console.WriteLine("任务2......");
            },
            () =>
            {
                Console.WriteLine("任务3......");
            },
            () =>
            {
                Console.WriteLine("任务4......");
            });
            Console.ReadKey();
        }
    }
}
