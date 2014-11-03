using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Identification
{
    public class MajorChangeAttribute : ChangeAttribute
    {
        public MajorChangeAttribute(int year, int month, int day, string who, string what, string why)
            : base(year, month, day, who, what, why)
        {
        }        
    }
}
