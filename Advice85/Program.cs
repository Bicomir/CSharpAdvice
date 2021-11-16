using System;
using System.Threading.Tasks;

namespace Advice85
{
    public class Program
    {
        static void Main()
        {
            TaskScheduler.UnobservedTaskException += new EventHandler<
                UnobservedTaskExceptionEventArgs>(TaskScheduler_UnobservedTaskException);
            Task t = new Task(() =>
            {
                throw new Exception("任务并行编码中产生的未知异常");
            });
            t.Start();
            Console.ReadKey();
            t.Dispose();
            t = null;
            GC.Collect(0);  
            Console.WriteLine("主线程马上结束");
            Console.ReadKey();
        }

        static void TaskScheduler_UnobservedTaskException(object sender,
            UnobservedTaskExceptionEventArgs e)
        {
            foreach (Exception item in e.Exception.InnerExceptions)
            {
                Console.WriteLine("异常类型：{0}{1}来自：{2}{3}异常内容：{4}",
                    item.GetType(), Environment.NewLine, item.Source,
                    Environment.NewLine, item.Message);
            }
            //将异常标识为已经观察到  
            e.SetObserved();
        }
    }
}
