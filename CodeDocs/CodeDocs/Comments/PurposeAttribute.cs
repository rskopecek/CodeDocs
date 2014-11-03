using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Comments
{
    /// <summary>
    /// Unsure of actual intent.
    /// </summary>
    public class PurposeAttribute : CodeBasedCommentAttribute
    {
        public PurposeAttribute(string details) : base(details)
        {
        }

        public PurposeAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
