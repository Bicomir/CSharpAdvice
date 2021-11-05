using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advice10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Salary> companySalary = new List<Salary>();
            companySalary.Add(new Salary() { Name = "Mike", BaseSalary = 3000, Bonus = 1000, });
            companySalary.Add(new Salary() { Name = "Rose", BaseSalary = 2000, Bonus = 4000 });
            companySalary.Add(new Salary() { Name = "Jeffry", BaseSalary = 1000, Bonus = 6000 });
            companySalary.Add(new Salary() { Name = "Steve", BaseSalary = 4000, Bonus = 3000 });
            companySalary.Sort(new BonusComparer());    // 提供一个非默认的比较器

            foreach (Salary item in companySalary)
            {
                Console.WriteLine(item.Name + "\t BaseSalary: " + item.BaseSalary.ToString() + "\t Bonus: " + item.Bonus);
            }
        }
    }
}
