using System;

namespace Advice14
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bomir = new Employee()
            {
                IDCode = "morn423",
                Age = 30,
                Department = new Department() { Name = "Dep1" }
            };

            Employee kiki = bomir.Clone() as Employee;
            Console.WriteLine(kiki.IDCode);
            Console.WriteLine(kiki.Age);
            Console.WriteLine(kiki.Department);

            Console.WriteLine("开始改变bomir的值: ");
            bomir.IDCode = "morn456";
            bomir.Age = 22;
            bomir.Department.Name = "Dep2";

            Console.WriteLine(kiki.IDCode);
            Console.WriteLine(kiki.Age);
            Console.WriteLine(kiki.Department);
        }
    }
}
