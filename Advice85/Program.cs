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
                throw new Exception("任务并行编码时候产生的未知异常");
            });
            t.Start();

            Task ttEnd = t.ContinueWith((task) =>
            {
                throw task.Exception; 
            }, TaskContinuationOptions.OnlyOnFaulted);

            try
            {
                ttEnd.Wait();
            }
            catch (AggregateException err)
            {
                foreach (var item in err.InnerExceptions)
                {
                    Console.WriteLine("ExceptionType: {0} {1} from {2} {3} Exception Content:{4}", item.InnerException.GetType(), Environment.NewLine, item.InnerException.Source, Environment.NewLine, item.InnerException.Message);
                }
            }

            Console.WriteLine("主线程马上结束!");
            Console.ReadKey();
        }
    }
}
