using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advice10
{
    class BonusComparer : IComparer<Salary>
    {
        public int Compare(Salary x, Salary y)
        {
            return x.Bonus.CompareTo(y.Bonus);
        }
    }
}
