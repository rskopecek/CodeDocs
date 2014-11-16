using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class ReviewedDefinition : Definition
    {
        public ReviewedDefinition()
            : base(
                "Reviewed", true,
                Risk.None,
                Effort.None,
                "Used to tag that an area of code has been reviewed by one or more people.",
                "Review")
        {
        }
    }
}
