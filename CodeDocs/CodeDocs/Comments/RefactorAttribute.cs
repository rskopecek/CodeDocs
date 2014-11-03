using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Comments
{
    /// <summary>
    /// Working feature that needs improvement
    /// </summary>
    public class RefactorAttribute : CodeBasedCommentAttribute
    {
        public RefactorAttribute(string details) : base(details)
        {
        }

        public RefactorAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
