using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class HackDefinition : Definition
    {
        public HackDefinition()
            : base(
                "Hack", true,
                Risk.Moderate,
                Effort.Unknown,
                "Working feature.  Requires refactoring due to shortcuts needed to make it work.",
                "Degredation")
        {
        }
    }
}
