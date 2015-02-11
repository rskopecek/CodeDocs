using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.CI00002
{
    /// <summary>
    /// Test scenario that appears to be missing
    /// </summary>
    [Obsolete(Constants.Ci00002ObsoleteMessage)]
    public class TestAttribute : CodeBasedCommentAttribute
    {
        public TestAttribute(string details)
            : base(details)
        {
        }
        public TestAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
