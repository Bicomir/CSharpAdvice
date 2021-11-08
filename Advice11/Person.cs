namespace Advice11
{
    class Person
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
    }
}
