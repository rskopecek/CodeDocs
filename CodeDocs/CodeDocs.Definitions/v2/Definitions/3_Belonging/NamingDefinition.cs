using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeDocs.Definitions.v2
{
    public class NamingDefinition : Definition
    {
        public NamingDefinition()
            : base(
                "Naming", false,
                Risk.Low,
                Effort.Small,
                "Intent is clear.  However, naming could be cleaner.",
                "Meaning")
        {
        }
    }
}
