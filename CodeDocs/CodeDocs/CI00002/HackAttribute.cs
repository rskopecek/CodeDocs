using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.CI00002
{
    /// <summary>
    /// Working feature. Requires refactoring due to shortcuts needed to make it work.
    /// </summary>
    [Obsolete(Constants.Ci00002ObsoleteMessage)]
    public class HackAttribute : CodeBasedCommentAttribute
    {
        public HackAttribute(string details)
            : base(details)
        {
        }
        public HackAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
