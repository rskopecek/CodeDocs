using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Identification
{
    public class MinorChangeAttribute : ChangeAttribute
    {
        public MinorChangeAttribute(string who, string what, DateTime when, string why) : base(who, what, when, why)
        {
        }
    }
}
