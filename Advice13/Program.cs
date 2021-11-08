using System;

namespace Advice13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { FirstName="Bomir", LastName="Wang", IDCode="Morn423" };

            PersonFomartter pFomartter = new PersonFomartter();
            // 从第一类格式化输出语法
            Console.WriteLine(pFomartter.Format("ch", person, null));
            Console.WriteLine(pFomartter.Format("eg", person, null));
            Console.WriteLine(pFomartter.Format("chM", person, null));

            // 从第二类格式化输出语法, 更简洁
            Console.WriteLine(person.ToString("ch", pFomartter));
            Console.WriteLine(person.ToString("eg", pFomartter));
            Console.WriteLine(person.ToString("chM", pFomartter));
        }
    }
}
