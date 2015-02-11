using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.CI00002
{
    /// <summary>
    /// Working feature that needs improvement
    /// </summary>
    [Obsolete(Constants.Ci00002ObsoleteMessage)]
    public class RefactorAttribute : CodeBasedCommentAttribute
    {
        public RefactorAttribute(string details)
            : base(details)
        {
        }
        public RefactorAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
