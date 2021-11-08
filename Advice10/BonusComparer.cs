using System.Collections.Generic;

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
