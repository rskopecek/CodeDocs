using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class ConsequenceDefinition : Definition
    {
        public ConsequenceDefinition()
            : base(
                "Consequence", true,
                Risk.Moderate,
                Effort.Unknown,
                "A side-effect that may occur either by the behavior of the code or if a change is made to the code.",
                 "Consequence")
        {
        }
    }
}
