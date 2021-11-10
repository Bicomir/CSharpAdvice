using System;
using System.Threading;

namespace Advice74
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() =>
            {
                Console.WriteLine("线程开始工作...");
                // 省略工作代码
              //  Console.ReadKey();
                Console.WriteLine("线程结束");
            });

            // 注意， 默认为false
            t.IsBackground = true;
            t.Start();
            Console.WriteLine("主线程完毕!");
        }
    }
}
