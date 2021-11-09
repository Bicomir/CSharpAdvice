using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Advice14
{
    [Serializable]
    class Employee : ICloneable
    {
        public string IDCode { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public Employee DeepClone()
        {
            using (Stream objectstram = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectstram, this);
                objectstram.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objectstram) as Employee;
            }
        }

        public Employee ShallowClone()
        {
            return Clone() as Employee;
        }
    }

    [Serializable]
    public class Department
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
