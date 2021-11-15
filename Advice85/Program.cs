using System;
using System.Threading.Tasks;

namespace Advice85
{
    
    

    public class Program
    {
        public class AggregateExceptionArgs : EventArgs
        {
            public AggregateException AggregateException { get; set; }
        }

        static event EventHandler<AggregateExceptionArgs> AggregateExceptionCatched;
        static void Main(string[] args)
        {
            AggregateExceptionCatched += EventHandler<AggregateExceptionArgs>(Program_AggregateExceptionCatched);
            Task t = new Task(() => 
            {
                try
                {
                    throw new Exception("任务并行编码时候产生的未知异常");
                }
                catch (Exception err)
                {
                    AggregateExceptionArgs errArgs = new AggregateExceptionArgs { AggregateException = new AggregateException(err) };
                    AggregateExceptionCatched(null, errArgs);
                }
                
            });
            t.Start();

          

            Console.WriteLine("主线程马上结束!");
            Console.ReadKey();
        }

        private static EventHandler<T> EventHandler<T>(Action<object, T> program_AggregateExceptionCatched)
        {
            throw new NotImplementedException();
        }

        static void Program_AggregateExceptionCatched(object sender, AggregateExceptionArgs e)
        {
            foreach (var item in e.AggregateException.InnerExceptions)
            {
                Console.WriteLine("ExceptionType: {0} {1} from {2} {3} Exception Content:{4}", item.GetType(), Environment.NewLine, item.Source, Environment.NewLine, item.Message);
            }
        }
    }

    
}
