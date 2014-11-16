using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class StandardsDefinition : Definition
    {
        public StandardsDefinition()
            : base(
                "Standards", false,
                Risk.Low,
                Effort.VerySmall,
                "A piece of code that needs refactored to adhere to code/design standards.",
                "Standards")
        {
        }
    }
}
