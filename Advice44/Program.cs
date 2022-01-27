using System;

namespace Advice44
{
    class Program
    {
        public delegate T GetEmployeeHandler<T>(string name);

        static void Main(string[] args)
        {
            GetEmployeeHandler<Employee> getAEmployee = GetAManager;
            Employee e = getAEmployee("bomin");
            Console.ReadLine();
        }

        static Manager GetAManager(string name)
        {
            Console.WriteLine("我是经理" + name);
            return new Manager() { Name = name };
        }

        static Employee GetAEmployee(string name)
        {
            Console.WriteLine("我是雇员: " + name);
            return new Employee() { Name = name };
        }

    }

    class Employee
    {
        public string Name { get; set; }
    }

    class Manager : Employee
    {
    }
}
