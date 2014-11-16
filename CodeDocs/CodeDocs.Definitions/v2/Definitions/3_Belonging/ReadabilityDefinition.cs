using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class ReadabilityDefinition : Definition
    {
        public ReadabilityDefinition()
            : base(
                "Readability", false,
                Risk.Low,
                Effort.Small,
                "Hard to read at first glance for one or more people.",
                "Meaning")
        {
        }
    }
}
