using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Comments
{
    /// <summary>
    /// Piece of code that appears to be in the wrong place
    /// </summary>
    public class LocationAttribute : CodeBasedCommentAttribute
    {
        public LocationAttribute(string details) : base(details)
        {
        }

        public LocationAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
