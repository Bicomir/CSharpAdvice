using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvice
{
    class Program
    {
        static Week week;
        static void Main(string[] args)
        {
            Console.WriteLine(week);

        }

        static void Test()
        {
            int res;
            long ticks;

            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 1; i < 1000; i++)
            {
                try
                {
                    res = int.Parse("123");
                }
                catch
                {
                    res = 0;
                }
            }
            sw.Stop();
            ticks = sw.ElapsedTicks;
            Console.WriteLine("int.Parse() 成功, {0} ticks", ticks);
            
            
            sw = Stopwatch.StartNew();
            for (int i = 1; i < 1000; i++)
            {
                if (int.TryParse("123", out res) == false)
                {
                    res = 0;
                }
            }
            sw.Stop();
            ticks = sw.ElapsedTicks;
            Console.WriteLine("int.TryParse() 成功， {0} ticks", ticks);

            sw = Stopwatch.StartNew();
            for (int i = 1; i < 1000; i++)
            {
                try
                {
                    res = int.Parse("aaa");
                }
                catch
                {
                    res = 0;
                }
            }
            sw.Stop();
            ticks = sw.ElapsedTicks;
            Console.WriteLine("int.Parse() 失败, {0} ticks", ticks);


            sw = Stopwatch.StartNew();
            for (int i = 1; i < 1000; i++)
            {
                if (int.TryParse("aaa", out res) == false)
                {
                    res = 0;
                }
            }
            sw.Stop();
            ticks = sw.ElapsedTicks;
            Console.WriteLine("int.TryParse() 失败， {0} ticks", ticks);
        }
    }

    enum Week
    {
        Money = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    class Sample
    {
        public readonly int ReadOnlyValue;
        public Sample(int value)
        {
            ReadOnlyValue = value;
        }
    }
}
