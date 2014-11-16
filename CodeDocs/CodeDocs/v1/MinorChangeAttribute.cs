using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    [Obsolete(Constants.v1_Obsolete_Message)]
    public class MinorChangeAttribute : ChangeAttribute
    {
        public MinorChangeAttribute(int year, int month, int day, string who, string what, string why)
            : base(year, month, day, who, what, why)
        {
        }
    }
}
