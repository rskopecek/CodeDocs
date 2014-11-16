using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class MinorChangeDefinition : Definition
    {
        public MinorChangeDefinition()
            : base(
                "MinorChange", true,
                Risk.None,
                Effort.None,
                "Identification of a minor change that is important to communicate and potentially worthy of moving the version # forward if any exist during deployment (major.minor.incr).",
                "Change", "Minor")
        {
        }
    }
}
