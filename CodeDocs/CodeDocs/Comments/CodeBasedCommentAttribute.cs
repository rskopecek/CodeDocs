using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodeDocs.Comments
{
    public abstract class CodeBasedCommentAttribute : Attribute
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
