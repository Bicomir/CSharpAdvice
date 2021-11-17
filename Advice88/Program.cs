using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Advice88
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            DoInFor();
            watch.Stop();

            Console.WriteLine("Sync Cost time:{0}", watch.Elapsed);

            watch.Restart();
            DoInParalleFor();
            watch.Stop();
            Console.WriteLine("Parallel Cost time:{0}", watch.Elapsed);

        }

        static void DoSometing()
        {
            for (int i = 0; i < 10000000; i++)
            {
                i++;
            }
        }

        static void DoInFor()
        {
            for (int i = 0; i < 200; i++)
            {
                DoSometing();
            }
        }

        static void DoInParalleFor()
        {
            Parallel.For(0, 200, (i) => 
            {
                DoSometing();
            });
        }
    }
}
