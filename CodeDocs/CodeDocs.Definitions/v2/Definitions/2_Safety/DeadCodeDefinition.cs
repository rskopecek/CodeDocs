using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class DeadCodeDefinition : Definition
    {
        public DeadCodeDefinition()
            : base(
                "DeadCode", false,
                Risk.Low,
                Effort.VerySmall,
                "Typically code that is commented out or code that exists but is never used.",
                "DeadCode")
        {
        }
    }
}
