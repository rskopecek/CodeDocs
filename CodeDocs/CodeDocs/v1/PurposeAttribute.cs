using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    /// <summary>
    /// Unsure of actual intent.
    /// </summary>
    [Obsolete(Constants.v1_Obsolete_Message)]
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
