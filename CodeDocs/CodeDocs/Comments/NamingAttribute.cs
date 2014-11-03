using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Comments
{
    /// <summary>
    /// Intent is clear.  However, naming could be cleaner.
    /// </summary>
    public class NamingAttribute : CodeBasedCommentAttribute
    {
        public NamingAttribute(string details) : base(details)
        {
        }

        public NamingAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
