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
            // 在这里也可以使用Invoke方法
            Parallel.For(0, 1, (i) =>
            {
                while (true)
                {

                }
            });

            Console.WriteLine("主线程即将结束");
            Console.ReadKey();
        }
    }
}
