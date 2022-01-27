using System;
using System.Collections.Generic;

namespace Advice42
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Programmer> programmers = new List<Programmer>();
            IList<Manager> managers = new List<Manager>();
            PrintPersonName(programmers);
            PrintPersonName(managers);
        }

        static void PrintSalary(ISalary<Employee> s)
        {
            s.Pay();
        }

        static void PrintPersonName(IEnumerable<Employee> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
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
