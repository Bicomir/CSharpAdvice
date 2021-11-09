using System;

namespace Advice14
{
    class Employee : ICloneable
    {
        public string IDCode { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class Department
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
