using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.CI00002
{
    [Obsolete(Constants.Ci00002ObsoleteMessage)]
    public class MajorChangeAttribute : ChangeAttribute
    {
        public MajorChangeAttribute(int year, int month, int day, string who, string what, string why)
            : base(year, month, day, who, what, why)
        {
        }
    }
}
