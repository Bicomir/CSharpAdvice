using System;
using System.Threading.Tasks;

namespace Advice89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass sample = new SampleClass();
            object syncObj = new object();
            Parallel.For(0, 10000000, (i) =>
            {
                lock (syncObj)
                {
                    sample.SimpleAdd();
                }

            });
            Console.WriteLine(sample.SomeCount);
        }
    }

    internal class SampleClass
    {
        public long SomeCount { get; private set; }

        public void SimpleAdd()
        {
            SomeCount++;
        }
    }
}
