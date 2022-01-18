using System;

namespace Advice95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            American american = new American();
            Console.ReadKey();
        }
    }

    class Person
    {
        public Person()
        {
            InitSkin();
        }

        protected virtual void InitSkin()
        {
            throw new NotImplementedException();
        }
    }

    class American : Person
    {
        Race race;

        public American() : base()
        {
            race = new Race()
            {
                Name = "White"
            };
        }

        protected override void InitSkin()
        {
            Console.WriteLine(race.Name);
        }

    }

    class Race
    {
        public string Name { get; set; }
    }
}
