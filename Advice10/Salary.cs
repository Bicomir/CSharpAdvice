using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advice10
{
    class Salary : IComparable
    {
        public string Name { get; set; }
        public int BaseSalary { get; set; }
        public int Bonus { get; set; }
        public int CompareTo(object obj)
        {
            Salary staff = obj as Salary;
            return BaseSalary.CompareTo(staff.BaseSalary);
        }
    }
}
