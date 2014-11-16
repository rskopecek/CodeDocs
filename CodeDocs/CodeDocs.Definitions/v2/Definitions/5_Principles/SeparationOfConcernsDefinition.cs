using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class SeparationOfConcernsDefinition : Definition
    {
        public SeparationOfConcernsDefinition()
            : base( // Acronym: SoC
                "SeparationOfConcerns", true,
                Risk.Moderate,
                Effort.Medium,
                "The design should divide areas of concern into their own distinct sections.",
                 "Principles")
        {
        }
    }
}
