using System;
using System.Threading.Tasks;

namespace Advice85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(() => 
            {
                throw new Exception("任务并行时候产生的异常");
            });
            t.Start();

            try
            {
                // 若有Result， 可求Result
                t.Wait();
            }
            catch (AggregateException e)
            {
                foreach (var item in e.InnerExceptions)
                {
                    Console.WriteLine("ExceptionType: {0}{1} from {2}{3} Exception Content:{4}", item.GetType(), Environment.NewLine, item.Source, Environment.NewLine, item.Message);
                }
            }
            Console.WriteLine("主线程马上结束!");
            Console.ReadKey();
        }
    }
}
