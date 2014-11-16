using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class SingleResponsibilityDefinition : Definition
    {
        public SingleResponsibilityDefinition()
            : base( // Acronym: SRP
                "SingleResponsibility", true,
                Risk.Moderate,
                Effort.Medium,
                "[The S in SOLID] Each context of code should do one thing and thus have only one reason to change.",
                 "Principles", "SOLID")
        {
        }
    }
}
