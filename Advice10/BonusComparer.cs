using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advice10
{
    class BonusComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Salary s1 = x as Salary;
            Salary s2 = y as Salary;
            return s1.Bonus.CompareTo(s2.Bonus);
        }
    }
}
