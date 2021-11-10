using System;
using System.Threading;

namespace Advice75
{
    internal class Program
    {
        static int _id = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++, _id++)
            {
                NewMethod(i, _id);
            }
            Console.ReadLine();
        }

        private static void NewMethod(int i, int realTimeID)
        {
            Thread t = new Thread(() =>
            {
                Console.WriteLine(string.Format("{0}:{1}", Thread.CurrentThread.Name, realTimeID));
            });
            t.Name = string.Format("Thread{0}", i);
            t.IsBackground = true;
            t.Start();
        }
    }
}
