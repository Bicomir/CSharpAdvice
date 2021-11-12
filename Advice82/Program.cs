using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advice82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(() =>
            {
                while (true)
                {

                }
            });
            t.Start();
            Console.WriteLine("主线程即将结束");
            Console.ReadKey();
        }
    }
}
