using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class OccamsRazorDefinition : Definition
    {
        public OccamsRazorDefinition()
            : base(
                "OccamsRazor", true,
                Risk.Moderate,
                Effort.Medium,
                "The path with the fewest assumptions should be selected even if other directions may eventually prove correct.",
                 "Principles")
        {
        }
    }
}
