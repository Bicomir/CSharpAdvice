using System;

namespace Advice15
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicSample dynamicSample = new DynamicSample();
            var addMethod = typeof(DynamicSample).GetMethod("Add");
            int re = (int)addMethod.Invoke(dynamicSample, new object[] { 1, 2 });
            Console.WriteLine(re);
        }
    }
}
