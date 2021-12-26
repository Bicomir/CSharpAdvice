using System;

namespace Advice94
{
    public class Shape
    {
        public virtual void MethodVirtual()
        {
            Console.WriteLine("base MethodVirtual call");
        }

        public void Method()
        {
            Console.WriteLine("base method call");
        }
    }

    class Circle : Shape
    {
        public override void MethodVirtual()
        {
            Console.WriteLine("circle override MethodVirtual");
        }
    }

    class Rectangle : Shape
    {

    }

    class Triangle : Shape
    {
        public new void MethodVirtual()
        {
            Console.WriteLine("triangle new MethodVirtual");
        }

        public new void Method()
        {
            Console.WriteLine("triangle new Method");
        }
    }

    class Diamond : Shape
    {
        public void MethodVirtual()
        {
            Console.WriteLine("Diamond default MethodVirtual");
        }

        public void Method()
        {
            Console.WriteLine("Diamond default Method");
        }
    }

}
