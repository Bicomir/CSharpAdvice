using System;

namespace Advice94
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle s = new Circle();
            //s.MethodVirtual();
            //s.Method();

            //Shape s = new Triangle();
            //s.MethodVirtual();
            //s.Method();

            //Triangle triangle = new Triangle();
            //triangle.MethodVirtual();
            //triangle.Method();

            Diamond s = new Diamond();
            s.MethodVirtual();
            s.Method();
        }
    }
}
