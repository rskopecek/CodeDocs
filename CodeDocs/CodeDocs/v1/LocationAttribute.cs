using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.v1
{
    /// <summary>
    /// Piece of code that appears to be in the wrong place
    /// </summary>
    [Obsolete(Constants.v1_Obsolete_Message)]
    public class LocationAttribute : CodeBasedCommentAttribute
    {
        public LocationAttribute(string details)
            : base(details)
        {
        }
        public LocationAttribute(int riskLevel, string details)
            : base(riskLevel, details)
        {
        }
    }
}
