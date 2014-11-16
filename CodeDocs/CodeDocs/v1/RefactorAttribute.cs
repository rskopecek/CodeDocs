using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    /// <summary>
    /// Working feature that needs improvement
    /// </summary>
    [Obsolete(Constants.v1_Obsolete_Message)]
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
