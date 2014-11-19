using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.CI00002
{
    /// <summary>
    /// Uncompleted feature
    /// </summary>
    [Obsolete(Constants.Ci00002ObsoleteMessage)]
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
