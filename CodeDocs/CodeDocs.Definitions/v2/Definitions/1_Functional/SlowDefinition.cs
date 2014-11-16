using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class SlowDefinition : Definition
    {
        public SlowDefinition()
            : base(
                "Slow", false,
                Risk.Moderate,
                Effort.Medium,
                "A piece of code that is slower than desired and need refactored.",
                 "Performance", "Degredation")
        {
        }
    }
}
