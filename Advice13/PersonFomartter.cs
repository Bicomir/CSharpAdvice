using System;

namespace Advice13
{
    class PersonFomartter : IFormatProvider, ICustomFormatter
    {
        // ICustomFormatter的成员
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            Person person = arg as Person;
            if (person == null)
            {
                return string.Empty;
            }
            switch (format)
            {
                case "ch":
                    return string.Format("{0} {1}", person.LastName, person.FirstName);
                case "eg":
                    return string.Format("{0} {1}", person.FirstName, person.LastName);
                case "chM":
                    return string.Format("{0} {1} : {2}", person.FirstName, person.LastName, person.IDCode);
                default:
                    return string.Format("{0} {1}", person.FirstName, person.LastName);
            }
        }

        // IFormatProvider的成员
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }
    }
}
