using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Identification
{
    public class MajorChangeAttribute : ChangeAttribute
    {
        public MajorChangeAttribute(string who, string what, DateTime when, string why)
            : base(who, what, when, why)
        {
        }        
    }
}
