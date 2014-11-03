using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Comments
{
    /// <summary>
    /// Test scenario that appears to be missing
    /// </summary>
    public class TestAttribute : CodeBasedCommentAttribute
    {
        public TestAttribute(string details) : base(details)
        {
        }

        public TestAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
