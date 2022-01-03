using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advice34
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Salary
    {
        public string Name { get; set; }

        public int BaseSalary { get; set; }

        public int Bonus { get; set; }
    }

    public class SalaryComputer
    {
        public int Compare<T>(T t1, T t2)
        {
            return 0;
        } 
    }
}
