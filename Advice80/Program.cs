using System;
using System.Threading;
using System.Threading.Tasks;

namespace Advice80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Task<int> t = new Task<int>(() => Add(cts.Token), cts.Token);
            t.Start();
            t.ContinueWith(TaskEnd);

            // 等待按任意键取消任务
            Console.ReadKey();
            cts.Cancel();
            Console.ReadKey();
        }

        private static void TaskEnd(Task<int> task)
        {
            Console.WriteLine("任务完成，完成时候的状态为: ");
            Console.WriteLine("IsCanceled={0}\tIsCompleted={1}\tIsFaulted={2}", task.IsCanceled, task.IsCompleted, task.IsFaulted);
            Console.WriteLine("任务的返回值为: {0}", task.Result);
        }

        private static int Add(CancellationToken ct)
        {
            Console.WriteLine("任务开始...");
            int result = 0;
            while (!ct.IsCancellationRequested)
            {
                result++;
                Thread.Sleep(1000);
            }
            return result;
        }
    }
}
