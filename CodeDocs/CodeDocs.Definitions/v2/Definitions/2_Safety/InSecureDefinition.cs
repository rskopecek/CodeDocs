using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class InSecureDefinition : Definition
    {
        public InSecureDefinition()
            : base(
                "InSecure", true,
                Risk.Extreme,
                Effort.Unknown,
                "An identified security issue.",
                 "Security", "InSecure", "Degredation")
        {
        }
    }
}
