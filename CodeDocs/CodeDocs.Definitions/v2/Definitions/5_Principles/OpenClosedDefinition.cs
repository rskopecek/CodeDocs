using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class OpenClosedDefinition :  Definition
    {
        public OpenClosedDefinition()
            : base( // Acronym: OCP
                "OpenClosed", true,
                Risk.Moderate,
                Effort.Medium,
                "[The O in SOLID] Software entities should be open for extension, but closed for modification.",
                 "Principles", "SOLID")
        {
        }
    }
}
