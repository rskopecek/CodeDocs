using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    /// <summary>
    /// "if" a potential future scenario occurs, this will need to be changed or these are some insights about the change.
    /// </summary>
    [Obsolete("New name is Future.  " + Constants.v1_Obsolete_Message)]
    public class WhenAttribute : CodeBasedCommentAttribute
    {
        public WhenAttribute(string details)
            : base(details)
        {
        }
        public WhenAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
