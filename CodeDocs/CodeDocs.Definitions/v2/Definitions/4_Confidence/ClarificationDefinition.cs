using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class ClarificationDefinition : Definition
    {
        public ClarificationDefinition()
            : base(
                "Clarification", true,
                Risk.Low,
                Effort.VerySmall,
                "Readable, but missing a 'good to know' for people trying to understand.",
                "Meaning")
        {
        }
    }
}
