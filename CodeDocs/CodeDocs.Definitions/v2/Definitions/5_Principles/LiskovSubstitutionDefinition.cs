using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class LiskovSubstitutionDefinition : Definition
    {
        public LiskovSubstitutionDefinition()
            : base( // Acronym: LSP
                "LiskovSubstitution", true,
                Risk.Moderate,
                Effort.Medium,
                "[The L in SOLID] Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.",
                 "Principles", "SOLID")
        {
        }
    }
}
