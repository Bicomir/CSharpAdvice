using System;
using System.Threading;

namespace Advice77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Thread t = new Thread(() =>
            {
                while (true)
                {
                    if (cts.Token.IsCancellationRequested)
                    {
                        Console.WriteLine("线程被终止! ");
                        break;
                    }
                    Console.WriteLine(DateTime.Now.ToString());
                    Thread.Sleep(1000);

                    //cts.Token.Register(() =>
                    //{
                    //    Console.WriteLine("工作线程被终止了.");
                    //});
                }
            });
            t.Start();
            Console.ReadLine();
            cts.Cancel();
        }
    }
}
