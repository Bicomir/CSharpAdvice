using System;

namespace Advice13
{
    class Person : IFormattable
    {
        public string IDCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // 实现接口IFormattable的方法ToString()
        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case "ch":
                    return this.ToString();
                case "eg":
                    return string.Format("{0} {1}", FirstName, LastName);
                default:
                    // return this.ToString();
                    ICustomFormatter customFormatter = formatProvider as ICustomFormatter;
                    if (customFormatter == null)
                    {
                        return this.ToString();
                    }
                    return customFormatter.Format(format, this, null);
            }
        }

        // 重写Object.ToString()
        public override string ToString()
        {
            return string.Format("{0} {1}", LastName, FirstName);
        }
    }
}
