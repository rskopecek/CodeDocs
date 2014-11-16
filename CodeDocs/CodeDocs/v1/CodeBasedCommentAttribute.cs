using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    [Obsolete(Constants.v1_Obsolete_Message)]
    public abstract class CodeBasedCommentAttribute : CodeDocsBaseAttribute
    {
        protected CodeBasedCommentAttribute(string details)
        {
            RiskLevel = 1;
            Details = details;
        }
        protected CodeBasedCommentAttribute(int riskLevel, string details)
        {
            RiskLevel = riskLevel > 0 ? riskLevel : 1;
            Details = details;
        }
        public string Details { get; protected set; }
        public int RiskLevel { get; protected set; }
    }
}
