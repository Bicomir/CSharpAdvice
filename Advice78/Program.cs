using System;
using System.Threading;

namespace Advice78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 200; i++)
            {
                Thread t = new Thread(() => 
                {
                    int j = i;
                    while (true)
                    {
                        j++;
                    }
                    t.IsBackground = true;
                    t.Start();
                });
            }

            Thread.Sleep(5000);
            Thread T201 = new Thread(() => 
            {
                while (true)
                {
                    Console.WriteLine("T201正在执行！");
                }
            });
            T201.Start();
            Console.ReadKey();
        }
    }
}
