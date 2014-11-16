using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    /// <summary>
    /// Hard to read at first glance for one or more people
    /// </summary>
    [Obsolete(Constants.v1_Obsolete_Message)]
    public class ReadabilityAttribute : CodeBasedCommentAttribute
    {
        public ReadabilityAttribute(string details)
            : base(details)
        {
        }
        public ReadabilityAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
