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
        public int Compare<T>(T t1, T t2) where T : Salary
        {
            if (t1.BaseSalary > t2.BaseSalary)
            {
                return 1;
            }
            else if (t1.BaseSalary == t2.BaseSalary)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        } 
    }
}
