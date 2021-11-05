using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advice10
{
    class Salary : IComparable<Salary>
    {
        public string Name { get; set; }
        public int BaseSalary { get; set; }
        public int Bonus { get; set; }

        public int CompareTo(Salary staff)
        {
            return BaseSalary.CompareTo(staff.BaseSalary);
        }
    }
}
