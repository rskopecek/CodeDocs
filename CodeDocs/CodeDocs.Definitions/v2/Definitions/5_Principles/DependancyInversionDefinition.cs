using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class DependancyInversionDefinition : Definition
    {
        public DependancyInversionDefinition()
            : base(// Acronym = DIP
                "DependancyInversion", true,
                Risk.Moderate,
                Effort.Medium,
                "[The D in SOLID] Depend upon Abstractions. Do not depend upon concretions.",
                 "Principles")
        {
        }
    }
}
