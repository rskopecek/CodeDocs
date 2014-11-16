using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class ToxicDefinition : Definition
    {
        public ToxicDefinition()
            : base(
                "Toxic", false,
                Risk.Extreme,
                Effort.Unknown,
                "A piece of code that is extremely tempermental, developers should be cautioned, and refactoring is required.",
                 "Toxic", "Degredation")
        {
        }
    }
}
