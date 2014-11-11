using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs
{

    public class ReviewedAttribute : Attribute
    {
        public ReviewedAttribute(int year, int month, int day, string name)
        {
            this.Date = new DateTime(year, month, day);
            this.Name = name;
        }

        public readonly DateTime Date;
        public readonly string Name;

    }
}
