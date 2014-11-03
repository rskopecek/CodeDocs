using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Identification
{
    /// <summary>
    /// Identification of a change worth noting
    /// </summary>
    public class ChangeAttribute : Attribute
    {
        public ChangeAttribute(int year, int month, int day, string who, string what, string why)
        {
            Who = who;
            What = what;
            When = new DateTime(year, month, day);
            Why = why;
        }

        public string Who { get; private set; }

        public string What { get; private set; }

        public DateTime When { get; private set; }

        public string Why { get; private set; }

        public string TrackingSystem { get; private set; }

        public string TrackingId { get; private set; }

    }
}
