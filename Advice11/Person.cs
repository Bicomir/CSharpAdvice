using System;

namespace Advice11
{
    class Person : IEquatable<Person>
    {
        public string ID { get; private set; }
        public Person(string id)
        {
            this.ID = id;
        }

        public override bool Equals(object obj)
        {
            return ID == (obj as Person).ID;
        }

        public override int GetHashCode()
        {
            return (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName + "#" + this.ID).GetHashCode();
        }

        public bool Equals(Person other)
        {
            return ID == other.ID;
        }
    }
}
