using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class InterfaceSegregationDefinition : Definition
    {
        public InterfaceSegregationDefinition()
            : base( // Acronym: ISP
                "InterfaceSegregation", true,
                Risk.Moderate,
                Effort.Medium,
                "[The I in SOLID] Many client-specific interfaces are better than one general-purpose interface.",
                 "Principles", "SOLID")
        {
        }
    }
}
