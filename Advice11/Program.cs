using System;
using System.Collections.Generic;

namespace Advice11
{
    class Program
    {
        static Dictionary<Person, PersonMoreInfo> PersonValues = new Dictionary<Person, PersonMoreInfo>();
        static void Main(string[] args)
        {
            //AddPerson();
            //Person bomir = new Person("morn423");
            //// Console.WriteLine(bomir.GetHashCode());
            //Console.WriteLine(PersonValues.ContainsKey(bomir));
            string str1 = "NB0903100006";
            string str2 = "NB0904140001";
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
        }

        static void AddPerson()
        {
            Person bomir = new Person("morn423");
            PersonMoreInfo bomirValue = new PersonMoreInfo() { SomeInfo = "Bomir's Info" };
            PersonValues.Add(bomir, bomirValue);
            // Console.WriteLine(bomir.GetHashCode());
            Console.WriteLine(PersonValues.ContainsKey(bomir));
        }
    }

    public class PersonMoreInfo
    {
        public string SomeInfo { get; set; }
    }
}
