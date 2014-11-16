using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class RefactorDefinition : Definition
    {
        public RefactorDefinition()
            : base(
                "Refactor", false,
                Risk.Low,
                Effort.Unknown,
                "Working feature that needs improvement.",
                "Degredation")
        {
        }
    }
}
