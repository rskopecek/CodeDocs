using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class PurposeDefinition : Definition
    {
        public PurposeDefinition()
            : base(
                "Purpose", false,
                Risk.Moderate,
                Effort.Medium,
                "Unsure of actual intent.",
                "Meaning")
        {
        }
    }
}
