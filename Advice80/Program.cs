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
            TaskFactory taskFactory = new TaskFactory();
            Task[] tasks = new Task[]
            {
                taskFactory.StartNew(() => Add(cts.Token)),
                taskFactory.StartNew(() => Add(cts.Token)),
                taskFactory.StartNew(() => Add(cts.Token)),
            };

            // CancellationToken.None, 指示TasksEnded不能被取消
            taskFactory.ContinueWhenAll(tasks, TaskEnded, CancellationToken.None);
            Console.ReadKey();
            cts.Cancel();
            Console.ReadKey();
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

        private static void TaskEnded(Task[] task)
        {
            Console.WriteLine("所有任务已完成！");
        }

    }
}
