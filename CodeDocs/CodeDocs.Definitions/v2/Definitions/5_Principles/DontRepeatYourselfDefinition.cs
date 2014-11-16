using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class DontRepeatYourselfDefinition : Definition
    {
        public DontRepeatYourselfDefinition()
            : base( // Acronym: DRY
                "DontRepeatYourself", true,
                Risk.Moderate,
                Effort.Medium,
                "(DRY) Every piece of knowledge must have a single, unambiguous, authoritative representation within a system.",
                 "Principles")
        {
        }
    }
}
