using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.CI00002
{
    /// <summary>
    /// Unsure of actual intent.
    /// </summary>
    [Obsolete(Constants.Ci00002ObsoleteMessage)]
    public class PurposeAttribute : CodeBasedCommentAttribute
    {
        public PurposeAttribute(string details)
            : base(details)
        {
        }
        public PurposeAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
