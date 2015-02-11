using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.CI00002
{
    /// <summary>
    /// Intent is clear. However, naming could be cleaner.
    /// </summary>
    [Obsolete(Constants.Ci00002ObsoleteMessage)]
    public class NamingAttribute : CodeBasedCommentAttribute
    {
        public NamingAttribute(string details)
            : base(details)
        {
        }
        public NamingAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
