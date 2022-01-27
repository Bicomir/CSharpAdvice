using System;

namespace Advice42
{
    class Program
    {
        static void Main(string[] args)
        {
            ISalary<Programmer> s = new BaseSalaryCounter<Programmer>();
            ISalary<Manager> t = new BaseSalaryCounter<Manager>();
            PrintSalary(s);
            PrintSalary(t);
            Console.ReadLine();
        }

        static void PrintSalary(ISalary<Employee> s)
        {
            s.Pay();
        }
    }

    interface ISalary<out T>
    {
        void Pay();
    }


    class BaseSalaryCounter<T> : ISalary<T>
    {
        public void Pay()
        {
            Console.WriteLine("Pay base salary");
        }
    }

    class Employee
    {
        public string Name { get; set; }
    }

    class Programmer : Employee
    {

    }

    class Manager : Employee
    {

    }
}
