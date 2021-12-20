using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advice93
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Company
    {
        Employee specialA = new Employee() { Name = "mike" };
        Employee specialB;
        public Employee CEO { get; set; }

        public Company()
        {
            CEO = new Employee() { Name = "steve" };
            specialB = new Employee() { Name = "rose" };
        }

    }

    internal class Employee
    {
        public string Name { get; set; }
    }
}
