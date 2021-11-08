using System;

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
