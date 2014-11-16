using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class MajorFixDefinition : Definition
    {
        public MajorFixDefinition()
            : base(
                "MajorFix", true,
                Risk.None,
                Effort.None,
                "Identification of a major fix that is important to communicate and potentially worthy of moving the [incr] version # forward if any exist during deployment (major.minor.incr).",
                "Change", "Major", "Fix")
        {
        }
    }
}
