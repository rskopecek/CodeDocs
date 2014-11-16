using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class BugDefinition : Definition
    {
        public BugDefinition()
            : base(
                "Bug", true,
                Risk.Extreme,
                Effort.Unknown,
                "Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented.",
                "Degredation")
        {
        }
    }
}