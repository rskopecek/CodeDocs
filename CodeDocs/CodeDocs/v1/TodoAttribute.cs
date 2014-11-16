using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    /// <summary>
    /// Uncompleted feature
    /// </summary>
    [Obsolete(Constants.v1_Obsolete_Message)]
    public class TodoAttribute : CodeBasedCommentAttribute
    {
        public TodoAttribute(string details)
            : base(details)
        {
        }
        public TodoAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
